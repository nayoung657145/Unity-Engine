using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
 
public class LoadPHP : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GetMySQLData());
        Debug.Log("start");
    }
 
    private IEnumerator GetMySQLData()
    {
        string serverPath = "http://3.35.93.147/LoadMySQL.php"; //PHP 파일의 위치를 저장
 
        WWWForm form = new WWWForm(); //Post 방식으로 넘겨줄 데이터(AddField로 넘겨줄 수 있음)
 
        using (UnityWebRequest webRequest = UnityWebRequest.Post(serverPath, form)) //웹 서버에 요청
        {
            yield return webRequest.SendWebRequest(); //요청이 끝날 때까지 대기
 
            Debug.Log(webRequest.downloadHandler.text); //서버로부터 받은 데이터를 string 형태로 출력
        }
    }
}