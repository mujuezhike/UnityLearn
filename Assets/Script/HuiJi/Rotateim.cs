using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateim : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0.05f, 0, 0), Space.World);
        Quaternion qn = new Quaternion();
    }
}
