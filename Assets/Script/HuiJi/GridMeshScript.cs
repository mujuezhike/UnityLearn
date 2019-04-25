using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class GridMeshScript : MonoBehaviour {

    private Vector3[] vertices;

    public Material mat;

    private void Awake()
    {
        MeshFilter mf = this.GetComponent<MeshFilter>();
       // MeshRenderer mr = this.GetComponent<MeshRenderer>();

        Vector3[] vertices = new Vector3[24];
        int[] triangles = new int[36];
        //a1
        vertices[0].Set(0, 0, 0);
        vertices[1].Set(0, this.transform.localScale.y, 0);
        vertices[2].Set(this.transform.localScale.x, 0, 0);
        //a2
        vertices[3].Set(0, 0, 0);
        vertices[4].Set(this.transform.localScale.x, 0, 0);
        vertices[5].Set(0, 0, this.transform.localScale.z);
        //a3
        vertices[6].Set(0, 0, 0);
        vertices[7].Set(0, 0, this.transform.localScale.z);
        vertices[8].Set(0, this.transform.localScale.y, 0);
        //a4
        vertices[9].Set(this.transform.localScale.x, 0, 0);
        vertices[10].Set(0, this.transform.localScale.y, 0);
        vertices[11].Set(0, 0, this.transform.localScale.z);

        int currentCount = 0;
        for (int i = 0; i < 12; i = i + 3)
        {
            triangles[currentCount++] = i;
            triangles[currentCount++] = i + 1;
            triangles[currentCount++] = i + 2;
        }
        mf.mesh.vertices = vertices;
        mf.mesh.triangles = triangles;
    }

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update () {
       
    }

    private void OnPostRender()
    {

    }
}
