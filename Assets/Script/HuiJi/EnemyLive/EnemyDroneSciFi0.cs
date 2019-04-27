using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyDroneSciFi0 : MonoBehaviour, LiveObject
{
    private int maxHp = 100;

    private int hp = 100;

    public List<LiveStatus> statusList = new List<LiveStatus>();

    public GameObject bnwd;

    public GameObject br;

    public GameObject ct;

    public GameObject camera;

    private int fomStatus = 0;

    private int fom0emk = 0;
    private int fom1emk = 0;

    private int bulletRank = 50;

    private int liveTime = 1000;
    
    private bool fr = false;

    public int btype = 0;
    // Use this for initialization
    void Start () {
        camera = GameObject.Find("BackCamera");
        ct = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {

        if(fomStatus == 0) {
            FomInit();
            return;
        }

        if (fomStatus == 1)
        {
            TurnInit();
            return;
        }

        if (this.transform.position.x <= -16)
        {
            OnDesTory();
            return;
        }

            for (int i = 0; i < statusList.Count; i++)
        {
            statusList[i].Show();
        }

        if(btype == 1) { 
            this.transform.Translate(new Vector3(-0.03f, 0, 0),Space.World);
        }
        if (btype == 0)
        {
            this.transform.Translate(new Vector3(-0.3f, 0, 0), Space.World);
        }
        if (btype == 2)
        {
            this.transform.Translate(new Vector3(-0.2f, 0, 0), Space.World);
        }


        if (bulletRank < 0 && btype == 1)
        {
            for (int m = 0; m < 9; m++)
            {
                var lk = 0;
                if (fr)
                {
                    lk = 20;
                }
                GameObject go = GameObject.Instantiate<GameObject>(bnwd);
                go.transform.position = this.transform.position + (Quaternion.Euler(0, 0, 40 * m + lk) * new Vector3(-1.3f, 0, 0));
                BulletN bn = go.GetComponent<BulletN>();
                bn.Speed = (Quaternion.Euler(0, 0, 40 * m + lk) * new Vector3(-0.05f, 0, 0));
                bn.isRun = true;
                go.SetActive(true);
            }


            bulletRank = 30;
            fr = !fr;
        }

        if (bulletRank < 0 && btype == 2)
        {
            GameObject go = GameObject.Instantiate<GameObject>(bnwd);
            go.transform.position = this.transform.position + (new Vector3(-1.3f, 0, 0));
            BulletN bn = go.GetComponent<BulletN>();
            bn.Speed = (new Vector3(-0.4f, 0, 0));
            bn.isRun = true;
            go.SetActive(true);
            bulletRank = 30;
        }

        if (bulletRank < 0 && btype == 0)
        {
            GameObject go = GameObject.Instantiate<GameObject>(br);
            go.transform.position = this.transform.position + new Vector3(-1, 0, 0);
            BulletR bn = go.GetComponent<BulletR>();
            bn.target = ct;
            bn.Speed = new Vector3(-0.4f, 0, 0);
            bn.isRun = true;
            go.SetActive(true);

            bulletRank = UnityEngine.Random.Range(10, 200); ;
        }

        //bulletRank--;

        bulletRank--;

        liveTime--;
        if (liveTime < 0)
        {
            OnDesTory();
        }

    }

    private void FomInit()
    {
        //init
        if (this.transform.position.z > 0)
        {
            //int x = Random.Range(0, 10);
            //int y = Random.Range(-8, 6);

            int r = UnityEngine.Random.Range(0, 10);

            if (r>2) { 
                this.transform.Translate(new Vector3(0, 0, -0.2f), Space.World);
            }

            if ((r == 1 ||(r>5 && fom0emk == 1)) && this.transform.position.x < 24)
            {
                this.transform.Translate(new Vector3(0.1f, 0, 0), Space.World);
                fom0emk = 1;
            }
            if ((r == 2 ||(r>5 && fom0emk == 2)) && this.transform.position.x > 10)
            {
                this.transform.Translate(new Vector3(-0.1f, 0, 0), Space.World);
                fom0emk = 2;
            }
            if ((r == 3 || (r > 5 && fom0emk == 3)) && this.transform.position.y < 5)
            {
                this.transform.Translate(new Vector3(0, 0.1f, 0), Space.World);
                fom0emk = 3;
            }
            if ((r == 4 || (r > 5 && fom0emk == 4)) && this.transform.position.y > -7)
            {
                this.transform.Translate(new Vector3(0, -0.1f, 0), Space.World);
                fom0emk = 4;
            }
            this.transform.LookAt(camera.transform);
        }

        //if (this.transform.position.z < 7 && this.transform.position.z > 0)
        //{
        //    this.transform.rotation *= Quaternion.Euler(-0.75f, 0.75f, 0);
        //}

        if (this.transform.position.z <= 0 && fomStatus == 0)
        {
            this.transform.rotation = Quaternion.Euler(0,0,0);
            fomStatus = 1;
            this.gameObject.layer = 0;
        }
    }

    public void TurnInit()
    {
        if(fom1emk>=9)
        {
            fomStatus = 2;
            this.transform.rotation = Quaternion.Euler(0, 90, 0);
            return;
        }
        this.transform.rotation *= Quaternion.Euler(0, 10, 0);
        fom1emk++;


    }

    public GameObject GetGameObject()
    {
        return this.gameObject;
    }

    public void OnDamage(LiveDamage ld)
    {
        if (!statusList.Contains(OnDamagedStatus.compareObject))
        {
            OnDamagedStatus ls = new OnDamagedStatus();
            ls.from = ld.Source;
            ls.own = ld.Target;
            statusList.Add(ls as LiveStatus);
        }
        hp -= ld.Damage;
        if (hp <= 0)
        {
            OnDesTory();
        }
    }

    public void OnHealth(LiveHealth lh)
    {
        hp += lh.Health;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }

    public void AddLiveStatus(LiveStatus ls)
    {
        throw new NotImplementedException();
    }

    public void DelLiveStatus(LiveStatus ls)
    {
        throw new NotImplementedException();
    }

    public List<LiveStatus> GetLiveStatus()
    {
        return statusList;
    }

    public int GetLive()
    {
        return hp;
    }

    public int GetMaxLive()
    {
        return maxHp;
    }

    public void OnDesTory()
    {
        Destroy(this.gameObject);
    }
}
