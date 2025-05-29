using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Stone:IBreakable
    {

        public string name{  get; set; }
        public int weight { get; set; }
        public string color { get; set; }

        public Enum.WeaponStatus status { get; set; }

        public int curentHits {  get; set; }
        public int maxHit { get; set; }
        public Stone(string name, int weight, string color)
        {
           this.status= Enum.WeaponStatus.Intact;
            curentHits = 0;
            maxHit = 5;


        }

        public void Hit()
        {
            if (status == Enum.WeaponStatus.Broken) Console.WriteLine("cant attack the  stone is broken");
            else curentHits += 1;
            if (curentHits ==maxHit) status = Enum.WeaponStatus.Broken;
        }



    }
}
