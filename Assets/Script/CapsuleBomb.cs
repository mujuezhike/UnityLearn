﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBomb : MonoBehaviour {

    public GameObject expo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = GameObject.Instantiate<GameObject>(expo);
        go.transform.position = this.transform.position;
        go.SetActive(true);
        GameObject go1 = GameObject.Instantiate<GameObject>(expo);
        go1.transform.position = this.transform.position;
        go1.SetActive(true);
        //GameObject go2 = GameObject.Instantiate<GameObject>(expo);
        //go2.transform.position = this.transform.position;
        //go2.SetActive(true);
        Destroy(this.gameObject);
    }
}
