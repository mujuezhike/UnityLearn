using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour {

    public GameObject cubeTest;

    public GameObject CubeTest2;

    public GameObject SubCube;
    //private Vector3 pos = new Vector3(0,0,0);
    // Use this for initialization
    void Start () {
        //pos = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //pos += new Vector3(0, 0, 0.1f);
        //this.transform.position = pos;

        this.transform.localPosition += new Vector3(0, 0, 0.01f);
        cubeTest.transform.localPosition += new Vector3(0, 0, -0.01f);
        CubeTest2.transform.Rotate(new Vector3(1, 1, 0), 0.5f);
        CubeTest2.transform.Translate(Vector3.forward * 0.01f,Space.Self);

        
        SubCube.transform.RotateAround(CubeTest2.gameObject.transform.position,Vector3.back,1);
    }
}
