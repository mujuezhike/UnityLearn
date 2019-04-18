using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInner : MonoBehaviour {

    public GameObject expo;
    public int io =30;
    public int m = 5;
    public int m1 = 5;
    public int m2 = 5;
    // Use this for initialization
    void Start () {
        //expo.SetActive(false);
        io = 30;
        m = Random.Range(0, 10);
        m1 = Random.Range(0, 10);
        m2 = Random.Range(0, 10);
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(this.transform.position.y);
        this.transform.Rotate(Vector3.forward, Space.Self);

        
        this.transform.Translate(Vector3.forward * 0.015f * (m+5),Space.Self);
        this.transform.Translate(Vector3.left * 0.001f * (m1-5), Space.Self);
        this.transform.Translate(Vector3.up * 0.001f * (m2 - 5), Space.Self);

        if (io < 10)
        {
            if (io < -30)
            {
                io = -30;
            }
            this.transform.Translate(Vector3.up * 0.0012f * io, Space.World);

        }
        io--;

        if(this.transform.position.y <= -0.85f)
        {
            GameObject go = GameObject.Instantiate<GameObject>(expo);
            go.transform.position = this.transform.position;
            go.SetActive(true);
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        //固定步长更新
    }
    void OnEnable()
    {
        
    }
    void OnDisable()
    {
        
    }
    void LateUpdate()
    {

    }
    void Awake()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = GameObject.Instantiate<GameObject>(expo);
        go.transform.position = this.transform.position;
        go.SetActive(true);
        //GameObject go2 = GameObject.Instantiate<GameObject>(expo);
        //go2.transform.position = this.transform.position;
        //go2.SetActive(true);
        Destroy(this.gameObject);
    }

}
