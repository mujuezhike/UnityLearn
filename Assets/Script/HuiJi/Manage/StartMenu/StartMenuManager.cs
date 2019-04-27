using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour {

    public GameObject startMenu;
    public GameObject dl;
    private float m = 0;
    private bool mf = true;
    private TextMesh tm;
    // Use this for initialization
    void Start () {
        tm = this.GetComponent<TextMesh>();
    }
	
	// Update is called once per frame
	void Update () {
        //tm.fontSize = 100 - (int)(m) % 5;
        tm.color = new Color(tm.color.r, tm.color.g, tm.color.b, m/4 );
        //transform.position = new Vector3(1.9f + m * 0.054f , transform.position.y, transform.position.z);


        if (mf) { 
            m+= 0.05f;
        }else
        {
            m -= 0.05f;
        }

        if (m >= 4)
        {
            mf = false;
        }
        if (m <= 0)
        {
            mf = true;
        }


        if (Input.GetKey("q"))
        {
            dl.SetActive(true);
            startMenu.SetActive(false);
        }
        
    }
}
