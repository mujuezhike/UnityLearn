using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundForce : MonoBehaviour {

    //public GameObject o;
    //public List<GameObject> list = new List<GameObject>();
    public GameObject b;
    public GameObject br;
    public GameObject bjg;
    public GameObject c;
    public GameObject ct;

    private int ie = 0;
    private int kr = 10;
    private int kjg = -1;
    private string oldDirect = "";
    private float startPosition = 1;
    private bool turnflag = false;
    public static bool dead = false;
    // Use this for initialization
    void Start () {

        //int m = 3;

        //for (int i=0;i<m;i++)
        //{
        //    //Debug.Log(i);
        //    GameObject obj = GameObject.Instantiate<GameObject>(o, new Vector3(
        //        Random.Range(-100,101)
        //        , Random.Range(-100, 101)
        //        , Random.Range(-100, 101)), new Quaternion(0, 0, 0, 0));
        //    obj.SetActive(true);
        //    list.Add(obj);
        //    /**
        //    list[i].GetComponent<Rigidbody>().AddForce(new Vector3(
        //        Random.Range(-2000, 2001)
        //        , Random.Range(-2000, 2001)
        //        , Random.Range(-2000, 2001)));
        //    **/
        //}

        //int n = 3;

        //for (int i = 0; i < n; i++)
        //{
        //    //Debug.Log(i + n - 1);
        //    GameObject obj = GameObject.Instantiate<GameObject>(o, new Vector3(
        //        Random.Range(200, 401)
        //        , Random.Range(-100, 101)
        //        , Random.Range(-100, 101)), new Quaternion(0, 0, 0, 0));
        //    obj.SetActive(true);
        //    list.Add(obj);
        //   /** list[i+n-1].GetComponent<Rigidbody>().AddForce(new Vector3(
        //        Random.Range(-2000, 2001)
        //        , Random.Range(-2000, 2001)
        //        , Random.Range(-2000, 2001)));
        //    **/
        //}
        
    }

    // Update is called once per frame
    void Update() {
        if (dead)
        {

            return;
        }

        bool isW = Input.GetKey("w");
        bool isS = Input.GetKey("s");
        bool isA = Input.GetKey("a");
        bool isD = Input.GetKey("d");
        string director = "";

        if (isW && isS)
        {
            isS = false;
        }

        if (isA && isD)
        {
            isD = false;
        }

        if (isW)
        {
            director += "w";
        }
        if (isS)
        {
            director += "s";
        }
        if (isA)
        {
            director += "a";
        }
        if (isD)
        {
            director += "d";
        }
        
        //if (isW && oldDirect=="s")
        //{
        //    isW = false;
        //    turnflag = true;
        //}

        //if (isS && oldDirect == "w")
        //{
        //    isS = false;
        //    turnflag = true;
        //}

        //=================================move==============================

        if (isW)
        {
            c.transform.Translate(0,0.33f,0, Space.World);
        }
        if (Input.GetKeyDown("w"))
        {
            c.transform.Rotate(new Vector3(60, 0, 0));
        }
        if (Input.GetKeyUp("w"))
        {
            c.transform.Rotate(new Vector3(-60, 0, 0));
        }

        if (isA)
        {
            c.transform.Translate(-0.33f, 0, 0);
        }
        if (isS)
        {
            c.transform.Translate(0, -0.33f, 0,Space.World);
        }
        if (Input.GetKeyDown("s"))
        {
            c.transform.Rotate(new Vector3(-60, 0, 0));
        }
        if (Input.GetKeyUp("s"))
        {
            c.transform.Rotate(new Vector3(60, 0, 0));
        }


        if (isD)
        {
            c.transform.Translate(0.33f, 0, 0);
        }


        if (Input.GetKey("r"))
        {
            ie = 0;
        }

        if (Input.GetKey("u") && kr<0)
        {
            GameObject go = GameObject.Instantiate<GameObject>(b);
            go.layer = 12;
            go.transform.position = c.transform.position + new Vector3(1, 0, 0);
            BulletN bn = go.GetComponent<BulletN>();
            bn.Speed = new Vector3(0.5f, 0, 0);
            bn.isRun = true;
            go.SetActive(true);
            kr = 10;

        }

        if (Input.GetKey("i") && kr < 0)
        {
            GameObject go = GameObject.Instantiate<GameObject>(br);
            go.layer = 12;
            go.transform.position = c.transform.position + new Vector3(1, 0, 0);
            BulletR bn = go.GetComponent<BulletR>();
            bn.target = ct;
            bn.Speed = new Vector3(0.4f, 0, 0);
            bn.isRun = true;
            go.SetActive(true);
            kr = 10;

        }
        kr--;

        if (Input.GetKey("o") && kjg < 0)
        {
            Quaternion qe = Quaternion.Euler(0, 0, 0);
            Quaternion qec = Quaternion.Euler(0, 0, 0);
            

            GameObject go = GameObject.Instantiate<GameObject>(bjg);
            go.layer = 12;
            go.transform.position = c.transform.position + new Vector3(1, 0, 0);
            if (director == "w")
            {
                qe = Quaternion.Euler(0, 0, -45);
                qec = Quaternion.Euler(0, 0, 45);
                go.transform.Translate(0.15f, -0.15f, 0);
            }
            if (director == "s")
            {
                qe = Quaternion.Euler(0, 0, 45);
                qec = Quaternion.Euler(0, 0, -45);
                go.transform.Translate(-0.15f, 0.15f, 0);
            }
            if (director == "wd")
            {
                qe = Quaternion.Euler(0, 0, -90);
                qec = Quaternion.Euler(0, 0, 90);
                go.transform.Translate(0.15f, -0.15f, 0);
            }
            if (director == "wa")
            {
                qe = Quaternion.Euler(0, 0, -30);
                qec = Quaternion.Euler(0, 0, 30);
                go.transform.Translate(0.15f, -0.15f, 0);
            }
            if (director == "sd")
            {
                qe = Quaternion.Euler(0, 0, 90);
                qec = Quaternion.Euler(0, 0, -90);
                go.transform.Translate(-0.15f, 0.15f, 0);
            }
            if (director == "sa")
            {
                qe = Quaternion.Euler(0, 0, 30);
                qec = Quaternion.Euler(0, 0, -30);
                go.transform.Translate(-0.15f, 0.15f, 0);
            }
            //if (isW && oldDirect != "s")
            //{
            //    go.transform.position = c.transform.position + new Vector3(0.7f, 0, 0);
            //    qe = Quaternion.Euler(0, 0, -45);
            //    qec = Quaternion.Euler(0, 0, 45);
            //    go.transform.Translate(0.15f,-0.15f,0);
            //}
            //if (isW && oldDirect == "s")
            //{
            //    qe = Quaternion.Euler(0, 0, -45);
            //    qec = Quaternion.Euler(0, 0, 45);
            //    go.transform.Translate(0.15f, -0.15f, 0);
            //}
            //if (isS && oldDirect != "w")
            //{

            //    qe = Quaternion.Euler(0, 0, 45);
            //    qec = Quaternion.Euler(0, 0, -45);
            //    go.transform.Translate(-0.15f, +0.15f, 0);
            //}
            //if (isS && oldDirect == "w")
            //{
            //    go.transform.position = c.transform.position + new Vector3(0.7f, 0, 0);
            //    qe = Quaternion.Euler(0, 0, 45);
            //    qec = Quaternion.Euler(0, 0, -45);
            //    go.transform.Translate(-0.15f, +0.15f, 0);
            //}


            //if (!isS && !isW && oldDirect == "w")
            //{
            //    go.transform.position = c.transform.position + new Vector3(0.7f, 0, 0);
            //}
            //if (!isS && !isW && oldDirect == "s")
            //{
            //    go.transform.position = c.transform.position + new Vector3(0.7f, 0, 0);
            //}
            go.transform.rotation *= qe;
            BulletJG bn = go.GetComponent<BulletJG>();
            bn.Speed = (qec)*new Vector3(0.3f, 0, 0);
            bn.isRun = true;
            go.SetActive(true);


            //fix old 
            if (isW )
            {
                oldDirect = "w";
            }
            else if (isS)
            {
                oldDirect = "s";
            }
            else if (isA)
            {
                oldDirect = "a";
            }
            else if (isD)
            {
                oldDirect = "d";
            }
            else
            {
                oldDirect = "";
            }
        }
    }
}
