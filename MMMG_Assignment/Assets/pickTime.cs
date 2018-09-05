using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pickTime : MonoBehaviour {
    public GameObject timePick;
    public int bonus = 10;
    public Timer time;
    public void OnTriggerEnter()
    {
        timePick.SetActive(false);
        time.timeLeft += bonus;
       // timetime.text = ""+ timeInt;
    }

}
