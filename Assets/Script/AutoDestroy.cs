using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

    public int ms = 100;
	// Use this for initialization
	void Start () {
        ms = 100;
    }
	
	// Update is called once per frame
	void Update () {
        ms--;

        if (ms <= 5)
        {
            Destroy(this.gameObject);
        }
	}
}
