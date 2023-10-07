using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class AudienceEnter2 : MonoBehaviourPun
{
    [Header("- Audience Character")]
    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    public GameObject playerPrefab3;
    public GameObject playerPrefab4;
    public GameObject playerPrefab5;
    public GameObject playerPrefab6;
    public GameObject respanwn1;

    [Header("- Performer Character")]
   /*  public GameObject performerPrefab1;
    public GameObject performerPrefab2;
    public GameObject performerPrefab3;
    public GameObject performerPrefab4;
    public GameObject performerPrefab5;
    public GameObject performerPrefab6; */
    public GameObject respanwn2;

    
    public bool playerType;

    GameObject clone;

    void Start()
    {
        playerType = GUIManager2.playerType2;
        
        if(player.LocalPlayerInstance == null) 
        {
            if(playerType)
            {
                PerformerPrefabCreate(SelectCharacter.chName, respanwn2);
            }
            else  
            {
                PrefabCreate(SelectCharacter.chName, respanwn1);
            }
        }
        
    }
    void Update()
    {


    }
    public void PrefabCreate(string ch, GameObject respawn)
    {
        Vector3 respawnPos = respawn.transform.localPosition;

        if(ch == "ch 01")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab1.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 02")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab2.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 03")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab3.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 04")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab4.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 05")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab5.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 06")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab6.name, respawnPos, Quaternion.identity);
        }
        else
        {
            Debug.Log("Not Found Character.");
        }

        clone.transform.Rotate(0, 180, 0);
    }
    public void PerformerPrefabCreate(string ch, GameObject respawn)
    {
        Vector3 respawnPos = respanwn2.transform.localPosition;

        if(ch == "ch 01")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab1.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 02")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab2.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 03")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab3.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 04")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab4.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 05")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab5.name, respawnPos, Quaternion.identity);
        }
        else if(ch == "ch 06")
        {
            clone = PhotonNetwork.Instantiate(playerPrefab6.name, respawnPos, Quaternion.identity);
        }
        else
        {
            Debug.Log("Not Found Character.");
        }
    }

}