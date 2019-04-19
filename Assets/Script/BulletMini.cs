using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMini : MonoBehaviour {

    public GameObject expo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        JinZiTaBlocks jb = collision.gameObject.GetComponent<JinZiTaBlocks>();
        if (null != jb)
        {
            jb.hp--;
        }
        GameObject go = GameObject.Instantiate<GameObject>(expo);
        go.transform.position = this.transform.position;
        go.SetActive(true);
        //GameObject go2 = GameObject.Instantiate<GameObject>(expo);
        //go2.transform.position = this.transform.position;
        //go2.SetActive(true);
        this.gameObject.SetActive(false);
        Destroy(this.gameObject,1);
    }
}
