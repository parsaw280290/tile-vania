using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] Text livesText;
    [SerializeField] Text ScoreText;
    [SerializeField] public int playerScore = 0;
    [SerializeField] float deathDelay = 22f;
    [SerializeField] Text chapter;
   
    public static GameSession instence;


   
    private void Awake()
    {
        int numGameSession = FindObjectsOfType<GameSession>().Length;
        if(numGameSession >1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        if (instence == null)
        {
            instence = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = playerLives.ToString();
        ScoreText.text = playerScore.ToString();
        ChapterText();
    }

    private void Update()
    {
        ChapterText();
        ScoreText.text = playerScore.ToString();
    }

    
    public void AddToScore(int amountOfScore)
    {
        playerScore += amountOfScore;
        ScoreText.text = playerScore.ToString();
    }
    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            GamePrefrence.SetFirstDeath(0);
            ResetGameSession();
        }
    }

    private void TakeLife()
    {
        playerLives--;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(WaitForDeath());
        SceneManager.LoadScene(currentSceneIndex);
        livesText.text = playerLives.ToString();
    }

    private void ResetGameSession()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex <= 7)
        {
            playerScore = 0;
            SceneManager.LoadScene(1);
        Destroy(gameObject);
        }
        else if(currentSceneIndex > 7 && currentSceneIndex <= 11)
        {
            playerScore = GamePrefrence.GetFirstCoin();
            SceneManager.LoadScene(8);
            Destroy(gameObject);
        }
        else if(currentSceneIndex >11 && currentSceneIndex <= 15)
        {
            playerScore = GamePrefrence.GetSecondCoin();
            SceneManager.LoadScene(12);
            Destroy(gameObject);
        }
        else if(currentSceneIndex >15 && currentSceneIndex <= 19)
        {
            playerScore = GamePrefrence.GetThirdCoin();
            SceneManager.LoadScene(16);
            Destroy(gameObject);
        }
        else if (currentSceneIndex == 20)
        {
            playerScore = GamePrefrence.GetFourthCoin();
            SceneManager.LoadScene(20);
            Destroy(gameObject);
        }
    }
    public void HealthUp()
    {
        playerLives += 1;
        livesText.text = playerLives.ToString();

    }
    IEnumerator WaitForDeath()
    {
        yield return new WaitForSeconds(deathDelay);
    }
    private void ChapterText()
    {
        var level = SceneManager.GetActiveScene().buildIndex;
        if (level == 0)
        {
            chapter.text = "";
        }
        if (level > 0 && level <= 7)
        {
            chapter.text = "Chapter 1";
            GamePrefrence.SetFirstCoin(playerScore);
        }
        if (level >7 && level <= 11)
        {
            chapter.text = "Chapter 2";
            GamePrefrence.SetSecondCoin(playerScore);
        }
        if (level > 11 && level <= 15)
        {
            chapter.text = "Chapter 3";
            GamePrefrence.SetThirdCoin(playerScore);
        }
        if(level >15 && level <= 19)
        {
            chapter.text = "Chapter 4";
            GamePrefrence.SetFourthCoin(playerScore);
        }
        if(level == 20)
        {
            chapter.text = "Last Chapter";
            GamePrefrence.SetLastCoin(playerScore);
        }
    }
}
