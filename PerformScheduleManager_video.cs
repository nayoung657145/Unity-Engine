using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class PerformScheduleManager_video : MonoBehaviour
{
    public InputField nickNameText;//학번
    //public InputField inputConcertStartTime;//공연 시작 시간
    //public InputField inputConcertEndTime;//공연 종료 시간
    public InputField inputConcertTitle; //공연 제목 
    public InputField inputConcertInfo; //공연 소개

    public Button ConcertReservationButton;//공연예약 버튼

    string ConcertReservationURL = "http://3.35.93.147/ConReserveVideo.php";//song 공연 예약

    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Perform Scheldule Manager started");
    }

    // Update is called once per frame
    void Update()
    
    {
        if (Input.GetKeyDown (KeyCode.Space)) //키보드를 누를 때 
			StartCoroutine(ConcertReservationToDB(nickNameText.text, inputConcertTitle.text, inputConcertInfo.text));
    }

    public void SendCreateAccountButtonOnClicked()
	{
		Debug.Log("ConcertReservationButtonOnClicked");
		ConcertReservationButton.interactable = false;
		StartCoroutine(ConcertReservationToDB(nickNameText.text, inputConcertTitle.text, inputConcertInfo.text));
	}

    IEnumerator ConcertReservationToDB(string nickNameText, string concert_title, string concert_info)
    {
        WWWForm form = new WWWForm ();
        form.AddField("userStuNumberPost", nickNameText); //학번
		//form.AddField("concertStartPost", concert_start);
        //form.AddField("concertEndPost", concert_end);
        form.AddField("concertTitlePost", concert_title);
		form.AddField("concertInfoPost", concert_info);

		using (UnityWebRequest webRequest = UnityWebRequest.Post(ConcertReservationURL, form)) //웹 서버에 요청
        {
            yield return webRequest.SendWebRequest(); //요청이 끝날 때까지 대기
            Debug.Log(webRequest.downloadHandler.text); //서버로부터 받은 데이터를 string 형태로 출력

            TodayPerInfo_video.concertType3 = true;
        }
    }
}
