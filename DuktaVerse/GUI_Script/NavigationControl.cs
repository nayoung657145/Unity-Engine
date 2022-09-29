using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationControl : MonoBehaviour
{
    public GameObject navi;
    bool state;

    int count = 0;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        state = false;
        navi.SetActive(state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NavigationIconClickEvent() 
    {
        if(state) {     //네비게이션이 활성화 됐다면
            GameObject.FindWithTag("Player").GetComponent<TPSCharacterController>().enabled = true;
            state = false;
            navi.SetActive(state);

        }
        else {
            GameObject.FindWithTag("Player").GetComponent<TPSCharacterController>().enabled = false;
            state = true;
            navi.SetActive(state);
        }
    }
}
