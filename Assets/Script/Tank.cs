using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    // Use this for initialization
    public GameObject cube;
	void Start () {
        int m = 10;
        while( m > 0)
        { 
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    GameObject go = GameObject.Instantiate<GameObject>(cube);
                    go.transform.position = new Vector3(5+ 1.1f * (j + 1)+(10-m)*0.55f, (10-m)*1.1f , 1.1f * (i + 1) + (10 - m) * 0.55f);
                }
            }
            m--;
        }

    }
	
	// Update is called once per frame
	void Update () {
        //this.transform.Rotate(new Vector3(0,1,0), 3);
        this.transform.Rotate(new Vector3(0,0,1), 0.05f);
        //Debug.Log(Input.mousePosition.x+"|"+Input.mousePosition.y + "|" + Input.mousePosition.z);
    }
}
