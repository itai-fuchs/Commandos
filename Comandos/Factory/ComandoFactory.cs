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

        public void CreateComando(string name, string codename, Enum.Comando Kind)
        {
            Comando comando;
            switch (Kind)
            {
                case Enum.Comando.Sea:
                    comando = new SeaComando(name, codename);
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





        public List<Comando> GetComandos()
        {
            return comandos;
        }
    }
}
