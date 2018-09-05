using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pickTime : MonoBehaviour {
    public GameObject timePick;
    public Text time;
    public int bonus = 10;
    public void OnTriggerEnter()
    {
        timePick.SetActive(false);
        time.text = ""+ bonus + int.Parse(time.text);
    }

}
