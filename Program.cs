using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tic Tac Toe Game.  What's your name?: ");
            var player = Console.ReadLine();

            int numChallengers = getInteger("How many Challengers?: ");
            int boardSize = getInteger("What's the board size?: ");


            var message = $"Welcome {player}. You will have {numChallengers} Challengers on a {boardSize} X {boardSize} board!  ";
            Console.Write(message);

            List<string> challengers = new List<string>();
            for (int i = 0; i < numChallengers; i++)
            {
                Console.Write("What is the name of Challenger # {0}: ", i+1);
                challengers.Add(Console.ReadLine());
            }

            Board game = new Board(boardSize);

            game.drawNewBoard();
            // new code goes here
        }
        public static int getInteger(string inputMsg)
        {
            int integer = 0;
            while (integer == 0)
            {
                Console.Write(inputMsg);
                if (!int.TryParse(Console.ReadLine(), out integer))
                {
                    Console.WriteLine("Integer value only.  Try again.");
                }
            }
            return integer;
        }
    }
}
