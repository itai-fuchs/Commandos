using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Comandos.Enum;

namespace Comandos
{
    public class WeaponFactory
    {
        private List<Enum.WeaponType> weapons;

        public WeaponFactory()
        {
            weapons = new List<Enum.WeaponType>();
        }

        public void CreateWeapon(Enum.WeaponType Weapon)
        {


            switch (Weapon)
            {
                case Enum.WeaponType.Knife
                    Weapon = new Knife();
                    break;
                case Enum.Comando.Air:
                    comando = new AirComando(name, codename);
                    break;

                default:
                    comando = new Comando(name, codename);
                    break;

            }
            comandos.Add(comando);
        }
    }


}

}
