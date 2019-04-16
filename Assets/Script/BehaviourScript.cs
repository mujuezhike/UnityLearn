using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourScript : MonoBehaviour {

    public List<GameObject> kdsll;
	// Use this for initialization
	void Start () {
        this.transform.SetParent(kdsll[0].transform);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
