using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Shoot_Test
    {
        // Member variables 
        public int playerOneChoice;
        public int playerTwoChoice;
        public int outcome;
        public int score;
        public int player1s;
        public int player2s;
        UI dwUI = new UI();

        // constructor
        public Shoot_Test()
        {
            Console.WriteLine(dwUI.promptList[1]);
            playerOneChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dwUI.promptList[2]);
            playerTwoChoice = Convert.ToInt32(Console.ReadLine());
        }
        //method
        public int DetermineWinner(int score)
        {
            while (player1s < 3 || player2s < 3)
            {
                outcome = (5 + playerOneChoice - playerTwoChoice) % 5;
                if (outcome == 1 || outcome == 3)
                {
                    score = player1s++;
                    Console.WriteLine(dwUI.promptList[3]);
                    Shoot_Test Loop = new Shoot_Test();
                    Loop.DetermineWinner(score);
                    return score;
                }

                else if (outcome == 2 || outcome == 4)
                {
                    score = player2s++;
                    Console.WriteLine(dwUI.promptList[4]);
                    Shoot_Test Loop = new Shoot_Test();
                    Loop.DetermineWinner(score);
                    return score;
                }
                else
                {
                    Console.WriteLine(dwUI.promptList[7]);
                    Shoot_Test Loop = new Shoot_Test();
                    Loop.DetermineWinner(0);
                    return 0;
                }
            }
            Console.WriteLine("LOL");
            return 0;
        }
    }
}

