using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    interface IShootable
    {
        
        int curentNumOfBullets { get; set; }

        int capacity { get; set; }

        string Name { get; set; }

        string Manufacturer { get; set; }

        void Shoot();
        void Cartridge_refill();

    }
}
