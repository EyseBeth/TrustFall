using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraController : NetworkBehaviour
{
    public Camera cam;

    void Start()
    {
        if (isLocalPlayer) return;
        cam.enabled = false;
    }
}
