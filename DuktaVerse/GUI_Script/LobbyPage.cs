using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LobbyPage : MonoBehaviour
{
    public void ClickCustomButton()
    {
        SceneManager.LoadScene("Customizing");
    }
    public void ClickStartButton()
    {
        SceneManager.LoadScene("GUI_main");
    }
}
