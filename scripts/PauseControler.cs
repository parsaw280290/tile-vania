using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControler : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject joyStick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PauseButtonActive();
        PauseHider();
    }
    private void PauseButtonActive()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex != 0)
        {
            if (pausePanel.activeInHierarchy)
            {
                pauseButton.SetActive(false);
            }
            pauseButton.SetActive(true);

        }
    }
    private void PauseHider()
    {
        if (pausePanel.gameObject.activeInHierarchy == false)
        {
            joyStick.SetActive(true);
        }
        else
        {
            joyStick.SetActive(false);
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        pausePanel.SetActive(true);
    }
    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
