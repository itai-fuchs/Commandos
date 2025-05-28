using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    internal class Stone
    {

        public string name{  get; set; }
        public int weight { get; set; }
        public string color { get; set; }

        public string status { get; set; }

        public int NumOfHits {  get; set; }
        public Stone()
        {
            status = "intact";
            NumOfHits = 0;


        }

        public void Hits()
        {
            if (status == "break") Console.WriteLine("cant attack the  stone is broken");
            else NumOfHits += 1;
            if (NumOfHits == 5) status = "break";
        }



    }
}
