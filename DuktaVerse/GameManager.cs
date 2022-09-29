using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public GameObject cube;

    void Start()
    {
        Vector3 respawnPos = cube.transform.localPosition;

        PhotonNetwork.Instantiate(playerPrefab.name, respawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        /* if(Input.GetKeyDown(KeyCode.Escape)){
            PhotonNetwork.LeaveRoom();
        } */
    }
    public override void OnLeftRoom() {
        SceneManager.LoadScene("LoginPage");
    }
}
