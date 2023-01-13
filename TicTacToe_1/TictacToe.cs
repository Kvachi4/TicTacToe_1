using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_1
{
    public class TicTacToe
    {
        public static char[] fieldArray = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        public static char mySymbol = 'X';
       
        public static void DrawCells()
        {
            Console.WriteLine(" ----------------------------------------------------------------------- \n\n ");
            Console.ForegroundColor = ConsoleColor.Yellow;
           

            Console.WriteLine("\t\t\t\t       |       |       ");
            Console.WriteLine("\t\t\t\t   {0}   |   {1}   |   {2}   ", fieldArray[0], fieldArray[1], fieldArray[2]);
            Console.WriteLine("\t\t\t\t_______|_______|_______");
            Console.WriteLine("\t\t\t\t       |       |       ");
            Console.WriteLine("\t\t\t\t   {0}   |   {1}   |   {2}   ", fieldArray[3], fieldArray[4], fieldArray[5]);
            Console.WriteLine("\t\t\t\t_______|_______|_______");
            Console.WriteLine("\t\t\t\t       |       |       ");
            Console.WriteLine("\t\t\t\t   {0}   |   {1}   |   {2}   ", fieldArray[6], fieldArray[7], fieldArray[8]);
            Console.WriteLine("\t\t\t\t       |       |       \n\n");

            Console.WriteLine(" ----------------------------------------------------------------------- \n\n ");
        }

        public static void TurnOver()
        {
            if (mySymbol == 'X')
            {
                mySymbol = 'O';
            }
            else if (mySymbol == 'O')
            {
                mySymbol = 'X';
            }
        }


        public static void PlayGame()
        {
            int getPositionNumber = 0; //choice
            int counter = 1;

            
            do
            {             
                Console.WriteLine("Please eneter the number beatween 1 - 9 :");
                getPositionNumber = int.Parse(Console.ReadLine());

                
                switch (getPositionNumber)
                {
                    case 1:
                        fieldArray[0] = mySymbol;
                        TurnOver();
                        break;
                    case 2:
                        fieldArray[1] = mySymbol;
                        TurnOver();
                        break;
                    case 3:
                        fieldArray[2] = mySymbol;
                        TurnOver();
                        break;
                    case 4:
                        fieldArray[3] = mySymbol;
                        TurnOver();
                        break;
                    case 5:
                        fieldArray[4] = mySymbol;
                        TurnOver();
                        break;
                    case 6:
                        fieldArray[5] = mySymbol;
                        TurnOver();
                        break;
                    case 7:
                        fieldArray[6] = mySymbol;
                        TurnOver();
                        break;
                    case 8:
                        fieldArray[7] = mySymbol;
                        TurnOver();
                        break;
                    case 9:
                        fieldArray[8] = mySymbol;
                        TurnOver();
                        break;
                    default:
                        Console.WriteLine("You have entered the wrong position number...");
                        break;

                } 
                if (getPositionNumber >= 1 && getPositionNumber <= 9)
                { 
                    counter++;
                   
                }
                if (getPositionNumber > 9 || getPositionNumber < 1)
                {
                    counter++;                    
                    continue;                    
                }
           
                Console.Clear();
                DrawCells();

                if (counter >= 4)
                {
                    GameResults.GetScore();
                }
                 
            } while (counter > 1 && counter < 10);

           
        }


        // Random random = new Random();
        //int compPosition = random.Next(1, 9);





        

    }
}


