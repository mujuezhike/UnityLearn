using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour {

    public GameObject gos;
    public GameObject gos2;
    public GameObject gos3;
    public GameObject fj;
    private int i = 270;
    private Vector3 v3= new Vector3(0,0,0);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (i > 180)
        {
            //gos2.transform.localRotation
            gos2.transform.Rotate(new Vector3(1, 0, 0), Space.World);
            this.transform.Rotate(new Vector3(1, 0, 0));
            //gos.transform.localRotation *= Quaternion.Euler(new Vector3(1, 0, 0));
        }

        if (i > 90 && i<= 180)
        {
            gos2.transform.Rotate(new Vector3(0, 1, 0), Space.World);
            this.transform.Rotate(new Vector3(0, 1, 0));
            //gos.transform.localRotation *= Quaternion.Euler(new Vector3(0, 1, 0));
        }

        if (i <= 90 && i > 0)
        {
            gos2.transform.Rotate(new Vector3(0, 0, 1), Space.World);
            this.transform.Rotate(new Vector3(0, 0, 1));
            //gos.transform.localRotation *= Quaternion.Euler(new Vector3(0, 0, 1));
        }

        Quaternion qn1 = Quaternion.Euler(new Vector3(89, 20, 20));
        gos3.transform.rotation = qn1;

    }
}
