using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HierFalse : NetworkBehaviour
{

    public GameObject[] players;


    void OnMouseDown()
    {
        Debug.Log("ded");
        players = GameObject.FindGameObjectsWithTag("Player");

        foreach (var p in players)
        {
            p.GetComponent<PlayerController>().RpcRespawn();

        }
    }
}
