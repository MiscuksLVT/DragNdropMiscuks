using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float TimeLeft;
    public bool TimerOn = false;
    public GameObject UzvarSkreen;
    int cur = 0;
    public Text TimerTxt;
    public GameObject Pirma;
    public GameObject Divi;
    public GameObject Tris;
    void Start()
    {
        TimerOn = true;
        UzvarSkreen.SetActive(false);
    }

    void Update()
    {

        TimeLeft += Time.deltaTime;
        updateTimer(TimeLeft);




    }
    void updateTimer(float currentTime)
    {
        if (TimerOn)
        {
            currentTime += 1;
            cur = Mathf.FloorToInt(currentTime);
            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }

    public  void Izvade()
    {
        TimerOn = false;
        UzvarSkreen.SetActive(true);

     


        if (cur <= 60)
        {
            Pirma.SetActive(true);
            Divi.SetActive(true);
            Tris.SetActive(true);
        }else if (cur<=90)
        {
            Pirma.SetActive(true);
            Divi.SetActive(true);

        }else if (cur<=140)//140
        {
            Pirma.SetActive(true);
            
        }else if (cur>180)//180
        {

        }
    }
   
}
