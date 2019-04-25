using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BulletN : MonoBehaviour,LiveObject
{
    private int maxHp = 5;

    private int hp = 5;

    private int liveTime = 1000;
    public Vector3 Speed { get; set; }

    public bool isRun = false;

    //private List<LiveStatus> ls = new List<LiveStatus>();

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isRun)
        {
            this.transform.Translate(Speed);
        }
        liveTime--;
        if (liveTime < 0)
        {
            OnDesTory();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        MonoBehaviour mb = other.gameObject.GetComponent<MonoBehaviour>();
        if (mb is LiveObject)
        {
            LiveObject lo = (mb as LiveObject);
            LiveDamage ld = new LiveDamage();
            ld.Damage = 25;
            ld.Source = this;
            ld.Target = lo;

            lo.OnDamage(ld);
        }
        OnDesTory();
    }

    public void OnDamage(LiveDamage ld)
    {
        hp -= ld.Damage;
        if (hp <= 0)
        {
            OnDesTory();
        }
    }

    public void OnHealth(LiveHealth lh)
    {
        hp -= lh.Health;
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
        throw new NotImplementedException();
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
        //Debug.Log("Run OnDesTory");
        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    public GameObject GetGameObject()
    {
        return this.gameObject;
    }
}
