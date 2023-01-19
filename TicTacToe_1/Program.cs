using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            MyConsole.ModifyConsole();
            Intro.PlayersInfo(); 
            TicTacToe.PlayGame();
            GameResults.GetScore();

            DateTime end = DateTime.Now;

            Console.WriteLine($" You Start Game At: {start.ToLongTimeString()} O\'Clock");
            Console.WriteLine($"   You End Game At: {end.ToLongTimeString()} O\'Clock");

            var totalTime = end - start;
            Console.WriteLine($"\t\t\t Game Duration Was: {totalTime.Seconds} Second");
            Console.WriteLine(" ---------------------------------------------------------------------- \n");
            Console.WriteLine("\t\t\t\t\t Game Over ");

            Console.ReadKey();
       
        }


    }
}
