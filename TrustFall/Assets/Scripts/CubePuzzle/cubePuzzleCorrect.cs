using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePuzzleCorrect : MonoBehaviour {
    static bool check;
    static bool checkWrong;
    public GameObject[] players;

    public static bool WrongCheck
    {   
       get { return checkWrong; }
       
    }

    public static bool Check
    {
        get { return check; }

    }

    // Use this for initialization
    void Start () {
        check = false;
        checkWrong = false;
	}
	

	// Update is called once per frame
	void Update () {
        if (check)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (checkWrong)
        {
            players = GameObject.FindGameObjectsWithTag("Player");

            foreach (var p in players)
            {
                p.GetComponent<PlayerController>().RpcRespawn();

            }
            checkWrong = false;
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("cubeRed"))
        {
            check = true;
        }

        if (collision.collider.CompareTag("cubeBlue") || collision.collider.CompareTag("cubeGreen"))
        {
            checkWrong = true;
        }
    }


}

