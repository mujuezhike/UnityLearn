using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileGroup : MonoBehaviour {

    public GameObject expo;
    public int io = 1000;
    public int m = 5;
    public int m1 = 5;
    public int m2 = 5;
    // Use this for initialization
    void Start()
    {
        //expo.SetActive(false);
        io = 1000;
        //this.transform.Rotate(Vector3.up, Space.World);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.transform.position.y);
        //this.transform.Rotate(Vector3.forward, Space.World);

        int i = Random.Range(0, 300);
        if (i == 0)
        {
            this.transform.Rotate(new Vector3(30, 0, 0));
        }
        if (i == 1)
        {
            this.transform.Rotate(new Vector3(0, 30, 0));
        }
        if (i == 2)
        {
            this.transform.Rotate(new Vector3(0, 0, 30));
        }
        if (i == 3)
        {
            this.transform.Rotate(new Vector3(-30, 0, 0));
        }
        if (i == 4)
        {
            this.transform.Rotate(new Vector3(0, -30, 0));
        }
        if (i == 5)
        {
            this.transform.Rotate(new Vector3(0, 0, -30));
        }

        this.transform.Translate(Vector3.up * 0.003f * (m + 5), Space.Self);
        
        io--;

        if (io <= 0)
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
}
