using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game a = new Game();
            Game b = new Game();
            a.CreateWeapon("m16", "colt", 29);
            b.CreateWeapon("ak46", "KALASHNIKOV", 30);

        }
    }
}
