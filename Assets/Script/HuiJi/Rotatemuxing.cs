using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatemuxing : MonoBehaviour {

    public GameObject muwei1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new  Vector3(0,0.03f,0),Space.World);
        this.transform.Translate(new Vector3(-0.01f, 0, 0), Space.World);
        muwei1.transform.RotateAround(
            this.transform.position,new Vector3(-1,10,1),0.33f);

    }
}
