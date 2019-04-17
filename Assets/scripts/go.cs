using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class go : MonoBehaviour {
    public Transform t;
	// Use this for initialization
	void Start () {
        transform.position = t.position;
    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(t.up,Space.World);
        Debug.Log(1);
	}
}
