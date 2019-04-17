using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    // Use this for initialization
    public GameObject cube;

    public GameObject bullet;

    public GameObject missile;

    public int misslelate = 0;
    void Start () {

        //加载子弹
        //bullet = (GameObject)Resources.Load("Resources/Prefabs/Tank/Bullet");

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
        
        if (this.transform.rotation.y != 0
            || this.transform.rotation.z != 0
            || this.transform.position.y != 0)
        {
            //this.transform.Rotate(0, -this.transform.rotation.y, -this.transform.rotation.z);
            //this.transform.Translate(0, -this.transform.position.y, 0);
        }
        //this.transform.Rotate(new Vector3(0,1,0), 3);
        //this.transform.Rotate(new Vector3(0,0,1), 0.05f);
        //Debug.Log(Input.mousePosition.x+"|"+Input.mousePosition.y + "|" + Input.mousePosition.z);
        if (Input.GetKey("w"))
        {
            this.transform.Translate(new Vector3(0.1f,0,0));
        }
        if (Input.GetKey("a"))
        {
            this.transform.Rotate(Vector3.down, 3);
        }
        if (Input.GetKey("s"))
        {
            this.transform.Translate(new Vector3(-0.1f, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            this.transform.Rotate(Vector3.up, 3);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            this.transform./*Find("Main Camera").*/Rotate(Vector3.forward, 3);
        }
        //Zoom in
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            this.transform./*Find("Main Camera").*/ Rotate(Vector3.back, 3);
        }
        //int m = Random.Range(0, 10);

        if (Input.GetKey("space") )
        {
            GameObject go = GameObject.Instantiate<GameObject>(bullet, this.transform.Find("Tank/pao/paokou").transform.position , this.transform.Find("Tank/pao/paokou").transform.rotation);
            go.SetActive(true);
            //go.transform.position = this.transform.Find("Tank/pao/paokou").transform.position;
            //Debug.Log(this.transform.Find("Tank/pao/paokou").transform.position);
            go.transform.LookAt(this.transform.Find("Tank/pao/paodiraction"));

            //bullet.transform.
            //this.transform.Find("pao/paokou").position;
            //this.transform.position;
            
        }

        if (Input.GetKey("m") && misslelate<=0)
        {
            GameObject go = GameObject.Instantiate<GameObject>(missile, this.transform.Find("Tank/GameObject").transform.position, this.transform.Find("Tank/GameObject").transform.rotation);
            go.SetActive(true);
            //go.transform.position = this.transform.Find("Tank/pao/paokou").transform.position;
            //Debug.Log(this.transform.Find("Tank/pao/paokou").transform.position);
            go.transform.LookAt(Vector3.up);

            //bullet.transform.
            //this.transform.Find("pao/paokou").position;
            //this.transform.position;
            misslelate = 100;
        }
        misslelate--;
    }
}
