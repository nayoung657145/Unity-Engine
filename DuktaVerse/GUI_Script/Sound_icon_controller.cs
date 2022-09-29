using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_icon_controller : MonoBehaviour
{
    public RawImage sound_on;
    public RawImage sound_off;

    // Start is called before the first frame update
    void Start()
    { 
        sound_on.enabled = true;
        sound_off.enabled = false;
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoundOnClickEvent() {
        sound_on.enabled = false;
        sound_off.enabled = true;
    }
    public void SoundOffClickEvent() {
        sound_off.enabled = false;
        sound_on.enabled = true;
    }
}
