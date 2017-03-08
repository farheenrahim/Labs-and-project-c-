using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy_Planet_Challenge // Name  of the project
{
    class Program // Name of the class
    {
        static void Main(string[] args)  // Entry point for program
        {
            int choice;

            // Displaying the menu options and calculating weight on the selected planet until the user chooses to quit

            do
            {
                // Displaying the menu options for the user

                Console.WriteLine("\n");
                Console.WriteLine("Menu of Planets");
                Console.WriteLine("==== == ========");
                Console.WriteLine("1.Jupiter  2.Mars  3.Mercury");
                Console.WriteLine("4.Neptune  5.Pluto 6.Saturn");
                Console.WriteLine("7.Uranus   8.Venus 9.<Quit>");
                Console.WriteLine("\n");

                // Accepting menu options only from 1 to 9 from the user

                do
                {

                    Console.Write("Enter you menu Choice: ");
                    choice = int.Parse(Console.ReadLine());

                } while (choice <= 0 || choice > 9);

                // If user chooses menu option 9 then quitting

                if (choice == 9)
                {
                    Console.WriteLine("Have a great day! Goodbye!");
                    Console.ReadLine();
                    break;
                }

                // If menu option is from 1 to 9 then asking for weight on earth

                else if (choice > 0 && choice < 9)
                {

                    float weight;
                    // Accepting weight on earther greater than 0
                    do
                    {

                        Console.Write("Enter your weight on earth: ");
                        weight = float.Parse(Console.ReadLine());

                    } while (weight <= 0);

                    double calculatedweight;


                    // Calculating weight on planet based on the user choice

                    switch (choice)

                    {
                        case 1:
                            calculatedweight = Math.Round((2.64 * weight), 1); // rounding the calculated weight to one decimal place
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 2:
                            calculatedweight = Math.Round((0.38 * weight), 1);
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 3:
                            calculatedweight = Math.Round((0.37 * weight), 1);
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 4:
                            calculatedweight = Math.Round((1.12 * weight), 1);

                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 5:
                            calculatedweight = Math.Round((0.04 * weight));
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 6:
                            calculatedweight = Math.Round((1.15 * weight));
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 7:
                            calculatedweight = Math.Round((1.15 * weight));
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                        case 8:
                            calculatedweight = Math.Round((0.88 * weight));
                            Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter", weight, calculatedweight);
                            break;
                    }


                }
            } while (choice != 9);
        }
    }

}