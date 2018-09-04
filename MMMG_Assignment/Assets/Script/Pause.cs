using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pauseButton, pausePanel, BTMain;

    public void Start()
    {
        OnUnPause();
    }

	public void OnPause()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void OnUnPause()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("StartScene");
    }
}
