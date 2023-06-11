using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour
{

    [SerializeField] GameObject second, third, forth, last;
    [SerializeField] GameObject u2, u3, u4, u5;

    void Start()
    {
        ImageCheck();
        
   
    }

    private void ImageCheck()
    {
        if(GamePrefrence.GetSecondChapter() == 1)
        {
            second.SetActive(false);
            u2.SetActive(true);
        }
        else
        {
            second.SetActive(true);
            u2.SetActive(false);
        }
        if(GamePrefrence.GetThirdChapter() == 1)
        {
            third.SetActive(false);
            u3.SetActive(true);
        }
        else
        {
            third.SetActive(true);
            u3.SetActive(false);
        }
        if(GamePrefrence.GetFourthChapter() == 1)
        {
            forth.SetActive(false);
            u4.SetActive(true);
        }
        else
        {
            forth.SetActive(true);
            u4.SetActive(false);
        }
        if(GamePrefrence.GetLastChapter() == 1)
        {
            last.SetActive(false);
            u5.SetActive(true);
        }
        else
        {
            last.SetActive(true);
            u5.SetActive(false);
        }
    }

    public void LoadChapterOne()
    {
        GameSession.instence.playerScore = 0;
        SceneManager.LoadScene(1);
    }
    public void LoadSecondChapter()
    {
        if (GamePrefrence.GetSecondChapter() == 1)
        {
            GameSession.instence.playerScore = GamePrefrence.GetFirstCoin();
            SceneManager.LoadScene(8);
        }
    }
    public void LoadThirdChapter()
    {
        if (GamePrefrence.GetThirdChapter() == 1)
        {
            GameSession.instence.playerScore = GamePrefrence.GetSecondCoin();
            SceneManager.LoadScene(12);
        }
    }
    public void LoadFourthChapter()
    {
        if (GamePrefrence.GetFourthChapter() == 1)
        {
            GameSession.instence.playerScore = GamePrefrence.GetThirdCoin();
            SceneManager.LoadScene(16);
        }
    }
    public void LoadLastChapter()
    {
        if (GamePrefrence.GetLastChapter() == 1)
        {
            GameSession.instence.playerScore = GamePrefrence.GetFourthCoin();
            SceneManager.LoadScene(20);
        }
    }
    public void LoadHighScore()
    {
        SceneManager.LoadScene("You Won");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
