using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;
public class TodayPerInfo_video : MonoBehaviour
{
    public string[] info;
    public TextMeshProUGUI infoText;

    public static bool concertType3;    //어떤 공연장인지 구분하기 위해서

    void Start()
    {
        
    }

    public void ClickInfoIcon ()
    {
        if(concertType3)
        {
            StartCoroutine(GetMySQLData());
            Debug.Log("start");
        }
        else
        {
            infoText.text = "영근터에 예정된 공연이 없습니다.";
        }
    
    }
    private IEnumerator GetMySQLData()
    {
        string serverPath = "http://3.35.93.147/TodayPerInfoVideo.php"; //PHP 파일의 위치를 저장
 
        WWWForm form = new WWWForm(); //Post 방식으로 넘겨줄 데이터(AddField로 넘겨줄 수 있음)
 
        using (UnityWebRequest webRequest = UnityWebRequest.Post(serverPath, form)) //웹 서버에 요청
        {
            yield return webRequest.SendWebRequest(); //요청이 끝날 때까지 대기

            infoText.text = "\'" + webRequest.downloadHandler.text + "\'" + "이(가) 영근터에서 있을 예정입니다.";


            Debug.Log(webRequest.downloadHandler.text); //서버로부터 받은 데이터를 string 형태로 출력
        }
    }
}
