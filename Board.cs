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

        public void drawBoard()
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

        public void updateGrid(int row, int column, string token)
        {
            grid[row-1, column-1] = token;      
        }

        public bool checkWinner()
        {
            bool winner = false;
            bool middleCheck = true;
            for (int i = 0; i < boardSize; i++)  // check rows for winner
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (j > 0)
                    {
                        if (grid[i,j] != grid[i, j-1]) 
                        {
                            middleCheck = false;
                            break;
                        }
                    } 
                }
                if (middleCheck)
                {
                    winner = true;
                    return winner;
                }
            }
            for (int j = 0; j < boardSize; j++)  // check columns for winner
            {
                for (int i = 0; i < boardSize; i++)
                {
                    if (i > 0)
                    {
                        if (grid[i, j] != grid[i - 1, j])  
                        {
                            middleCheck = false;
                            break;
                        }
                    }
                }
                if (middleCheck)
                {
                    winner = true;
                    return winner;
                }
            }
            for (int i = 0; i < boardSize; i++)  // check diagonal for winner
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i != 0 && j != 0)
                    {
                        if (i == j)
                        {
                            if (grid[i, j] != grid[i - 1, j - 1])
                            {
                                middleCheck = false;
                                break;
                            }
                        }
                    }
                    
                }
                if (middleCheck)
                {
                    winner = true;
                    return winner;
                }
            }
            return winner;
        }
    }
}
