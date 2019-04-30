using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCom2 : MonoBehaviour {

    private Rigidbody rd;
    // Use this for initialization
    void Start()
    {
        rd = this.gameObject.GetComponent<Rigidbody>();
        rd.AddForce(new Vector3(-500, 0, 0), ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
