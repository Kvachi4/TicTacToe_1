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
            MyConsole.ModifyConsole();
            Intro.introMessage();
            TicTacToe.PlayGame();
            


        }


    }
}
