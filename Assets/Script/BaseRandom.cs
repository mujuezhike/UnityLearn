using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRandom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int i = Random.Range(0, 10);
        if (i == 0)
        {
            this.transform.Rotate(new Vector3(0, 0, 1f), 1f);
        }

        if (i == 1)
        {
            this.transform.Rotate(new Vector3(0,  1f, 0), 1f);
        }

        if (i == 2)
        {
            this.transform.Rotate(new Vector3(1f, 0, 0), 1f);
        }

        if (i > 2)
        {
            this.transform.Translate(this.transform.forward * 0.01f, Space.Self);
        }
    }
}
