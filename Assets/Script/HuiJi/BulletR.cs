using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.HuiJi
{
    class BulletR : MonoBehaviour, LiveObject
    {
        private int maxHp = 15;

        private int hp = 15;

        private int liveTime = 200;

        public Vector3 Speed { get; set; }

        private Vector3 OldSpeed { get; set; }

        private int speedPercent = 100;

        public GameObject target = null;

        public bool isRun = false;

        private bool hasOldSpeed = false;

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
                if (liveTime > 100)
                {
                    speedPercent = 200 - liveTime;
                    float coreSpeed = Speed.magnitude;
                    this.transform.Translate(Speed * (100- speedPercent)/100f);
                    //Speed = Vector3.Normalize(Speed);
                    Vector3 tm = Vector3.Normalize(target.transform.position - this.transform.position);
                    //tm = Vector3.Normalize(Speed + tm);
                    this.transform.Translate(tm * coreSpeed * (speedPercent/100f));
                }else
                {
                    if (hasOldSpeed)
                    {
                        this.transform.Translate(OldSpeed);
                    }else { 
                    float coreSpeed = Speed.magnitude;
                    //Speed = Vector3.Normalize(Speed);
                    Vector3 tm = Vector3.Normalize(target.transform.position - this.transform.position);
                    OldSpeed = tm * coreSpeed;

                        if (Vector3.Distance(target.transform.position, this.transform.position) < 5)
                        {
                            hasOldSpeed = true;
                        }
                    
                    //tm = Vector3.Normalize(Speed + tm);
                    this.transform.Translate(tm * coreSpeed);
                    }
                }
                //this.transform.LookAt(target.transform);


            }
            liveTime--;
            if (liveTime < -100)
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
                ld.Damage = 3;
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
}
