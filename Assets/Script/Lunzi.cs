using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunzi : MonoBehaviour {

    public int lr;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Vector3.Distance(this.transform.position, new Vector3(3, 2, 4));
        this.gameObject.GetComponent<AudioListener>();

        if (Input.GetKey("w"))
        {
            this.transform.Rotate(Vector3.down, 10);
        }

        if (Input.GetKey("s"))
        {
            this.transform.Rotate(Vector3.up, 5);
        }

        if (Input.GetKey("a"))
        {
            if (lr == 1)
            {
                this.transform.Rotate(Vector3.up, 7);
            }
            else
            {
                this.transform.Rotate(Vector3.down, 3);
            }
            
        }

        if (Input.GetKey("d"))
        {

            if (lr == 0)
            {
                this.transform.Rotate(Vector3.up, 7);
            }
            else
            {
                this.transform.Rotate(Vector3.down, 3);
            }
        }
    }
}
