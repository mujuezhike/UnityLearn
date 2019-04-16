using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmMoon2 : MonoBehaviour {
    public GameObject CubeAxis;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(CubeAxis.gameObject.transform.position, Vector3.up, -4);
        this.transform.LookAt(CubeAxis.gameObject.transform);
    }
}
