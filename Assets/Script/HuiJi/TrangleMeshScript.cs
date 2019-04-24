using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TrangleMeshScript : MonoBehaviour {


    private void Awake()
    {
        MeshFilter mf = this.GetComponent<MeshFilter>();
        MeshRenderer mr = this.GetComponent<MeshRenderer>();

        Vector3[] vertices = new Vector3[24];
        int[] triangles = new int[36];
        //a1
        vertices[0].Set(0, 0, 0);
        vertices[1].Set(0, this.transform.localScale.y, 0);
        vertices[2].Set(this.transform.localScale.x, 0, 0);
        //a2
        vertices[3].Set(0, this.transform.localScale.y, this.transform.localScale.z);
        vertices[4].Set(0, 0, this.transform.localScale.z);
        vertices[5].Set(this.transform.localScale.x, 0, this.transform.localScale.z);
        //a3
        vertices[6].Set(0, 0, this.transform.localScale.z);
        vertices[7].Set(0, 0, 0);
        vertices[8].Set(this.transform.localScale.x, 0, 0);
        //a4
        vertices[9].Set(0, 0, this.transform.localScale.z);
        vertices[10].Set(this.transform.localScale.x, 0, 0);
        vertices[11].Set(this.transform.localScale.x, 0, this.transform.localScale.z);
        //a5
        vertices[12].Set(0, 0, 0);
        vertices[13].Set(0, 0, this.transform.localScale.z);
        vertices[14].Set(0, this.transform.localScale.y, 0);
        //a6
        vertices[15].Set(0, this.transform.localScale.y, this.transform.localScale.z);
        vertices[16].Set(0, this.transform.localScale.y, 0);
        vertices[17].Set(0, 0, this.transform.localScale.z);
        //a7
        vertices[18].Set(0, this.transform.localScale.y, this.transform.localScale.z);
        vertices[19].Set(this.transform.localScale.x, 0, this.transform.localScale.z);
        vertices[20].Set(0, this.transform.localScale.y, 0);
        //a8
        vertices[21].Set(this.transform.localScale.x, 0, this.transform.localScale.z);
        vertices[22].Set(this.transform.localScale.x, 0, 0);
        vertices[23].Set(0, this.transform.localScale.y, 0);

        int currentCount = 0;
        for (int i = 0; i < 24; i++)
        {
            triangles[currentCount++] = i;
        }
        mf.mesh.vertices = vertices;
        mf.mesh.triangles = triangles;
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
