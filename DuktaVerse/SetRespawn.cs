using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{
    public GameObject respawnPos;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        Vector3 respawn = respawnPos.transform.localPosition;
        player.transform.position = respawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
