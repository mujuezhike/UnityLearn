using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceTest : MonoBehaviour {

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    // Use this for initialization
    void Start () {
        Rigidbody r1 = c1.GetComponent<Rigidbody>();
        r1.AddForce(new Vector3(5,0,0),ForceMode.Acceleration);
        Rigidbody r2 = c2.GetComponent<Rigidbody>();
        r2.AddForce(new Vector3(5, 0, 0), ForceMode.Force);
        Rigidbody r3 = c3.GetComponent<Rigidbody>();
        r3.AddForce(new Vector3(5, 0, 0), ForceMode.Impulse);
        Rigidbody r4 = c4.GetComponent<Rigidbody>();
        //r4.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);

        //扭距
        r1.AddTorque(new Vector3(1,0,0));
        //作用于点
        r2.AddForceAtPosition(new Vector3(5, 0, 0), new Vector3(0.1f, 0.1f, 0), ForceMode.Force);
        //本地坐标系力
        r3.AddRelativeForce(new Vector3(0, 0, 1), ForceMode.Impulse);
        //爆炸力  随机大小
        r4.AddExplosionForce(50, new Vector3(0, 1, 7), 5,3, ForceMode.Force);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
