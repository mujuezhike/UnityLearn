using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        this.gameObject.AddComponent<Light>();
        Destroy(this.gameObject.GetComponent<Light>());
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, 1);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -1, 0);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -1);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 1, 0);
    }
}
