using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
//회원가입 페이지 스크립트입니다.
public class CreateAccountManager : MonoBehaviour
{

    public InputField inputName; //이름
    public InputField inputMajor; //학과
    public InputField inputStuNumber; //id역할 -> 학번
    public InputField inputEmail; //학교 이메일
    //public InputField inputNickName; //닉네임
	public InputField inputPassword; //비밀번호 

    public Button CreateAccountButton;//로그인 버튼

    string CreateAccountURL = "http://3.35.93.147/CreateAccount.php";//회원가입

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("create account manager started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space)) //키보드를 누를 때 
			StartCoroutine(CreateAccountToDB(inputName.text, inputMajor.text, inputStuNumber.text, inputEmail.text, inputPassword.text));
    }

    public void SendCreateAccountButtonOnClicked()
	{
		Debug.Log("SendCreateAccountButtonOnClicked");
		CreateAccountButton.interactable = false;
		StartCoroutine(CreateAccountToDB(inputName.text, inputMajor.text, inputStuNumber.text, inputEmail.text, inputPassword.text));
	}

    IEnumerator CreateAccountToDB(string name, string major, string stuNumber, string email, string password)
    {
        WWWForm form = new WWWForm ();
        form.AddField("namePost", name);
        form.AddField("usermajorPost", major);
		form.AddField("usernamePost", stuNumber);
        form.AddField("useremailPost", email);
        //form.AddField("usernickNamePost", nickName);
		form.AddField("passwordPost", password);

		using (UnityWebRequest webRequest = UnityWebRequest.Post(CreateAccountURL, form)) //웹 서버에 요청
        {
            yield return webRequest.SendWebRequest(); //요청이 끝날 때까지 대기
            Debug.Log(webRequest.downloadHandler.text); //서버로부터 받은 데이터를 string 형태로 출력
        }
    }
}

