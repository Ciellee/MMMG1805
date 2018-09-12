using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    public static bool doorKey;
    [SerializeField] private string loadLevel;

    void OnTriggerEnter(Collider other)
    {
        if (doorKey == true)
        {
            SceneManager.LoadScene(loadLevel);
        }
        else
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Need Sun!");
        }

    }

}
