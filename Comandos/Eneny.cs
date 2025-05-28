using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Enemy
    {

        public string Name { get; set; }
        public bool IsAlive { get; private set; }

        // בנאי
        public Enemy(string name)
        {
            Name = name;
            IsAlive = true;
        }

        // פונקציה של צעקה
        public void Scream()
        {
            Console.WriteLine("i am enemy!!");
        }
    
    }
}
