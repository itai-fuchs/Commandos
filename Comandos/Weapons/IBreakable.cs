using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    interface IBreakable
    {

        Enum.WeaponStatus status { get; set; }
        int curentHits { get; set; }

        int maxHit { get; set; }

        void Hit();
    }
}
