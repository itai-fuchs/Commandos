using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Commandos.Enum;

namespace Commandos
{
   

    /// <summary>
    /// claas that create a comando solider
    /// </summary>
    internal class Commando
    {

        //solider name
        protected string Name;
        public string SayName(Enum.SoliderRank commanderRank)
        {
            if (commanderRank ==Enum.SoliderRank.General ) return Name;
            else if (commanderRank == Enum.SoliderRank.Colonel) return CodeName;
            else Console.WriteLine("classified information");
            return "";


        }

        //solider codeName
        protected string CodeName { get; set; }

        //solider status
        protected Enum.PeopleStatus status{ get; private set; }

        //solider tools
        protected List<Enum.Tool> tools;

        //solider  weapon

        protected List<Enum.WeaponType> weapon{ get; set; }

        //constractor
        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            status = Enum.PeopleStatus.standing;
            this.weapon = WeaponFactory.
            
            this.tools = new List<Enum.Tool>
{
    Enum.Tool.Hammer,
    Enum.Tool.Chisel,
    Enum.Tool.Rope,
    Enum.Tool.Bag,
    Enum.Tool.WaterBottle
};





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
