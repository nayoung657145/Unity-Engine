using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{   
    public Button goToMainBTN;
    void OnEnable ()
    {
        if(SceneManager.GetActiveScene().name != "GUI_main")
        {
            goToMainBTN.gameObject.SetActive(true);
        }
        else
        {
            goToMainBTN.gameObject.SetActive(false);
        }
    }
    public void GoToMainButton () 
   {
      SceneManager.LoadScene("New Scene");
   }
}
