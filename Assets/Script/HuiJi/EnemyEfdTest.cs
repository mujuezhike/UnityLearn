using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEfdTest : MonoBehaviour {

    public GameObject br;
    public GameObject ct;
    public bool IsUp { set; get; }

    private int bulletRank = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (IsUp)
        {
            this.transform.Translate(new Vector3(0, 0.3f, 0));
            if(this.transform.position.y > 15)
            {
                IsUp = false;
            }
        }else
        {
            this.transform.Translate(new Vector3(0, -0.1f, 0));
            if (this.transform.position.y < -15)
            {
                IsUp = true;
            }
        }

        if (bulletRank < 0)
        {
            GameObject go = GameObject.Instantiate<GameObject>(br);
            go.transform.position = this.transform.position+new Vector3(-1,0,0);
            BulletR bn = go.GetComponent<BulletR>();
            bn.target = ct;
            bn.Speed = new Vector3(-0.4f, 0, 0);
            bn.isRun = true;
            go.SetActive(true);
            
            bulletRank = Random.Range(10, 200); ;
        }

        bulletRank--;

    }
}
