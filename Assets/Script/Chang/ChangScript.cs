using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangScript : MonoBehaviour {

    public GameObject go;
    public Rigidbody rd;
    // Use this for initialization
    void Start () {
        rd = go.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float f1 = go.transform.position.x;
        float f2 = go.transform.position.y;
        float f3 = go.transform.position.z;
        if (f1<-10)
        {
            rd.AddForce(new Vector3(2,0,0));
        }
        if (f1 > 10)
        {
            rd.AddForce(new Vector3(-2,0,0));
        }
        if (f2 < -10)
        {
            rd.AddForce(new Vector3(0, 2, 0));
        }
        if (f2 > 10)
        {
            rd.AddForce(new Vector3(0, -2, 0));
        }
        if (f3 < -10)
        {
            rd.AddForce(new Vector3(0, 0, 2));
        }
        if (f3 > 10)
        {
            rd.AddForce(new Vector3(0, 0, -2));
        }

        if (f1 >= -10 && f1 <= 10
            && f2 >= -10 && f2 <= 10
            && f3 >= -10 && f3 <= 10)
        {
            rd.AddForce(new Vector3(f1 % 5 + 2, f1 % 5, f1 % 5 - 2));
        }
    }
}
