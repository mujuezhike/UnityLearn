using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneV5 : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        bool f = GUI.Button(new Rect(800,500,300,150),"加载场景");
        if (f)
        {
            CallBack cl = TestCallBack;
            LoadScene.Instance.LoadCScene("Chang",cl,32,34,"DHEE");
        }
    }

    public static void TestCallBack(params object[] args) {
        foreach(object o in args)
        {
            Debug.Log(o.ToString());
        }
    }
}
