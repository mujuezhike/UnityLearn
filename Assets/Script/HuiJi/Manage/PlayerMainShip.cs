using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMainShip : MonoBehaviour, LiveObject
{
    public int maxHp = 30;

    public int hp = 30;

    public List<LiveStatus> statusList = new List<LiveStatus>();

    void Start()
    {

    }

    void Update()
    {
        for (int i=0; i<statusList.Count;i++)
        {
            statusList[i].Show();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    public void OnDamage(LiveDamage ld)
    {
        //Debug.Log(hp);
        if(!statusList.Contains(UnDamagedStatus.compareObject))
        {
            hp -= ld.Damage;
            UnDamagedStatus ls = new UnDamagedStatus();
            ls.from = ld.Source;
            ls.own = ld.Target;
            statusList.Add(ls as LiveStatus);
        }

        //Debug.Log(hp);
        
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
        RoundForce.dead = true;
        //this.gameObject.SetActive(false);
        //Destroy();

    }

    public GameObject GetGameObject()
    {
        return this.gameObject;
    }
}
