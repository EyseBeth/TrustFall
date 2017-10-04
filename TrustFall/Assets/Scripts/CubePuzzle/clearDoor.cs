using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearDoor : MonoBehaviour {
    public float clearing= 0.9f;
    public Vector3 spin = new Vector3(0, 0, 5);
    void Update()
    {
        if (cubePuzzleCorrect.Check)
        {
            if (transform.localScale != Vector3.zero)
            {
                transform.localScale *= clearing;
                transform.Rotate(spin);
            }
            else
            {
                transform.localScale = Vector3.zero;
            }
            
        }
    }
}
