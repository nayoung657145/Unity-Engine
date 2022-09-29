using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomPage : MonoBehaviour
{
   public void ClickButton () 
   {
        SceneManager.LoadScene("Lobby");
   }
}
