using System;


namespace TicTacToe_1
{
    internal class MyConsole
    {
        public static void ModifyConsole()
        {
            Console.Beep(77, 777);
            Console.SetWindowSize(80, 25);
            Console.SetWindowPosition(0, 0);
            Console.Title = "TicTacToe - Game";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
    }
}
