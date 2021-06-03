using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        public void Welcome()
        {
            Console.WriteLine("....|WELCOME TO TIC TAC TOE|....");
        }

        public void createBoard()
        {

            char[] board = new char[10];        // initializing the number of character spaces in game
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';                // making each space empty 

            }
        }
        public void Display()
        {

        }
    }
}
