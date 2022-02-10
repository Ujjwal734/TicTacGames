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
                grid[i] = '*';
                Console.WriteLine(grid);
            }
        }
    }
}
