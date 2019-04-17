using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shoot : MonoBehaviour {
    GameObject g = null;

    // Use this for initialization
    void Start () {
        transform.Find("Sphere").position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            g = GameObject.Instantiate(transform.Find("Sphere").gameObject);
            g.transform.localScale = transform.Find("Sphere").lossyScale;
            g.SetActive(true);
        }
    }
}
