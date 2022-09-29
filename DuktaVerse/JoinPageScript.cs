using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinPageScript : MonoBehaviour
{
    public InputField playerName; //이름
    public InputField playerDept; //학과
    public InputField playerNumber; //학번
    public InputField playerEmail; //학교 이메일
    public InputField playerNickName; //닉네임
    public InputField playerId; //아이디
    public InputField playeyPassword; //비밀번호

    private string pName;
    private enum pDept{
        ITMediaEngineering,
        ComputerEngineering,
        CyberSecurity,
        Software,
        Biotechnology,
        Mathmatics,
        InformationStatistics,
        Chemistry,
        FoodNutrition,
        SportsforAll
    };
    private string pNumber;
    private string pEmail;
    private string pNickName;
    private string pId;
    private string pPassword;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
