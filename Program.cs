﻿using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Welcome();
            Console.WriteLine();
            game.CreateBoard();
            game.Input();
            
        }
    }
}
