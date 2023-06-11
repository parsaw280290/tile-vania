using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HIghScoreControler : MonoBehaviour
{
    [SerializeField] Text highscoreText;


    private void Start()
    {
        if (GamePrefrence.GetSecondCoin() > 0)
        {
            if (GamePrefrence.GetThirdCoin() > 0)
            {
                if (GamePrefrence.GetFourthCoin() > 0)
                {
                    if (GamePrefrence.GetLastCoin() > 0)
                    {
                        highscoreText.text = GamePrefrence.GetLastCoin().ToString();
                    }
                    highscoreText.text = GamePrefrence.GetFourthCoin().ToString();
                }
                highscoreText.text = GamePrefrence.GetThirdCoin().ToString();
            }
            highscoreText.text = GamePrefrence.GetSecondCoin().ToString();
        }
        highscoreText.text = GamePrefrence.GetFirstCoin().ToString();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
