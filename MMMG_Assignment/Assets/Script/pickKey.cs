using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickKey : MonoBehaviour {
    public GameObject keyPick;
    public Text keyCount;
	public void OnTriggerEnter()
    {
        keyPick.SetActive(false);
        keyCount.text = ("Pieces of Sun collect: 1");
        Win.doorKey = true;
    }
}
