using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerformManager : MonoBehaviour
{
    [SerializeField]
    public GameObject settingPanel;
    private bool sound = false;
    private bool video = false;

    public void SettingPanelOff () 
    {
        settingPanel.SetActive(false);
    }

    public void ToggleOnOff (bool isOn) 
    {
        if(isOn) 
        {
            sound = true;
            video = true;
            Debug.Log(sound);
            Debug.Log(video);
        }
        else 
        {
            sound = false;
            video = false;
            Debug.Log(sound);
            Debug.Log(video);
        }
    }
   
}
