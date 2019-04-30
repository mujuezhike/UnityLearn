using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        bool f = GUI.Button(new Rect(800, 500, 300, 150), "加载场景");
        if (f)
        {
            CallBack cl = TestCallBack;
            
            LoadScene.Instance.LoadCScene("Chang", cl);
        }
    }

    public static void TestCallBack(params object[] args)
    {
        GameObject go = GameObject.Instantiate<GameObject>(LoadScene.Instance.gom);
        go.transform.position = new Vector3(5, 5, 5);
        go.SetActive(true);
    }
}
