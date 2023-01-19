using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe_1
{
    internal class Intro
    {
        public static string playerName1 = GetPlayerName1(); 
        public static string playerName2  = GetPlayerName2();
        public static void PlayersInfo()
        {        
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine("\t\t\t\t  {0}  VS  {1} ", playerName1, playerName2);
            Console.WriteLine("\t\t\t   ----------------------------- \n\n");      
        }
        public static string GetPlayerName1()
        {
            return Console.ReadLine().ToUpper();
        }
        public static string GetPlayerName2() 
        {
            return "COMPUTER";
        }
    }    
}
 