using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickTime : MonoBehaviour {
    public GameObject timePick;
    public Text bonusTime;
    public void OnTriggerEnter()
    {
        timePick.SetActive(false);

    }

}
