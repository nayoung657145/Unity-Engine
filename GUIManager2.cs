using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager2 : MonoBehaviour
{
    public static bool playerType2; 

    public GameObject performCamera1;
    public GameObject performCamera2;

    public GameObject performGUI;
    public GameObject audienceGUI;


    void Start()
    {
        if(playerType2)  //공연자 라면
        {
            PerformSetting();
            Debug.Log("공연장2 : 공연자 GUI, 카메라 설정");

        }
        else  //관객이라면
        {
            AudienceSetting();
            Debug.Log("관객 GUI 및 카메라 설정");
        }
    }

    public void AudienceSetting() 
    {
        performCamera1.SetActive(false);
        performCamera2.SetActive(false);

        performGUI.SetActive(false);
        audienceGUI.SetActive(true);
    }

    public void PerformSetting() 
    {
        performCamera1.SetActive(true);
        performCamera2.SetActive(true);

        performGUI.SetActive(true);
        audienceGUI.SetActive(false);
    }
}
