using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;
//using Photon.Pun;
// 공연정보를 읽어오는 스크립트 입니다.
public class PerformInfoManager : MonoBehaviour
{
    private PerformSchelduleManager performscheldulemanager;
    //php에 user의 nickname을 전달
    public Text nickNameText;//학번
    //GameObject nickNameText;//학번
    //Debug.Log(PhotonNetwork.NickName); //학번
    
    //public Text p_info_nickname;
    public Text p_info_start;
    public Text p_info_end;
    public Text p_info_title;
    public Text p_info_info;

	// Use this for initialization
	void Start () {

        //nickNameText.text = PhotonNetwork.NickName;
		StartCoroutine(GetPerformInfoData());
        Debug.Log("PerformInfoManager started");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator GetPerformInfoData()
    {
        string serverPath = "http://3.35.93.147/ReadPerformInfo.php"; //PHP 파일의 위치를 저장
        //playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //nickNameText = GameObject.Find("nickNameText").GetComponent<PerformSchelduleManager>();
 
        WWWForm form = new WWWForm(); //Post 방식으로 넘겨줄 데이터(AddField로 넘겨줄 수 있음)
        //form.AddField("userStuNumberPost",nickNameText.text); //학번 넘겨줌
 
        using (UnityWebRequest webRequest = UnityWebRequest.Post(serverPath, form)) //웹 서버에 요청
        {
            yield return webRequest.SendWebRequest(); //요청이 끝날 때까지 대기
 
            Debug.Log(webRequest.downloadHandler.text); //서버로부터 받은 데이터를 string 형태로 출력
        }
    }
}
