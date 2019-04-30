using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCube : MonoBehaviour {

    public GameObject line;
    private int wi = 0;
    // Use this for initialization
    private LinkedList<Vector3> vlist = new LinkedList<Vector3>();

    void Start () {
        LineRenderer lr = this.gameObject.GetComponent<LineRenderer>();
        lr.positionCount = 2;
        lr.SetPosition(0, new Vector3(0, 0, 1));
        lr.SetPosition(1, new Vector3(0, 1, 1));
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;
    }
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetMouseButtonDown(0) || wi%10==0)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10));
            vlist.AddLast(pos);
            if (vlist.Count > 100)
            {
                vlist.RemoveFirst();
            }
        }

        LineRenderer lr = this.gameObject.GetComponent<LineRenderer>();
        lr.positionCount = vlist.Count;
        int i = 0;
        foreach (Vector3 v3 in vlist)
        {
            lr.SetPosition(i, v3);
            i++;
        }
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;
    }
}
