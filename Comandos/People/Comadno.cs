using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
   

    /// <summary>
    /// claas that create a comando solider
    /// </summary>
    internal class Comando
    {

        //nsolider name
        protected string Name;
        public string SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL") return Name;
            else if (commanderRank == "COLONEL") return CodeName;
            else Console.WriteLine("classified information");
            return "";


        }

        //solider random codeName
        protected string CodeName { get; set; }

        //solider status
        protected Enum.PeopleStatus status{ get; private set; }

        //solider tools
        protected  Enum.Tool[] tool ={ Enum.Tool.Hammer, Enum.Tool.Chisel, Enum.Tool.Rope, Enum.Tool.Bag, Enum.Tool.WaterBottle};


        //constractor
        public Comando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            status = Enum.PeopleStatus.standing;



        }
        //is walking method
        public void Walk()
        {
            Console.WriteLine("The commando is going");
            status = Enum.PeopleStatus.walking; 
        }

        //is hiding method
        public void Hide()
        {
            Console.WriteLine("The commando is hiding");
            status = Enum.PeopleStatus.hiding;
        }

        //is attacking method
        public virtual void Attack()
        {
            Console.WriteLine($"The commando {CodeName} is attacking");

        }


    }
}
