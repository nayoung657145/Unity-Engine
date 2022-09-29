using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChatControl : MonoBehaviour
{
    public GameObject textChat;
    public Text chatInput;
    public Text message;
    public Text chatting;
    private bool state;

    // Start is called before the first frame update
    void Start()
    {
        state = false;
        textChat = GameObject.FindWithTag("TextChat");
        textChat.SetActive(state);

        chatting.enabled =  true;

        chatInput.enabled = false;
        message.enabled =  false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Return ) )
        {
            if(state)
            {
                chatting.enabled =  true;

                message.enabled =  false;
                chatInput.enabled = false;

                state = false;
                textChat.SetActive(state);
            }
            else
            {
                chatting.enabled =  false;

                message.enabled =  true;
                chatInput.enabled = true;
                
                state = true;
                textChat.SetActive(state);
            }
        }
        
    }
}
