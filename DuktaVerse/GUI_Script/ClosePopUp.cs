using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUp : MonoBehaviour
{
    public GameObject navigationPopup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            { 
                this.gameObject.SetActive(false);
                navigationPopup.SetActive(true);
            }
        }
    }
}
