using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int i1 = Random.Range(-100, 100);
        int i2 = Random.Range(-100, 100);
        int i3 = Random.Range(-100, 100);
        this.transform.LookAt(new Vector3(i1, i2, i3));
    }
	
	// Update is called once per frame
	void Update () {

        int i = Random.Range(0, 300);
        if (i == 0)
        {
            this.transform.Rotate(new Vector3(30, 0, 0));
        }
        if (i == 1)
        {
            this.transform.Rotate(new Vector3(0, 30, 0));
        }
        if (i == 2)
        {
            this.transform.Rotate(new Vector3(0, 0, 30));
        }
        if (i == 3)
        {
            this.transform.Rotate(new Vector3(-30, 0, 0));
        }
        if (i == 4)
        {
            this.transform.Rotate(new Vector3(0, -30, 0));
        }
        if (i == 5)
        {
            this.transform.Rotate(new Vector3(0, 0, -30));
        }
        if (i == 6)
        {
            this.transform.LookAt(new Vector3(0,10,0));
        }
        if (i == 7)
        {
            this.transform.LookAt(new Vector3(0, -10, 0));
        }

        this.transform.Translate(Vector3.up * 0.05f, Space.Self);
    }
}
