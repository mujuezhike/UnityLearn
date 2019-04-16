using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.Rotate(new Vector3(0.2f,0.6f,0.2f), 0.05f);
        this.transform.Rotate(new Vector3(0, -1, 0), 0.3f);
    }
}
