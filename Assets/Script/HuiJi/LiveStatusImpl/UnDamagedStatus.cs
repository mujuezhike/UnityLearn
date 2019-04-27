using Assets.Script.HuiJi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnDamagedStatus : LiveStatus {

    public LiveObject from;
    public LiveObject own;
    private List<Material> sd;
    private List<Color> oldColors;

    private const int STATUS_INT = 1;

    public int live = 12;
    private int circle = 5;
    private bool isAdd = false;

    public static UnDamagedStatus compareObject = new UnDamagedStatus();

    public LiveObject GetSource()
    {
        return from;
    }

    public int GetStatusInt()
    {
        return STATUS_INT;
    }

    public LiveObject GetTarget()
    {
        return own;
    }

    public void Show()
    {
        //Debug.Log(circle);
        if (null == sd)
        {
            sd = new List<Material>();
            oldColors = new List<Color>();

            int idm = this.own.GetGameObject().transform.childCount;
            for(int i=0; i < idm; i++)
            {
                Material ml = this.own.GetGameObject().transform.GetChild(i).GetComponent<Renderer>().material;
                if (null != ml)
                {
                    sd.Add(ml);
                    oldColors.Add(ml.color);
                    
                }
            }
               
        }

        for (var i=0; i<sd.Count;i++) { 
            if (circle < 5)
            {
                sd[i].color = new Color(1, circle / 5f, circle / 5f);
            }
            else
            {
                sd[i].color = oldColors[i];
            }
            
        }

        if (circle <= 0)
        {
            isAdd = true;
        }
        else if (circle >= 5)
        {
            isAdd = false;
        }

        if (!isAdd)
        {
            circle--;
        }
        else
        {
            circle++;
        }

        live--;
        if (live <= 0)
        {
            for (var i = 0; i < sd.Count; i++)
            {
                sd[i].color = oldColors[i];
            }
            own.GetLiveStatus().Remove(this);
        }
    }

    public override bool Equals(System.Object obj) {

        if(null!=obj && obj is UnDamagedStatus)
        {
            return true;
        }
        return false;
    }

}
