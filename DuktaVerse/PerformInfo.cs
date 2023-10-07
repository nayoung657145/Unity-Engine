using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PerformInfo : MonoBehaviourPun
{
    [Header("InputField")]
    public InputField nickNameText;//학번
    public InputField inputConcertStartTime;//공연 시작 시간
    public InputField inputConcertEndTime;//공연 종료 시간
    public InputField inputConcertTitle; //공연 제목 
    public InputField inputConcertInfo; //공연 소개

    [Header("Text")]
    public Text p_info_number;
    public Text p_info_start;
    public Text p_info_end;
    public Text p_info_title;
    public Text p_info_info;

    public void ClickInfoButton () 
    {
        photonView.RPC("SettingText", RpcTarget.All);
    }

    [PunRPC]
    private void SettingText ()
    {
        if(nickNameText.text != null)
        {
            p_info_number.text = nickNameText.text;
            p_info_start.text = inputConcertStartTime.text;
            p_info_end.text = inputConcertEndTime.text;
            p_info_title.text = inputConcertTitle.text;
            p_info_info.text = inputConcertInfo.text;
        }
        else
        {
            p_info_number.text = "공연 없음";
            p_info_start.text = "공연 없음";
            p_info_end.text = "공연 없음";
            p_info_title.text = "공연 없음";
            p_info_info.text = "공연 없음";
        }
    }
}
