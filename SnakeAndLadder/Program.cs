﻿using System;

namespace SnakeAndLadder
{
    class Program
    {
        //Constants
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of snake and ladder");
            Console.WriteLine();
            Console.WriteLine("Single Player mode: Starting position 0");  //as per UC1
            Console.WriteLine("GAME START");

            //Variables
            int position = 0;

            //creatting random object
            Random die = new Random();     
            Random options = new Random();
            int dice = die.Next(1, 7);      
            Console.WriteLine("The number on this die roll is: " + dice);
            int opt = options.Next(0, 3); 

            if (opt == NO_PLAY)
            {
                Console.WriteLine("No play: Player in same position-- " + position);
            }
            else if (opt == LADDER)
            {
                position = position + dice;
                Console.WriteLine("Ladder!!! postion-- " + position);
            }
            else
            {
                position = position - dice;
                Console.WriteLine("Snake!!! new position-- " + position);
            }


        }
    }
}