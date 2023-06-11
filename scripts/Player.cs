using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    //configs
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] float climbSpeed = 5f;
    [SerializeField] Vector2 deathCkik = new Vector2(2f, 2f);
    [SerializeField] float deathDelay = 2f;
    
    //State
    bool isAlive= true;
    //cached config
    Rigidbody2D myrigidbody;
    Animator myAnimator;
    CapsuleCollider2D myBodyCollider2D;
    BoxCollider2D myFeet;
    float gravityScaleAtStart;
    
   
    
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myBodyCollider2D = GetComponent<CapsuleCollider2D>();
        myFeet = GetComponent<BoxCollider2D>();
        gravityScaleAtStart = myrigidbody.gravityScale;
        
        if (GamePrefrence.GetFirstDeath() ==0 )
        {
            GamePrefrence.SetFirstDeath(1); 
            FirstDeathForDebug();
        }
    }

   
    void Update()
    {
        if (!isAlive) { return; }
        Run();
        Jump();
        ClimbLadder();
        FlipSprite();
        Die();
    }
    private void GoinRight()
    {
   
        Vector2 playerVelocity = new Vector2(runSpeed, myrigidbody.velocity.y);
        myrigidbody.velocity = playerVelocity;
        if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders")))
        {
            myAnimator.SetBool("isRunning", false);
            myAnimator.SetBool("isClimbing", true);
        }
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders")))
        {
            bool playerHasHorizontalSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
            myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
        }

    }
    private void GoinLeft()
    {
            Vector2 playerVelocity = new Vector2(-runSpeed, myrigidbody.velocity.y);
            myrigidbody.velocity = playerVelocity;
            if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders")))
            {
            myAnimator.SetBool("isRunning", false);
                myAnimator.SetBool("isClimbing", true);
            }
            if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders")))
            {
                bool playerHasHorizontalSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
                myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
            }
    }

    private void Run()
    {
        bool goingLeft = FindObjectOfType<GoingLeft>().GetIsGoingLeft();
        bool goingRIght = FindObjectOfType<GoingRight>().GetIsGoingRight();
            if (goingLeft)
        {
            GoinLeft();
        }
        else if (goingRIght)
        {
            GoinRight();
        }
        else
        {
            myAnimator.SetBool("isRunning", false);
        }
    }
    private void Jump()
    {
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("ground"))|| myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders"))) { return; }
            

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            myrigidbody.velocity += jumpVelocityToAdd;
        }
    }
    private void GoinUp()
    {
        Vector2 playerClimbVelocity = new Vector2(myrigidbody.velocity.x, climbSpeed);
        myrigidbody.velocity = playerClimbVelocity;
        myAnimator.SetBool("isClimbing", true);
       
    }
    private void GoinDown()
    {
        Vector2 playerClimbVelocity = new Vector2(myrigidbody.velocity.x, -climbSpeed);
        myrigidbody.velocity = playerClimbVelocity;
        myAnimator.SetBool("isClimbing", true);
        
    }
    private void ClimbLadder()
    {
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders"))) {
            myrigidbody.gravityScale = gravityScaleAtStart;
            myAnimator.SetBool("isClimbing", false);
            return; 
        }
        else if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ladders")))
        {
            Vector2 playerVelocity = new Vector2(myrigidbody.velocity.x/3, 0);
            myrigidbody.velocity = playerVelocity;
            myrigidbody.gravityScale = 0;
            bool isGoingUp = FindObjectOfType<GoingUp>().GetIsGoingUp();    
            bool isGoingDown = FindObjectOfType<GoingDown>().GetIsGoingDown();
            if (isGoingUp)
            {
                GoinUp();
                //myrigidbody.gravityScale = 0;
            }
            else if (isGoingDown)
            {
                GoinDown();
                //myrigidbody.gravityScale = 0;
            }
            else
            {
                Vector2 playerClimbVelocity = new Vector2(myrigidbody.velocity.x, 0);
                myrigidbody.velocity = playerClimbVelocity;
            }
        }
    }
    private void Die()
    {
        if (myBodyCollider2D.IsTouchingLayers(LayerMask.GetMask("enemy", "hazards"))){
            myAnimator.SetTrigger("Die");
            myrigidbody.velocity = deathCkik;
            isAlive = false;
            StartCoroutine(DeathDelay());
        }
    } 
    private void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            transform.localScale=new Vector2 (Mathf.Sign(myrigidbody.velocity.x),1f);
        }
    }
    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(deathDelay);
        FindObjectOfType<GameSession>().ProcessPlayerDeath();
    }
    private void FirstDeathForDebug()
    {
        FindObjectOfType<GameSession>().HealthUp();
        FindObjectOfType<GameSession>().ProcessPlayerDeath();
    }
}
