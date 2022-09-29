using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoPanelControl : MonoBehaviour
{
    public Image infoPanel;
    public TextMeshProUGUI infoPanelText;

    // Start is called before the first frame update
    void Start()
    {
        infoPanel.enabled = true;
        infoPanelText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InfoPanelClickEvent() {
        if(infoPanel.enabled)
        {
            infoPanel.enabled = false;
            infoPanelText.enabled = false;
        }
        else
        {
            infoPanel.enabled = true;
            infoPanelText.enabled = true;
        }
    }
}
