using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceR8 : MonoBehaviour {

    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    private int misslelate1 = 0;
    private int misslelate2 = 0;
    private int misslelate3 = 0;
    private int misslelate4 = 0;
    public GameObject cube;
    // Use this for initialization
    void Start () {

        int m = 20;
        while (m > 0)
        {
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    GameObject go = GameObject.Instantiate<GameObject>(cube);
                    go.transform.position = new Vector3(-35 + 1.1f * (j + 1) + (20 - m) * 0.55f, (20 - m) * 1.1f, 1.1f * (i + 1) + (20 - m) * 0.55f);
                }
            }
            m--;
        }

        int blood = Mathf.Clamp(10, 0, 100);
        float bf = Mathf.Clamp(3.8f,0,100);
        float blood1 = Mathf.Clamp01(3.3f);

        float e3em = Mathf.Lerp(0, 10, 0.3f);
        Debug.Log("x1:" + blood + "|x2:"+bf+"|x3:"+blood1+"|x4:" +e3em);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("r") && misslelate1 <= 0)
        {
            GameObject go = Resources.Load<GameObject>("Prefabs/Game/Capsule");
            int m = Random.Range(1, 10);
            int n = Random.Range(1, 10);
            go.transform.position = new Vector3(-23+m,109,7+n);

            Instantiate(go);
            misslelate1 = 3;
        }
        misslelate1--;

        if (Input.GetKey("y") && misslelate1 <= 0)
        {
            GameObject go = Resources.Load<GameObject>("Prefabs/Game/Capsule");
            int m = Random.Range(1, 10);
            int n = Random.Range(1, 10);
            go.transform.position = new Vector3(10+m, 39, 8+ n);

            Instantiate(go);
            misslelate1 = 5;
        }

        if (Input.GetKey("t") && misslelate2 <= 0)
        {
            GameObject go = Resources.Load<GameObject>("Prefabs/Game/Capsule");
            go.transform.position = new Vector3(-15, 49, 13);
            Instantiate(go);
            misslelate2 = 100;
        }
        misslelate2--;
        if (Input.GetKey("f") && misslelate3 <= 0)
        {
            GameObject go = Resources.Load<GameObject>("Prefabs/Game/Capsule");
            go.transform.position = new Vector3(-15, 39, 13);
            Instantiate(go);
            misslelate3 = 100;
        }
        misslelate3--;
        if (Input.GetKey("g") && misslelate4 <= 0)
        {
            GameObject go = Resources.Load<GameObject>("Prefabs/Game/Capsule");
            go.transform.position = new Vector3(-15, 29, 13);
            Instantiate(go);
            misslelate4 = 100;
        }
        misslelate4--;

    }
}
