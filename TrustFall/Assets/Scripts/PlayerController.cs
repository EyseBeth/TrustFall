using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    private Vector3 respawnPoint;
    public float rotatingSpeed;
    public float forwardSpeed;

    private void Start()
    {
        if (isLocalPlayer)
        {
            respawnPoint = transform.position;
        }
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotatingSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * forwardSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        if (Input.GetKeyDown(KeyCode.R)) CmdRespawn();
    }

    [Command]
    void CmdRespawn()
    {
        RpcRespawn();
    }
    [ClientRpc]
    public void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            transform.position = respawnPoint;
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PressurePlate"))
        {
            collision.collider.GetComponent<PressurePlateActivated>().activated = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("PressurePlate"))
        {
            collision.collider.GetComponent<PressurePlateActivated>().activated = false;
        }
    }

}
