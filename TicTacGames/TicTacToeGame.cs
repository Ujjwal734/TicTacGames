using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGames
{
    public class TicTacToeGame
    {
        public void Game()
        {
            char[] grid = new char[10];
            for (int i = 1; i < 10; i++)
            {
                grid[i] = ' ';
            }
        }
        public void Choose()
        {
            Console.WriteLine("Enter a Character you want");
            Console.WriteLine("1. Press X for choosing 'X'\n2. Press O for choosing 'O'");
            char choos = Convert.ToChar(Console.ReadLine());
            switch (choos)
            {
                case 'X':
                    Console.WriteLine("You will play with :- X ");
                    Console.WriteLine("Computer will play with :- O ");
                    break;
                case 'O':
                    Console.WriteLine("Your will Play with :- O ");
                    Console.WriteLine("Computer will play with :- X ");
                    break;
                default:
                    Console.WriteLine("Choose only between X and O ");
                    break;
            }
        }
    }
}
