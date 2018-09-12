using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Credit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public  void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void SelectLv1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SelectLv2()
    {
        SceneManager.LoadScene("SecondLevel");
    }

    public void SelectLv3()
    {
        SceneManager.LoadScene("ThirdLevel");
    }

    public void PickLv()
    {
        SceneManager.LoadScene("LevelPick");
    }

    public void BackToM()
    {
        SceneManager.LoadScene("StartScene");
    }
}
