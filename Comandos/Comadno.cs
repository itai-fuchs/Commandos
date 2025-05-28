using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    public enum Tool
    {
        Hammer,
        Chisel,
        Rope,
        Bag,
        WaterBottle
    }

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
        protected string Status { get; private set; }

        //solider tools
        protected Tool[] tools = { Tool.Hammer, Tool.Chisel, Tool.Rope, Tool.Bag, Tool.WaterBottle };


        //constractor
        public Comando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Status = "standing";



        }
        //is walking method
        public void Walk()
        {
            Console.WriteLine("The commando is going");
            Status = "walking";
        }

        //is hiding method
        public void Hide()
        {
            Console.WriteLine("The commando is hiding");
            Status = "hiding";
        }

        //is attacking method
        public virtual void Attack()
        {
            Console.WriteLine($"The commando {CodeName} is attacking");

        }


    }
}
