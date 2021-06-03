﻿using System;
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

        public void CreateBoard()
        {

            char[] board = new char[10];        // initializing the number of character spaces in game
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';                // making each space empty 

            }
        }

        public static int Toss()
        {
            Random random = new Random();
            int ran = random.Next(2);
            if(ran == 0)
            {
                Console.WriteLine("Player 1 plays first ");
                Console.WriteLine("Player 1 will use X for marking ");
            }
            if(ran == 1)
            {
                Console.WriteLine("Player 2 plays first");
                Console.WriteLine("Player 2 inputs with O");
            }
            return ran;
        }
        public void Input()
        {
            Toss();
        }
    }
}
