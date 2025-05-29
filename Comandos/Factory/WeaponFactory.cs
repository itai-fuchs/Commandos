using Commandos.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Commandos.Enum;

namespace Commandos
{
    public class WeaponFactory
    {
        private List<Enum.WeaponType> weapons;

        public WeaponFactory()
        {
            weapons = new List<Enum.WeaponType>();
        }

        public void CreateWeapon(Enum.WeaponType Weapontype)
        {


            switch (Weapontype)
            {
                case Enum.WeaponType.AK47:
                    AK47 Weapon = new();
                    break;
                case Enums.Comando.Air:
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
