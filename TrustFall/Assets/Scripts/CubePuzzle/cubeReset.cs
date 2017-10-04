using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeReset : MonoBehaviour {
    Vector3 startPosition;
    Quaternion startRotation;
    // Use this for initialization
    // Update is called once per frame
    void Start () {
        startPosition = transform.position;
        startRotation = transform.rotation;
	}
    void Update()
    {
        if (cubePuzzleCorrect.WrongCheck)
        {
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }
}
