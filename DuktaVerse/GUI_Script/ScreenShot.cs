using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShot : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CaptureScreen()
    {
        string timestamp = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        string fileName = "DuktaVerse-SCREENSHOT-" + timestamp + ".png";
        
        CaptureScreenForPC(fileName);
    }

    private void CaptureScreenForPC(string fileName)
    {
        gameObject.SetActive(false);
        ScreenCapture.CaptureScreenshot($"{Application.dataPath}/ScreenShots/" + fileName);
        gameObject.SetActive(true);
    }

}
