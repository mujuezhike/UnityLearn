using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmMoon3 : MonoBehaviour {

    public GameObject CubeAxis;

    public int o;

    public Vector3 v3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int i = Random.Range(0, 100);
        Vector3 def = new Vector3(1, 1, 1);
        def = v3;
        
        this.transform.RotateAround(CubeAxis.gameObject.transform.position, def, o);
        this.transform.LookAt(CubeAxis.gameObject.transform);
        if (i < 5) { 
            this.transform.localScale += new Vector3(i*0.01f,i * 0.01f,i * 0.01f);
        }else if( i<10)
        {
            this.transform.localScale += new Vector3(-1*(i-5) * 0.01f, -1 * (i - 5) * 0.01f, -1 * (i - 5) * 0.01f);
        }else if(i == 90)
        {
            //this.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
        }
    }
}
