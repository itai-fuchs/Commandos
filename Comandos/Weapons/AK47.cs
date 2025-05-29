using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Weapons
{
    internal class AK47
    {

        public int curentNumOfBullets { get; set; }

        public int capacity { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public AK47(string name, string manufacturer, int numberOfBullets)
        {
            Name = name;
            Manufacturer = manufacturer;
            curentNumOfBullets = numberOfBullets;
            capacity = numberOfBullets;
        }
        public void Shoot()
        {
            if (curentNumOfBullets > 0)
            {
                Console.WriteLine("shooting");
                curentNumOfBullets--;
            }
            else
            {
                Console.WriteLine("NO Bullets");
            }
        }

        public void Cartridge_refill()
        {
            curentNumOfBullets = capacity;
        }


    }
}
