﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0, 1f, 0f), 2);
    }
}
