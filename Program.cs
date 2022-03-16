using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChallengers = 0;
            int boardSize = 0;
            Console.Write("Tic Tac Toe Game.  What's your name?: ");
            var player = Console.ReadLine();

            while (numChallengers == 0) { 
                Console.Write("How many Challengers?: ");
                if (!int.TryParse(Console.ReadLine(), out numChallengers))
                {
                    Console.WriteLine("Integer value only.  Try again.");
                }
            }

            while (boardSize == 0)
            {
                Console.Write("What's the board size?: ");
                if (!int.TryParse(Console.ReadLine(), out boardSize))
                {
                    Console.WriteLine("Integer value only.  Try again.");
                }
            }
            
            var message = $"Welcome {player}. You will have {numChallengers} Challengers on a {boardSize} X {boardSize} board!  ";
            Console.Write(message);

            List<string> challengers = new List<string>();
            for (int i = 0; i < numChallengers; i++)
            {
                Console.Write("What is the name of Challenger # {0}: ", i+1);
                challengers.Add(Console.ReadLine());
            }
        }  
    }
}
