using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Comandos
{
    public class WeaponFactory
    {
        private List<Weapeon> weapons;

        public WeaponFactory()
        {
            weapons = new List<Weapeon>();
        }

        public void CreateWeapon(string name, string manufacturer, int numberOfBullets)
        {
            Weapeon weapon = new Weapeon( name, manufacturer,numberOfBullets);
            weapons.Add(weapon);
        }

       
    }

}
