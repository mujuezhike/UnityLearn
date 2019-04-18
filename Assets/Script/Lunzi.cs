using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunzi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("w")
            || Input.GetKey("s")
            || Input.GetKey("d"))
        {
            this.transform.Rotate(Vector3.down, 10);
        }

        if (Input.GetKey("a"))
        {
            this.transform.Rotate(Vector3.up, 10);
        }
    }
}
