using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
    }
    IEnumerator LoadNextLevel()
    {
        Time.timeScale = 0.2f;
        yield return new WaitForSecondsRealtime(3f);
        Time.timeScale = 1f;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        ChapterUnlocker();
        GamePrefrence.SetFirstDeath(0);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    private void ChapterUnlocker()
    {
        var level = SceneManager.GetActiveScene().buildIndex;
        if(level == 7)
        {
            GamePrefrence.SetSecondChapter(1);
        }
        if(level == 11)
        {
            GamePrefrence.SetThirdChapter(1);
        }
        if(level == 15)
        {
            GamePrefrence.SetFourthChapter(1);
        }
        if(level == 19)
        {
            GamePrefrence.SetLastChapter(1);
        }
    }
}
