using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QinCaoS : MonoBehaviour {

    public static Dictionary<Vector3,GameObject> dic = new Dictionary<Vector3, GameObject>();
    public GameObject bygo;

    public int age = 0;

    private int dem = 0;
	// Use this for initialization
	void Start () {
        
        //变异
        int r = Random.Range(0, 100);
        if (r < 1)
        {
            //Debug.Log("by");
            GameObject go = GameObject.Instantiate<GameObject>(bygo);
            QinCaoS qcs = go.GetComponent<QinCaoS>();
            qcs.age = 0;
            dem = 1;
            go.transform.position = new Vector3(this.transform.position.x + 1, 0.5f, this.transform.position.z);
            go.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            go.SetActive(true);
            dic[new Vector3(this.transform.position.x, 0, this.transform.position.z)] = go;
            Destroy(this.gameObject);
        }else
        {
            //dic.Add(new Vector3(this.transform.position.x , 0, this.transform.position.z), this.gameObject);
            dic[new Vector3(this.transform.position.x, 0, this.transform.position.z)] = this.gameObject;
        }

    }
	
	// Update is called once per frame
	void Update () {
        
        //Debug.Log(age);
        if (age > 1000)
        {
            int r = Random.Range(0, 1000);
            if (r < 1)
            {
                Destroy(this.gameObject);
            }
        }
        //if (age < 1000)
        //{
        //    this.transform.localScale = new Vector3(age/1000f, age / 1000f, age / 1000f);
        //    this.transform.position = new Vector3(this.transform.position.x, age / 1000f, this.transform.position.z);
        //}else
        {
            this.transform.localScale = new Vector3(1, 1, 1);
            this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
        }

        int deadCount = 0;

        GameObject go = null;
        dic.TryGetValue(new Vector3(this.transform.position.x + 1, 0, this.transform.position.z + 1), out go);
        if ((null == go) && (age > 500))
        {
            int r = Random.Range(0,100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent< QinCaoS >();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x+1, 0.5f, this.transform.position.z+1);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }else if(null!=go)
        {
            deadCount ++ ;
        }

        GameObject go1 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x + 1, 0, this.transform.position.z), out go1);
        if ((null == go1) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x + 1, 0.5f, this.transform.position.z);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if(null != go)
        {
            deadCount++;
        }

        GameObject go2 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x + 1, 0, this.transform.position.z - 1), out go2);
        if ((null == go2) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x + 1, 0.5f, this.transform.position.z-1);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if (null != go)
        {
            deadCount++;
        }
        
        GameObject go3 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x, 0, this.transform.position.z + 1), out go3);
        if ((null == go3) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x, 0.5f, this.transform.position.z + 1);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if (null != go)
        {
            deadCount++;
        }

        GameObject go4 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x, 0, this.transform.position.z - 1), out go4);
        if ((null == go4) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x, 0.5f, this.transform.position.z - 1);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if (null != go)
        {
            deadCount++;
        }

        GameObject go5 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x - 1, 0, this.transform.position.z + 1), out go5);
        if ((null == go5) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x -1 , 0.5f, this.transform.position.z + 1);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if (null != go)
        {
            deadCount++;
        }

        GameObject go6 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x - 1, 0, this.transform.position.z), out go6);
        if ((null == go6) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x -1, 0.5f, this.transform.position.z);
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if (null != go)
        {
            deadCount++;
        }

        GameObject go7 = null;
        dic.TryGetValue(new Vector3(this.transform.position.x - 1, 0, this.transform.position.z - 1), out go7);
        if ((null == go7) && (age > 500))
        {
            int r = Random.Range(0, 100);
            if (r < 1)
            {
                GameObject gof = GameObject.Instantiate<GameObject>(this.gameObject);
                QinCaoS qcs = gof.GetComponent<QinCaoS>();
                qcs.age = 0;
                gof.transform.position = new Vector3(this.transform.position.x - 1, 0.5f, this.transform.position.z -1 );
                gof.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gof.SetActive(true);
            }
        }
        else if (null != go)
        {
            deadCount++;
        }
        if (deadCount > 0 && dem == 0)
        {
            int r = Random.Range(0, 5000);
            if (r < 1)
            {
                //Debug.Log("d2");
                Destroy(this.gameObject);
            }
        }
        if (deadCount > 2 && age < 500 && dem == 0)
        {
            int r = Random.Range(0, 1000);
            if (r < 1)
            {
                //Debug.Log("d2");
                Destroy(this.gameObject);
            }
        }

        if (deadCount > 4)
        {
            int r = Random.Range(0, 500);
            if (r < 1)
            {
                //Debug.Log("d2");
                Destroy(this.gameObject);
            }
        }

        if (deadCount > 6 && age < 500 && dem == 0)
        {
            int r = Random.Range(0, 200);
            if (r < 1)
            {
                //Debug.Log("d3");
                Destroy(this.gameObject);
            }
        }

        age++;
    }

    private void OnDestroy()
    {
        dic.Remove(new Vector3(this.transform.position.x, 0, this.transform.position.z));
    }
}
