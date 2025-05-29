using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class ComandoFactory
    {
        private List<Commando> comandos;

        public ComandoFactory()
        {
            comandos = new List<Commando>();
        }

        public void CreateComando(string name, string codename, Enum.Comando Kind)
        {
            Commando comando;
            switch (Kind)
            {
                case Enum.Comando.Sea:
                    comando = new SeaCommando(name, codename);
                    break;
                case Enum.Comando.Air:
                    comando = new AirCommando(name, codename);
                    break;

                default:
                    comando = new Commando(name, codename);
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
