


using System;

namespace program

{
    class Program
    {
        static void Main(string[] args)

        {
            
            //Restart menu
            bool restart = true;
            while (restart)
            {

            
            string mathoperator;
            // To determine whether the value of x is empty, null or a non-numeric value ; I set it as a string first.
            string x;

            // I used a second variable to convert x to a integer if it meets these conditions.
            double integerX;
            do
            {
                

                // Error messages are displayed in red. This code makes the color default if the loop is repeated.
                Console.ResetColor();
                
              // I used a temporary string to check if the entered value is numeric.
                Console.WriteLine("Please enter a x value (between 0 and 25)");
                x = Console.ReadLine();
                
                // This bool variable here checks if the value x is empty or null.
                bool isXEmptyornull = String.IsNullOrEmpty(x);
                
               
                bool isXnumeric = (double.TryParse(x, out integerX));

              
                if (isXEmptyornull == false)
                {
                   
                    if (isXnumeric == true)
                    {
                        
                        if (0 <= integerX && integerX <= 25)
                        {
                            
                           Console.WriteLine("Please choose the type of the operator");
                            
                            mathoperator = Console.ReadLine();

                            // If operator is "*" or "/" the condition ends and the loop breaks.
                            if (mathoperator == "*" || mathoperator == "/")
                            {
                                break;
                            }
                            
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Please select only '/' or '*'signs !");

                            }
                           
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Please enter a number between 0 and 25 !");
                        }
                    }
                  
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter a number !");
                       
                    }
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid value !");
                    
                }                
            } while (true);


           
                
                
                
                double factorial=1;
               
                int denominator;
            double final_result=0;
            
           
            for (int j = 1; j <= 30; j++)
            {
                
                int multiplier_of_x = ((4 * j) - 1);
                int exponent_of_x = ((3 * j) - 1);
                int fact_value = ((2 * j) + 2);
                int second_constant = ((5 * j) - 3);
                double denom_result = 0;
                int denom_counter = j;

                //alttaki sayı hesabı (dogru cali,siyor)
                for (int i = 0; i < (j + 1); i++)
                {
                    double q = 1;
                    denominator = 2 * denom_counter;
                    for (int b = 0; b < j + 1; b++)
                    {
                        q = q * denominator;
                    }
                    denom_result = denom_result + q;
                    denom_counter = denom_counter + 1;
                }


               // Factorial calculation
                factorial = 1;
                for (int i = 1; i <= fact_value; i++)
                {
                    factorial = factorial * i;
                }


                // It calculates the power of the entered x value 
                double power = 1;
                for (int i = 1; i <= exponent_of_x; i++)
                {
                    power = power * integerX;
                }

                // It multiplies the power of the entered x value by the appropriate coefficient.
                double final_x = (multiplier_of_x * power);


                // Comparing the final_x value with its factorial value
                double numerator_minimum;
                if (final_x >factorial)
                {
                    numerator_minimum = factorial;
                    if (j % 2 == 1)
                    {
                        if (mathoperator == "*")
                        {
                            final_result = (final_result) + ((numerator_minimum * second_constant) / (denom_result));
                        }
                        else if (mathoperator == "/")
                        {
                            final_result = (final_result) + ((numerator_minimum / second_constant) / (denom_result));
                        }
                    }
                    else if (j % 2 == 0)
                    {
                        if (mathoperator == "*")
                        {
                            final_result = (final_result) - ((numerator_minimum * second_constant) / (denom_result));
                        }
                        else if (mathoperator == "/")
                        {
                            final_result = (final_result) - ((numerator_minimum / second_constant) / (denom_result));
                        }
                    }
                }
                

                    else 
                    {
                    numerator_minimum = final_x;
                        if (j % 2 == 1)
                        {
                            if (mathoperator == "*")
                            {
                                final_result = (final_result) + ((numerator_minimum * second_constant) / (denom_result));
                            }
                            else if (mathoperator == "/")
                            {
                                final_result = (final_result) + ((numerator_minimum / second_constant) / (denom_result));
                            }
                        }
                        else if (j % 2 == 0)
                        {
                            if (mathoperator == "*")
                            {
                                final_result = (final_result) - ((numerator_minimum * second_constant) / (denom_result));
                            }
                            else if (mathoperator == "/")
                            {
                                final_result = (final_result) - ((numerator_minimum / second_constant) / (denom_result));
                            }
                        }
                    }
                


              
            }
            
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Answer = ");
            Console.ResetColor();
            Console.Write(final_result);
            Console.WriteLine("\n--------------------------------------------------");



                string restart_choice;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Would you like to calculate again? (");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Y");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("N");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(")");
                Console.ResetColor();
                Console.WriteLine();
                restart_choice = Console.ReadLine();
                if (restart_choice == "Y" || restart_choice == "y")
                {
                    restart = true;
                    
                    Console.Clear();
                }
                else if (restart_choice == "N" || restart_choice == "n")
                {
                    restart = false;
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nYou made an invalid choice. By default, the program will be stopped.");
                    Console.ResetColor();
                    restart = false;
                    Console.ReadKey();
                }
            }
        }

        

    }
}
