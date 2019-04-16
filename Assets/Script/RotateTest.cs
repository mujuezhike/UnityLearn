using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0.05f, 0.85f, 0.1f), 3);
        this.transform.Rotate(new Vector3(0, 1f, 0),  0.5f);
        this.transform.Rotate(new Vector3(0, 0, 1f),  0.5f);
        this.transform.Rotate(new Vector3(1f, 0, 0),  0.5f);
    }
}
