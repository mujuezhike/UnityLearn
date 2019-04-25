using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Move",5,0.1f);
        StartCoroutine("IeTest");
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    private void Move()
    {
        this.transform.Translate(new Vector3(-0.1f, 0, 0));
    }

    IEnumerator IeTest()
    {
        this.transform.Translate(new Vector3(0, 0.3f, 0));
        yield return new WaitForSeconds(3);
        this.transform.Translate(new Vector3(0, -0.5f, 0));
        yield return new WaitForSeconds(3);
        this.transform.Translate(new Vector3(0, 0.2f, 0));
    }
}
