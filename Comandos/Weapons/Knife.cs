using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Knife:IBreakable
    {

        public string name { get; set; }
        public int weight { get; set; }
        public string color { get; set; }

        public Enum.WeaponStatus status { get; set; }
        

        public int curentHits { get; set; }
        public int maxHit { get; set; }
 

        public string stillKind { get; set; }

        public string manufacturer { get; set; }
        
       

        public Knife(string name, string stillKind, string manufacturer, string color, int weight) {
        this.name = name;
        this.stillKind = stillKind;
        this.manufacturer = manufacturer;
        this.color = color;
        this.weight = weight;
        this.status=Enum.WeaponStatus.Intact;
       


        }

        public void Hit()
        {
            if (status ==Enum.WeaponStatus.Broken) Console.WriteLine("cant attack the  knife is broken");
            else curentHits += 1;
            if (curentHits == maxHit) status =Enum.WeaponStatus.Broken;
        }






    }
}
