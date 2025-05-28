using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class AirComando: Comando
    {
        public AirComando(string name, string Codename) : base(name, Codename) { }

        public void Parachuting()
        {
            Console.WriteLine("The soldier performs a parachute jump");
        }


        public override void Attack()
        {
            Console.WriteLine($"The AirCommando {CodeName} is attacking");

        }

    }


}
