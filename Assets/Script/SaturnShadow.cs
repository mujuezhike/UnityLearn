using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnShadow : MonoBehaviour {

    public GameObject saturn;
    public GameObject saturnw1;
    public Transform trem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0, 1f, 0), 0.2f);
        this.transform.Rotate(new Vector3(0, 0, 1f), 0.6f);

        this.transform.Translate(Vector3.forward,Space.World);          //世界的Z轴
        this.transform.Translate(Vector3.forward,Space.Self);           //自身的Z轴 正前方
        this.transform.Translate(this.transform.forward, Space.World);  //自身的Z轴 正前方
        this.transform.Translate(this.transform.forward, Space.Self);   //无法判断移动规律
    }
}
