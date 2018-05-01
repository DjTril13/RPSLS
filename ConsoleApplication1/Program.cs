using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Shoot_Test RunGame = new Shoot_Test();
            RunGame.DetermineWinner(0);
            Console.ReadLine();
        }
    }
}
