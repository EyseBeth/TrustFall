using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateActivated : MonoBehaviour
{
    public GameObject bridge;
    public Vector3 OGPos;
    public float heightDifference;
    public float moveSpeed;
    public bool activated = false;

    void Start()
    {
        OGPos = bridge.transform.localPosition;
    }

    void Update()
    {
        if (activated)
        {
            //bridge.GetComponent<BridgeMoving>().activated = true;
            if (bridge.transform.position.y < OGPos.y + heightDifference) bridge.transform.Translate(0, moveSpeed, 0);
        }
        else
        {
            //bridge.GetComponent<BridgeMoving>().activated = false;
            if (bridge.transform.position.y > OGPos.y) bridge.transform.Translate(0, -moveSpeed, 0);
        }
    }
    
    /*void Update()
    {
        if (activated)
        {
            if (transform.position.y < OGPos.y+3) transform.Translate(0, 0.1f, 0);
        }
        else
        {
            if (transform.position.y > OGPos.y) transform.Translate(0, -0.1f, 0);
        }
    }*/
}
