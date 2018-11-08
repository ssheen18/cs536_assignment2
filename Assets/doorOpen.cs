using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {
    bool opened = false;
	private void OnTriggerEnter(Collider other)
    {
        if (opened == false)
        {
            transform.Rotate(0, 0, -90);
            opened = true;
        } 
    }

}
