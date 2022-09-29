/* 이 파일은 공연 정보창을 반응형 UI롤 만들기 위해 만들어졌습니다.
여기에서 시간에 따른 공연 정보를 받아오는 역할도 해야할 것 같습니다. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoPanelSize : MonoBehaviour
{
    public Image infoPanel;
    public RectTransform infoPanelText;

    // Start is called before the first frame update
    void Start()
    {
        //infoPanelText=gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //infoPanel.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
    }
}
