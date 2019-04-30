using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugS : MonoBehaviour {

    public int age = 0;
    private int timeCurt = 0;
    private int eat = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //if (age < 1000)
        //{
        //    this.transform.localScale = new Vector3(age / 1000f, age / 1000f, age / 1000f);
        //    this.transform.position = new Vector3(this.transform.position.x, age / 1000f, this.transform.position.z);
        //}
        //else
        {
            this.transform.localScale = new Vector3(1, 1, 1);
            this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
        }

        if(timeCurt>2000 && timeCurt % 10 == 0)
        {
            bool f = false;

            GameObject go1 = null;
            QinCaoS.dic.TryGetValue(new Vector3(this.transform.position.x+1, 0, this.transform.position.z), out go1);
            GameObject go2 = null;
            QinCaoS.dic.TryGetValue(new Vector3(this.transform.position.x, 0, this.transform.position.z+1), out go2);
            GameObject go3 = null;
            QinCaoS.dic.TryGetValue(new Vector3(this.transform.position.x - 1, 0, this.transform.position.z), out go3);
            GameObject go4 = null;
            QinCaoS.dic.TryGetValue(new Vector3(this.transform.position.x, 0, this.transform.position.z-1), out go4);

            if(go1!=null || go2!=null || go3 != null || go4 != null)
            {
                f = true;
            }

            if (f)
            {
                if (go1 != null)
                {
                    this.transform.position = new Vector3(this.transform.position.x + 1, 1, this.transform.position.z);
                }
                else if (go2 != null)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z + 1);
                }
                else if (go3 != null)
                {
                    this.transform.position = new Vector3(this.transform.position.x - 1, 1, this.transform.position.z);
                }
                else if (go4 != null)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z - 1);
                }
                GameObject go = null;
                QinCaoS.dic.TryGetValue(new Vector3(this.transform.position.x, 0, this.transform.position.z), out go);
                if (null != go)
                {
                    QinCaoS.dic.Remove(new Vector3(this.transform.position.x, 0, this.transform.position.z));
                    Destroy(go);
                    eat++;
                }
            }
            else
            {
                int i = Random.Range(0, 4);
                if (i == 0)
                {
                    this.transform.position = new Vector3(this.transform.position.x + 1, 1, this.transform.position.z);
                }
                if (i == 1)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z + 1);
                }
                if (i == 2)
                {
                    this.transform.position = new Vector3(this.transform.position.x - 1, 1, this.transform.position.z);
                }
                if (i == 3)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z - 1);
                }
                
            }
        }

        timeCurt++;
        age++;
    }
}
