using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarPosition : MonoBehaviour
{
    public GameObject waist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.localPosition = waist.transform.position;
        //transform.rotation = waist.transform.rotation;

        Debug.Log("waist" + waist.transform.position + "\tavatar" + transform.position);
        Debug.Log("waist" + waist.transform.rotation + "\tavatar" + transform.rotation);
    }
}
