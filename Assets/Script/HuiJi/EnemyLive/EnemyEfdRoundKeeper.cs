using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyEfdRoundKeeper : MonoBehaviour, LiveObject
{
    private int maxHp = 100;

    private int hp = 100;

    public GameObject bnwd;

    private int bulletRank = 50;

    private bool fr = false;

    public void AddLiveStatus(LiveStatus ls)
    {
        throw new NotImplementedException();
    }

    public void DelLiveStatus(LiveStatus ls)
    {
        throw new NotImplementedException();
    }

    public int GetLive()
    {
        return hp;
    }

    public List<LiveStatus> GetLiveStatus()
    {
        throw new NotImplementedException();
    }

    public int GetMaxLive()
    {
        return maxHp;
    }

    public void OnDamage(LiveDamage ld)
    {
        hp -= ld.Damage;
        if (hp <= 0)
        {
            OnDesTory();
        }
    }

    public void OnDesTory()
    {
        Destroy(this.gameObject);
    }

    public void OnHealth(LiveHealth lh)
    {
        hp += lh.Health;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(-0.01f, 0, 0));

        if (bulletRank < 0)
        {
            for (int m = 0;m<9;m++)
            {
                var lk = 0;
                if (fr)
                {
                    lk = 20;
                }
                GameObject go = GameObject.Instantiate<GameObject>(bnwd);
                go.transform.position = this.transform.position + (Quaternion.Euler(0,0,40 * m+lk) * new Vector3(-1, 0, 0));
                BulletN bn = go.GetComponent<BulletN>();
                bn.Speed = (Quaternion.Euler(0, 0, 40*m + lk) * new Vector3(-0.05f, 0, 0));
                bn.isRun = true;
                go.SetActive(true);
            }
            

            bulletRank = 30;
            fr = !fr;
        }

        bulletRank--;
    }
}
