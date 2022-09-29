/* 이 파일은 네비게이션 버튼 클릭시 뜨는 팝업창을 제어하기 위한 파일입니다. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NaviClickIcon : MonoBehaviour
{
    public GameObject targetPopup;
    public GameObject NavigationPopup;

    // Start is called before the first frame update
    void Start()
    {
        targetPopup.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickEvent () 
    {
        targetPopup.SetActive(true);
        NavigationPopup.SetActive(false);
    }
}
