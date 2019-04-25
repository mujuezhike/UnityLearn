using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroudYuZhou : MonoBehaviour {


    private int timek = 1000;
    private bool isAdd = false;
    private Material sd;
    // Use this for initialization
    void Start () {
        sd = this.gameObject.GetComponent<Renderer>().material;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(timek+"|"+ sd.color.r);
        if (timek < 100)
        {
            sd.color = new Color(sd.color.r, timek/256f, timek/256f);
        }else
        {
            sd.color = new Color(sd.color.r, 100f/256f, 100f/256f);
        }

        if(timek <= 0)
        {
            isAdd = true;
        }
        else if(timek >= 1000)
        {
            isAdd = false;
        }

        if (!isAdd)
        {
            timek--;
        }else
        {
            timek++;
        }
        

    }
}
