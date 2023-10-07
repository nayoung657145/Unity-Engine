using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
/// <summary>
/// 공연자가 공연시간이 끝나면 자동으로 퇴장되도록 하는 코드
/// </summary>
public class ExitHall : MonoBehaviourPun
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!photonView.IsMine)
        {
            return;
        }
        
        if(GUIManager.playerType1)   //공연자라면
        {
            if(RemainingTime.end)
            {
                SceneManager.LoadScene("New Scene");
                GUIManager.playerType1 = false;

                TodayPerInfo_talk.concertType1 = false;

                Debug.Log("공연1 종료 : 공연자 -> 관객");
            }
        }
        else if(GUIManager2.playerType2)   //공연자라면
        {
            if(RemainingTime.end)
            {
                SceneManager.LoadScene("New Scene");
                GUIManager2.playerType2 = false;

                TodayPerInfo.concertType2  = false;

                Debug.Log("공연2 종료 : 공연자 -> 관객");
            }
        }
    }

    
}
