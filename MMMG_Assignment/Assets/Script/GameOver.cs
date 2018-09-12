using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void RSecondLv()
    {
        SceneManager.LoadScene("SecondLevel");
    }

    public void RThirdLv()
    {
        SceneManager.LoadScene("ThirdLevel");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("StartScene");
    }
}
