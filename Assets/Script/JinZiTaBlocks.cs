using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinZiTaBlocks : MonoBehaviour {

    public GameObject expo;

    public int hp = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
        //Debug.Log("E"+ collision.gameObject.name);
        //if (collision.gameObject.name.Equals("Bullet") || collision.gameObject.name.Equals("BulletGroup"))
        //{
        //    hp--;
        //    //Debug.Log(hp);
        //}
        //if (collision.gameObject.name.Equals("Capsule"))
        //{
        //    hp-=3;
        //}
        if (hp <= 0)
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
}
