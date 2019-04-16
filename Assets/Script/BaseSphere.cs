using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Transform tsf = transform.Find("SphereTR1");
        tsf.LookAt(new Vector3(0, 0, 0));
        GameObject go = GameObject.Find("SphereTR1");
        go.transform.Translate(new Vector3(0, 0, 2));
        GameObject kke = GameObject.FindGameObjectWithTag("BaseObj");
        kke.transform.Translate(new Vector3(0, 0, 1));

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
