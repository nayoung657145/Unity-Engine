using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CurrentTime : MonoBehaviour
{   
    public Text text_date;
    public Text text_time;

    // Start is called before the first frame update
    void Start()
    {
        Init_Time();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Init_Time()
    {
        if (IsInvoking("Update_Time"))
            CancelInvoke("Update_Time");
        InvokeRepeating("Update_Time", 0, 0.2f);
    }
    private void Update_Time()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd ") + DateTime.Now.DayOfWeek.ToString().ToUpper().Substring(0, 3);
        string time = DateTime.Now.ToString("HH:mm");
        text_date.text = date;
        text_time.text = time;

       // Debug.Log( string.Format("{0}\n{1}", date, time)); 

    }
}
