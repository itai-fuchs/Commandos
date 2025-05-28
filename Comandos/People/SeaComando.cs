using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class SeaComando:Comando
    {
        public SeaComando(string name, string Codename) : base(name, Codename) { }

        public void Swiming()
        {
            Console.WriteLine("The soldier is swiming");
        }

        public override void Attack()
        {
            Console.WriteLine($"The SeaCommando {CodeName} is attacking");

        }
    }
}
