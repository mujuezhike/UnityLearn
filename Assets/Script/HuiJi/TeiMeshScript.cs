using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TeiMeshScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MeshFilter mf = this.GetComponent<MeshFilter>();
        //MeshRenderer mr = this.GetComponent<MeshRenderer>();

        Vector3[] vertices = new Vector3[36];
        int[] triangles = new int[36];
        //a1
        vertices[0].Set(2, 0, 0);
        vertices[1].Set(0, 0, 0);
        vertices[2].Set(0, 2, 0);

        vertices[3].Set(1, 1, 1);
        vertices[4].Set(2, 0, 0);
        vertices[5].Set(0, 2, 0);

        vertices[6].Set(1, 1, 1);
        vertices[7].Set(0, 2, 2);
        vertices[8].Set(2, 0, 2);

        vertices[9].Set(0, 0, 2);
        vertices[10].Set(2, 0, 2);
        vertices[11].Set(0, 2, 2);

        //==================================

        vertices[12].Set(0, 0, 0);
        vertices[13].Set(2, 0, 0);
        vertices[14].Set(0, 2, 0);

        vertices[15].Set(1, 1, 1);
        vertices[16].Set(0, 2, 0);
        vertices[17].Set(2, 0, 0);

        vertices[18].Set(1, 1, 1);
        vertices[19].Set(2, 0, 2);
        vertices[20].Set(0, 2, 2);

        vertices[21].Set(0, 0, 2);
        vertices[22].Set(0, 2, 2);
        vertices[23].Set(2, 0, 2);

        //=========================================

        vertices[24].Set(0, 2, 0);
        vertices[25].Set(0, 0, 0);
        vertices[26].Set(1, 1, 1);

        vertices[27].Set(0, 2, 2);
        vertices[28].Set(0, 0, 2);
        vertices[29].Set(1, 1, 1);

        vertices[30].Set(0, 0, 0);
        vertices[31].Set(0, 2, 0);
        vertices[32].Set(1, 1, 1);

        vertices[33].Set(0, 0, 2);
        vertices[34].Set(0, 2, 2);
        vertices[35].Set(1, 1, 1);

        int currentCount = 0;
        for (int i = 0; i < triangles.Length; i++)
        {
            triangles[currentCount++] = i;
        }
        mf.mesh.vertices = vertices;
        mf.mesh.triangles = triangles;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
