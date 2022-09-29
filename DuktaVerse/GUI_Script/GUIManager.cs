using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    bool status;

    public Camera performCamera1;
    public Camera performCamera2;
    private Camera audienceCamera;

    public GameObject performGUI;
    public GameObject audienceGUI;

    void Start()
    {
        //status = DontDestroy.playerType;
        status = true; //임시방편
        
        audienceCamera = Camera.main;

        if(status) //공연자 라면
        {
            performCamera1.enabled = true;
            performCamera2.enabled = true;
            audienceCamera.enabled = false;

            performGUI.SetActive(true);
            audienceGUI.SetActive(false);
        }
        else  //관객이라면
        {
            performCamera1.enabled = false;
            performCamera2.enabled = false;
            audienceCamera.enabled = true;

            performGUI.SetActive(false);
            audienceGUI.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
