using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTest2 : MonoBehaviour {

    private int ee = 3;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Move", 15, 0.1f);

        //Move1();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Move()
    {
        this.transform.Translate(new Vector3(-0.3f, 0, 0));
    }

}
