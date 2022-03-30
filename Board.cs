using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        string[,] grid;
        public int boardSize { get; set; }
        
        public Board(int boardSize)
        {
            this.boardSize = boardSize;
            grid = new string[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    grid[i, j] = " ";
                }
            }
        }

        public void drawNewBoard()
        {
            Console.Clear();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)  // output grid row contents separated by "|"
                {
                    Console.Write(grid[i, j]);
                    if (j != boardSize - 1) {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                for (int j = 0; j < boardSize; j++)  // separate grid rows using "-"
                {
                    if (i != boardSize - 1) {
                        Console.Write("-");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
