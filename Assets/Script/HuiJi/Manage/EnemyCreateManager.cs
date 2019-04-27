using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreateManager : MonoBehaviour
{

    public GameObject scifi0;
    public GameObject mk;

    private int ttTime = 0;
    private int ttMode = 0;
    private int createScifi0Time;
    private int defaultCreateScifi0Time = 300;
    // Use this for initialization
    void Start()
    {
        createScifi0Time = defaultCreateScifi0Time;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeMode();

        if ( ttMode == 10 )
        {
            for(int i = 0; i < 10; i++)
            {
                GameObject go = GameObject.Instantiate<GameObject>(scifi0);
                EnemyDroneSciFi0 efr = go.GetComponent<EnemyDroneSciFi0>();
                efr.btype = 2;
                
                float x = mk.transform.position.x;
                float y = mk.transform.position.y;
                float z = mk.transform.position.z;
                go.transform.position = new Vector3(x, y, z);

                go.SetActive(true);
            }
        }

        if (ttMode == 11)
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject go = GameObject.Instantiate<GameObject>(scifi0);
                EnemyDroneSciFi0 efr = go.GetComponent<EnemyDroneSciFi0>();
                efr.btype = 0;
                //改红色
                int idm = go.transform.childCount;
                for (int j = 0; j < idm; j++)
                {
                    Material ml = go.transform.GetChild(j).GetComponent<Renderer>().material;
                    ml.color = new Color(0.5f, 0.2f, 0.1f);
                }
                float x = mk.transform.position.x;
                float y = mk.transform.position.y;
                float z = mk.transform.position.z;
                go.transform.position = new Vector3(x, y, z);

                go.SetActive(true);
            }
        }


        int type = Random.Range(0, 100);
        //Debug.Log(createScifi0Time);
        if (createScifi0Time < 0)
        {
            GameObject go = GameObject.Instantiate<GameObject>(scifi0);
            if (type < 8)
            {
                EnemyDroneSciFi0 efr = go.GetComponent<EnemyDroneSciFi0>();
                efr.btype = 1;
                //改金色
                int idm = go.transform.childCount;
                for (int i = 0; i < idm; i++)
                {
                    Material ml = go.transform.GetChild(i).GetComponent<Renderer>().material;
                    ml.color = new Color(0.5f, 0.5f, 0.1f);
                }
            }
            else if (type < 40)
            {
                EnemyDroneSciFi0 efr = go.GetComponent<EnemyDroneSciFi0>();
                efr.btype = 0;
                //改红色
                int idm = go.transform.childCount;
                for (int i = 0; i < idm; i++)
                {
                    Material ml = go.transform.GetChild(i).GetComponent<Renderer>().material;
                    ml.color = new Color(0.5f, 0.2f, 0.1f);
                }

            }
            else
            {
                EnemyDroneSciFi0 efr = go.GetComponent<EnemyDroneSciFi0>();
                efr.btype = 2;
            }
            float x = mk.transform.position.x;
            float y = mk.transform.position.y;
            float z = mk.transform.position.z;
            go.transform.position = new Vector3(x, y, z);

            go.SetActive(true);
            createScifi0Time = defaultCreateScifi0Time;

        }
        createScifi0Time--;
        ttTime++;
    }

    void ChangeMode()
    {
        if (ttTime> 1000 && ttMode==0)
        {
            ttMode = 1;
            defaultCreateScifi0Time = 200;
        }

        if (ttTime >= 2000 && ttMode == 1)
        {
            ttMode = 2;
            defaultCreateScifi0Time = 100;
        }

        if (ttTime == 3000)
        {
            ttMode = 10;
            defaultCreateScifi0Time = 50;
        }

        if (ttTime == 6000)
        {
            ttMode = 10;
            defaultCreateScifi0Time = 50;
        }

        if (ttTime == 7000)
        {
            ttMode = 11;
            defaultCreateScifi0Time = 50;
        }

        if (ttTime == 8000)
        {
            ttMode = 10;
            defaultCreateScifi0Time = 50;
        }

        if (ttTime == 9000)
        {
            ttMode = 10;
            defaultCreateScifi0Time = 50;
        }

        if (ttTime == 9500)
        {
            ttMode = 10;
            defaultCreateScifi0Time = 50;
        }

        if (ttTime > 3000)
        {
            ttMode = 2;
            defaultCreateScifi0Time = 50;
        }
    }
}
