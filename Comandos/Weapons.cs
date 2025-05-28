
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Weapeon
    {
        public string Name { get; }
        public string Manufacturer { get; }
        public int NumberOfBullets { get; private set; }
        private int capasity;

        public Weapeon(string name, string manufacturer, int numberOfBullets)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBullets = numberOfBullets;
            capasity = numberOfBullets;
        }
        public void Shoot()
        {
            if (NumberOfBullets > 0)
            {
                Console.WriteLine("shooting");
                NumberOfBullets--;
            }
            else
            {
                Console.WriteLine("NO Bullets");
            }
        }

        public void Cartridge_refill()
        {
            NumberOfBullets = capasity;
        }


    }
}

