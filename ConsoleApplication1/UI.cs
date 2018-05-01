using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class UI
    {
        public List<string> promptList;
        public int userResponse;


        public UI()   // constructor
        {
            promptList = new List<string>();
            promptList.Add("Welcome to RPSLS! How many players do you have. Type '1' or '2'.");
            promptList.Add("It's Player One's turn. Please enter the number corresponding to your choice : 0. 'Rock', 1. 'Paper', 2. 'Siccors', 3. 'Lizzard', 4. 'Spock");
            promptList.Add("It's Player Two's turn. Please enter the number corresponding to your choice : 0. 'Rock', 1. 'Paper', 2. 'Siccors', 3. 'Lizzard', 4. 'Spock");
            promptList.Add("Player One has won this round");
            promptList.Add("Player Two has won this round");
            promptList.Add("Congradulations Player One has won the game! Do you want to play again?");
            promptList.Add("Congradulations Player Two has won the game! Do you want to play again?");
            promptList.Add("Tie! Try again");

        }

        //Methods    
        public int GetInput()
        {
            Console.WriteLine(promptList);
            userResponse = Convert.ToInt32(Console.ReadLine());
            return userResponse;
        }

        //    public void DisplayMessage(promptList)
        //    {
        //        Console.WriteLine(promptList);
        //}
    }
}

