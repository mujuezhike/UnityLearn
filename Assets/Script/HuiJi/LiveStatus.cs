using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script.HuiJi
{
    public interface LiveStatus
    {
        int GetStatusInt();
        LiveObject GetSource();
        LiveObject GetTarget();
        void Show();
    }
}
