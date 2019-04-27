using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKM : MonoBehaviour {

    private int fom0emk = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FomInit();
    }

    private void FomInit()
    {
        //init
        if (this.transform.position.z > 0)
        {
            this.transform.Translate(new Vector3(0, 0, -0.01f), Space.World);
            int r = UnityEngine.Random.Range(0, 20);
            if ((r == 1 || (r > 4 && fom0emk == 1)) && this.transform.position.x < 26)
            {
                this.transform.Translate(new Vector3(0.1f, 0, 0), Space.World);
                fom0emk = 1;
            }
            if ((r == 2 || (r > 4 && fom0emk == 2)) && this.transform.position.x > 6)
            {
                this.transform.Translate(new Vector3(-0.1f, 0, 0), Space.World);
                fom0emk = 2;
            }
            if ((r == 3 || (r > 4 && fom0emk == 3)) && this.transform.position.y < 8)
            {
                this.transform.Translate(new Vector3(0, 0.1f, 0), Space.World);
                fom0emk = 3;
            }
            if ((r == 4 || (r > 4 && fom0emk == 4)) && this.transform.position.y > -8)
            {
                this.transform.Translate(new Vector3(0, -0.1f, 0), Space.World);
                fom0emk = 4;
            }
        }
    }
}
