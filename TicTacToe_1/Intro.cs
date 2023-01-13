using System;


namespace TicTacToe_1
{
    internal class Intro
    {
        public static void introMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t   Welcome to The TicTacToe Game");
            Console.WriteLine("\t\t\t   ----------------------------- \n\n");
            Console.Write("Please Enter Yor Name : ");
            Console.Write(" ");
            string playerName1 = GetPlayerName();
            string playerName2 = "COMPUTER";

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t  {0}  VS  {1} ", playerName1, playerName2);
            Console.WriteLine("\t\t\t   ----------------------------- \n\n"); 
        }
        public static string GetPlayerName()
        {
            return Console.ReadLine().ToUpper();

        }
    }
}
