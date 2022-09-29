using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static bool playerType = false;    //false == 관객, true == 공연자.

    void Awake()
    {
        if(playerType == false)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
