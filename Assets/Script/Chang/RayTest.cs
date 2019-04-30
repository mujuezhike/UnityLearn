using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {

    public GameObject camera;
    public Camera c;
    public GameObject b1;
    public GameObject b2;
    // Use this for initialization
    void Start () {
         c = camera.GetComponent<Camera>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(1);
            Ray ray = c.ScreenPointToRay(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.name.Equals("Di"))
                {
                    GameObject go = GameObject.Instantiate<GameObject>(b2);
                    go.transform.position = hitInfo.point;
                    go.transform.localScale = new Vector3(10, 10, 10);
                    Quaternion.LookRotation(-hitInfo.normal);
                }
                if (hitInfo.transform.name.Equals("Qiang"))
                {
                    GameObject go = GameObject.Instantiate<GameObject>(b1);
                    go.transform.position = hitInfo.point;
                    go.transform.localScale = new Vector3(10, 10, 10);
                    Quaternion.LookRotation(-hitInfo.normal);
                }
            }
        }
        //ScreenPointToRay

    }
}
