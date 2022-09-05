using System;

namespace ProjectUdemy
{
    class Program
    {

        static void Main(string[] args)
        {

            bool game = true, still_on = true;

            while (still_on)
            {
                string[,] array =
                {
                    {"1","2","3"},
                    {"4","5","6"},
                    {"7","8","9"}
                };

                int playerID = 1;
                string choosedField;
                string symbol;

                while (game)
                {
                    Console.Clear();
                    ShowArray(array);

                    switch (playerID)
                    {
                        case 1:
                            symbol = "X";
                            Console.WriteLine("Player 1: Choose your field: ");
                            choosedField = Console.ReadLine();

                            ChangeArray(choosedField, array, symbol);

                            playerID = 2;
                            break;


                        case 2:
                            symbol = "O";
                            Console.WriteLine("Player 2: Choose your field: ");
                            choosedField = Console.ReadLine();

                            ChangeArray(choosedField, array, symbol);

                            playerID = 1;
                            break;

                        default:
                            break;
                    }
                    if (array[0, 0] == "X" && array[1, 0] == "X" && array[2, 0] == "X" || array[0, 0] == "X" && array[0, 1] == "X" && array[0, 2] == "X" ||
                        array[2, 0] == "X" && array[2, 1] == "X" && array[2, 2] == "O" || array[0, 2] == "X" && array[1, 2] == "O" && array[2, 2] == "X" ||
                        array[0, 0] == "X" && array[1, 1] == "X" && array[2, 2] == "X")
                    {
                        Console.Clear();
                        ShowArray(array);
                        Console.WriteLine("Player 1 WINS!");
                        game = false;
                    }
                    else if (array[0, 0] == "O" && array[1, 0] == "O" && array[2, 0] == "O" || array[0, 0] == "O" && array[0, 1] == "O" && array[0, 2] == "O" ||
                             array[2, 0] == "O" && array[2, 1] == "O" && array[2, 2] == "O" || array[0, 2] == "O" && array[1, 2] == "O" && array[2, 2] == "O" ||
                             array[0, 0] == "O" && array[1, 1] == "O" && array[2, 2] == "O")
                    {
                        Console.Clear();
                        ShowArray(array);
                        Console.WriteLine("Player 2 WINS!");
                        game = false;
                    }

                }

                Console.WriteLine("Replay?. Press enter");

                if (Console.ReadLine() == "")
                {
                    game = true;
                }
                else still_on = false;

            }

            Console.ReadKey();
        }



        static void ShowArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("        |        |        |");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("    " + array[i, j] + "   |");

                }
                Console.WriteLine("");
                Console.WriteLine("        |        |        |");
                Console.WriteLine("---------------------------");

            }

        }

        static void ChangeArray(string input, string[,] array, string symbol)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (input == array[i, j])
                    {
                        array[i, j] = symbol;
                    }
                }
            }

        }
    }

}
