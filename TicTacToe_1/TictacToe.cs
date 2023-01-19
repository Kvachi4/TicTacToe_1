using System;


namespace TicTacToe_1
{
    public class TicTacToe
    {
        public static char[] fieldArray = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        public static char mySymbol = 'X';
        static int getPositionNumber;
        public static int counter = 1;

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
        #region turnover
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
        #endregion

        public static void PlayGame()
        {


            Random random = new Random();
            
           
            
           
            do
            { 
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} it is your round", Intro.playerName2);
                    int compPosition = random.Next(1, 9);
                    for (int i = 0; i < 10; i++)
                    {
                        
                        
                            switch (compPosition)
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
                            

                        

                    }counter++;

                }
                else
                {                    
                    Console.WriteLine("{0} it is your round", Intro.playerName1);
                }
                Console.WriteLine("\n");

                Console.WriteLine("Please eneter the number beatween 1 - 9 :");
                getPositionNumber = int.Parse(Console.ReadLine());              
                
                if (getPositionNumber >= 1 && getPositionNumber <= 9)
                {
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
                    counter++;                   
                }

                if (getPositionNumber > 9 || getPositionNumber < 1)
                {
                    counter++;                    
                    continue;                    
                }
           
                Console.Clear();
                DrawCells();               

            } while (counter > 1 && counter < 10);
           
        }
    }
}


