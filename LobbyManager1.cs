using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager1 : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1";

    public Text connectionInfoText;

    public InputField stNumber; //학번(아이디)

    [SerializeField]
    private byte maxPlayersPerRoom = 4;

    void Awake()
    {
        //PhotonNetwork.AutomaticallySyncScene = false;
    }

    void Start()
    {
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.ConnectUsingSettings();

        connectionInfoText.text = "마스터 서버에 접속중...";
    }

    public override void OnConnectedToMaster()
    {
        connectionInfoText.text = "온라인 : 마스터 서버와 연결됨.";

    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        connectionInfoText.text = "오프라인 : 마스터 서버와 연결되지 않음\n접속 재시도 중...";

        PhotonNetwork.ConnectUsingSettings();
    }

    public void Connect()
    {
        PhotonNetwork.LocalPlayer.NickName = stNumber.text;

        if(PhotonNetwork.IsConnected)
        {
            connectionInfoText.text = "룸에 접속...";

            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            connectionInfoText.text = "오프라인 : 마스터 서버와 연결되지 않음\n접속 재시도 중...";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        connectionInfoText.text = "빈 방이 없음, 새로운 방 생성...";
        PhotonNetwork.CreateRoom(null, new RoomOptions {MaxPlayers = maxPlayersPerRoom});
    }

    public override void OnJoinedRoom()
    {
        connectionInfoText.text="방 참가 성공";
        PhotonNetwork.LoadLevel("Lobby");
    }
}