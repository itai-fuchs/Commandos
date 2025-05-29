using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemy
    {

        public string Name { get; set; }
        public bool IsAlive { get; private set; }

        public Enemy(string name)
        {
            Name = name;
            IsAlive = true;
        }

        public void Scream()
        {
            Console.WriteLine("I AM AN ENEMY!!");
        }

        public void attacked(){IsAlive= false;}


    }
}
