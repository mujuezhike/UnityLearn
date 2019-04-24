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

        /*
        for (var i=0;i<list.Count;i++)
        {
            for (var j = 0; j < list.Count; j++)
            {

                if (i != j)
                {
                    Vector3 f = list[j].transform.position - list[i].transform.position;
                    f = Vector3.Normalize(f);

                    float lth = Vector3.Distance(list[i].transform.position, list[j].transform.position);

                    list[i].GetComponent<Rigidbody>().AddForce(f * 1000 / (lth * lth));
                }

            }

        }
        */

        //Vector3 f12de = o2.transform.position - o1.transform.position;
        //f12de = Vector3.Normalize(f12de);
        //Vector3 f21de = o1.transform.position - o2.transform.position;
        //f21de = Vector3.Normalize(f21de);

        /**
        Vector3 f13de = o3.transform.position - o1.transform.position;
        f13de = Vector3.Normalize(f13de);
        Vector3 f31de = o1.transform.position - o3.transform.position;
        f31de = Vector3.Normalize(f31de);

        Vector3 f23de = o3.transform.position - o2.transform.position;
        f23de = Vector3.Normalize(f23de);
        Vector3 f32de = o2.transform.position - o3.transform.position;
        f32de = Vector3.Normalize(f32de);
        **/

        //float ff = Vector3.Distance(o1.transform.position, o2.transform.position);

        /**
        float f13 = Vector3.Distance(o1.transform.position, o3.transform.position);
        float f23 = Vector3.Distance(o3.transform.position, o2.transform.position);

        o1.GetComponent<Rigidbody>().AddForce(f13de * 1000 / (f13 * f13));

        o2.GetComponent<Rigidbody>().AddForce(f23de * 1000 / (f23 * f23));

        o3.GetComponent<Rigidbody>().AddForce(f31de * 1000 / (f13 * f13));
        o3.GetComponent<Rigidbody>().AddForce(f32de * 1000 / (f23 * f23));
        **/

        //o1.GetComponent<Rigidbody>().AddForce(f12de * 1000 / (ff * ff));
        //o2.GetComponent<Rigidbody>().AddForce(f21de * 1000 / (ff * ff));
        
        if (Input.GetKey("w"))
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

        if (Input.GetKey("a"))
        {
            c.transform.Translate(-0.33f, 0, 0);
        }
        if (Input.GetKey("s"))
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


        if (Input.GetKey("d"))
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
            go.transform.position = c.transform.position + new Vector3(1, 0, 0);
            if (Input.GetKey("w") && !Input.GetKey("s"))
            {
                qe = Quaternion.Euler(0, 0, -45);
                qec = Quaternion.Euler(0, 0, 45);
                go.transform.Translate(0.15f,-0.15f,0);
            }
            if (Input.GetKey("s") && !Input.GetKey("w"))
            {
                qe = Quaternion.Euler(0, 0, 45);
                qec = Quaternion.Euler(0, 0, -45);
                go.transform.Translate(-0.15f, +0.15f, 0);
            }
            go.transform.rotation *= qe;
            BulletJG bn = go.GetComponent<BulletJG>();
            bn.Speed = (qec)*new Vector3(0.3f, 0, 0);
            bn.isRun = true;
            go.SetActive(true);

        }
    }
}
