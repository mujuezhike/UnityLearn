using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script.HuiJi
{
    public class LiveDamage
    {
        public int Damage { get; set; }

        public LiveObject Source { get; set; }

        public LiveObject Target { get; set; }
    }
}
