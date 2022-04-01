using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe game");
            int numPlayers = getInteger("How many Players?: ");
            int boardSize = getInteger("What's the board size?: ");
            string[] tokens = { "X", "O", "Q", "V", "Z", "S"};
            int row;
            int column;
            string token;
            bool winner = false;

            var message = $"Welcome. You will have {numPlayers} Players on a {boardSize} X {boardSize} board!  ";
            Console.WriteLine(message);

            List<string> players = new List<string>();
            for (int i = 0; i < numPlayers; i++)
            {
                Console.Write("What is the name of Player #{0}:? ", i+1);
                players.Add(Console.ReadLine());
            }

            Board game = new Board(boardSize);

            game.drawBoard();

            while (!winner)
            { 
                foreach (string player in players)
                {
               
                    int idx = players.IndexOf(player);
                    token = tokens[idx];

                    Console.Write(player);
                    row = getInteger(", What row do you choose? ");

                    Console.Write(player);
                    column = getInteger(", What column do you choose? ");
                    game.updateGrid(row, column, token);
                    game.drawBoard();
                    winner = game.checkWinner();
                    if (winner)
                    {
                        message = $"Congratulations {player}.  You are the winner.";
                        Console.WriteLine(message);
                        break;
                    }
                }
            }
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
