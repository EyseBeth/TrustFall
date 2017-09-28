using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierDoorAway : MonoBehaviour {

    public GameObject hierdoor;

    void OnMouseDown()
    {
        hierdoor.transform.localScale = new Vector3(0, 0, 0);
    }

}
