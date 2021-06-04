using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to TicTacToe game");
            Game game = new Game();
            game.Welcome();
            Console.WriteLine("");
            char[] board = game.GameBoard();
            Game.Player player = game.GameInput();
            game.ShowBoard(board);
            //loop till all empty spaces are filled
            for (int i = 1; i < board.Length; i++)
            {
                board = game.UserMove(board, player);
                game.ShowBoard(board);
            }


        }
    }
}
