using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.HuiJi
{
    public interface LiveObject
    {
        GameObject GetGameObject();
        void OnDamage(LiveDamage ld);

        void OnHealth(LiveHealth lh);

        void AddLiveStatus(LiveStatus ls);

        void DelLiveStatus(LiveStatus ls);

        List<LiveStatus> GetLiveStatus();

        int GetLive();

        int GetMaxLive();

        void OnDesTory();
    }
}
