using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileGroup : MonoBehaviour {

    public GameObject expo;
    public int io = 30;
    public int m = 5;
    public int m1 = 5;
    public int m2 = 5;
    // Use this for initialization
    void Start()
    {
        //expo.SetActive(false);
        io = 30;
        //this.transform.Rotate(Vector3.up, Space.World);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.transform.position.y);
        //this.transform.Rotate(Vector3.forward, Space.World);
        this.transform.Translate(Vector3.forward * 0.006f * (m + 5), Space.Self);

        //if (io < 10)
        //{
        //    if (io < -30)
        //    {
        //        io = -30;
        //    }
        //    this.transform.Translate(Vector3.up * 0.0002f * io, Space.World);

        //}
        io--;

        if (this.transform.position.y <= -0.85f)
        {
            GameObject go = GameObject.Instantiate<GameObject>(expo);
            go.transform.position = this.transform.position;
            go.SetActive(true);
            GameObject go1 = GameObject.Instantiate<GameObject>(expo);
            go1.transform.position = this.transform.position;
            go1.SetActive(true);
            GameObject go2 = GameObject.Instantiate<GameObject>(expo);
            go2.transform.position = this.transform.position;
            go2.SetActive(true);
            Destroy(this.gameObject);
        }

        if (io <= -80)
        {
            GameObject go = GameObject.Instantiate<GameObject>(expo);
            go.transform.position = this.transform.position;
            go.SetActive(true);
            GameObject go1 = GameObject.Instantiate<GameObject>(expo);
            go1.transform.position = this.transform.position;
            go1.SetActive(true);
            GameObject go2 = GameObject.Instantiate<GameObject>(expo);
            go2.transform.position = this.transform.position;
            go2.SetActive(true);
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
}
