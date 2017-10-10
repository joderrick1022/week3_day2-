using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //ACESS MODIFIERS
            Boat boaty = new Boat(3, "boaty", 18.6);
            boaty.Move();

            boaty.BoatInfo();



            Console.WriteLine();
            Console.WriteLine();

            Boat boat2 = new Boat(14, "boat2", 30.2);
            boat2.BoatInfo();


            Cell_Phone cellie = new Cell_Phone("ring ring ring" , 2.2, 1);
            cellie.Ring();

        }           
            
        
    }
}
