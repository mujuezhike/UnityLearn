using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGuiTest : MonoBehaviour {

    public GUIStyle guistyle;
    private int misslelate1;
    public GameObject got;
    public Texture2D img;
    public Texture2D img2;
    // Use this for initialization
    void Start () {
        img = Resources.Load<Texture2D>("red");
        img2 = Resources.Load<Texture2D>("white");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        
        GUI.Label(new Rect(50, 50, 504, 183), new GUIContent("HelloWorld"), guistyle);
        bool rr = GUI.Button(new Rect(50, 150, 204, 100), "测试按钮");
        bool rp = GUI.RepeatButton(new Rect(50, 300, 204, 100), "炸弹");
        if (rr)
        {
            Debug.Log("按钮被按下了");
        }
        if (rp && misslelate1 <= 0)
        {
            GameObject go = Resources.Load<GameObject>("Prefabs/Game/Capsule");
            go.transform.position = new Vector3(-15, 59, 0);
            Instantiate(go);
            misslelate1 = 100;
        }
        misslelate1--;

        Vector3 vc3 = Camera.main.WorldToScreenPoint(got.transform.position);
        //Debug.Log(vc3.x + "|" + vc3.y + "|" + vc3.z);
        if (vc3.z < 40 || vc3.z > 0)
        {
            GUI.DrawTexture(new Rect(
                vc3.x-70, 
                Screen.height-vc3.y-(80-vc3.z*2)-30, 
                100 - 2.2f * vc3.z * 1f, 
                40- vc3.z * 1f),img);
            GUI.DrawTexture(new Rect(
                vc3.x - 70+(100 - 2.2f*vc3.z * 1f),
                Screen.height - vc3.y - (80 - vc3.z*2) - 30,
                100 - 2.2f *vc3.z * 1f,
                40 - vc3.z * 1f), img2);
        }
    }
}
