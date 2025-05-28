using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class ComandoFactory
    {
        private List<Comando> comandos;

        public ComandoFactory()
        {
            comandos = new List<Comando>();
        }

        public void CreateComando(string name, string codename, string Kind)
        {
            Comando comando;
            switch (Kind.ToLower())
            {
                case "seacomando":
                    comando = new SeaComando(name, codename);
                    break;
                case "aircomando":
                    comando = new AirComando(name, codename);
                    break;

                default:
                    comando = new Comando(name, codename);
                    break;

            }
            comandos.Add(comando);
        }





        public List<Comando> GetComandos()
        {
            return comandos;
        }
    }
}
