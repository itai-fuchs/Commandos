using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Commandos
{
    internal class Enum
    {

        public enum Tool
        {
            Hammer,
            Chisel,
            Rope,
            Bag,
            WaterBottle
        }
        public enum WeaponStatus
        {
            Intact,
            Broken,
        }
        public enum PeopleStatus
        {
            standing,
            walking,
            hiding,
        }

        public enum Comando
        {
            Air,
            Sea,
            Land,
        }
        public enum WeaponType
        {
            Gun,
            Knife,
            Stone,
            M16,
            AK47,

        }


        public enum SoliderRank
        {
            General,
            Colonel,
            
        }
    }
}
