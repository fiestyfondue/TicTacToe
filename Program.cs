using System;

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
            char[] board = game.CreateBoard();
            game.Input();
            game.ShowBoard(board);
            
        }
    }
}
