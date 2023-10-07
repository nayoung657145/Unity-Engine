using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

//로그인 스크립트입니다.
public class LoginManager : MonoBehaviour {

	public InputField inputStuNumber; //id역할 -> 학번
	public InputField inputPassword; //비밀번호 

	public Button LoginButton;//로그인 버튼

	string LoginURL = "http://3.35.93.147/login.php"; //로그인
	

	// Use this for initialization
	void Start () {
		Debug.Log("login manager started"); //가능
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) //키보드를 누를 때 
			StartCoroutine(LoginToDB(inputStuNumber.text, inputPassword.text));
	}

	public void SendButtonOnClicked()
	{
		Debug.Log("SendButtonOnClicked");
		LoginButton.interactable = false;
		StartCoroutine(LoginToDB(inputStuNumber.text, inputPassword.text));
	}

	IEnumerator LoginToDB(string stuNumber, string password)
	{
		WWWForm form = new WWWForm ();
		form.AddField("usernamePost", stuNumber);
		form.AddField("passwordPost", password);

		using (UnityWebRequest webRequest = UnityWebRequest.Post(LoginURL, form)) //웹 서버에 요청
        {
            yield return webRequest.SendWebRequest(); //요청이 끝날 때까지 대기
            Debug.Log(webRequest.downloadHandler.text); //서버로부터 받은 데이터를 string 형태로 출력
        }
	}
}