using MathSolverLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrjModule2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathSolver solver = new MathSolver();

            //Dot in console
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //

            while (true)
            {

                Menu(solver);

                Console.WriteLine("Press 'e' for exit or enter for continue");

                ConsoleKeyInfo exitState = Console.ReadKey();
                switch (exitState.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        continue;
                    case ConsoleKey.E:
                        return; ;
                    default:
                        return;

                }
            }
        }
        static void Menu(IMathSolver solver)
        {

            Console.Write($"\nWrite type of your data(integer|long|double|float): ");
            string numbersType = Console.ReadLine();


            Type numberType = Type.GetType(
                numbersType == "integer" ? "System.Int32" :
                numbersType == "long" ? "System.Int64" :
                numbersType == "double" ? "System.Double" :
                numbersType == "float" ? "System.Single" : "");

            Type numberListType = Type.GetType(
               numbersType == "integer" || numbersType == "long" ? "System.Int64" :
               numbersType == "double" || numbersType == "float" ? "System.Double"
               : "");

            Type listType;
            IList numbersList;
            try
            {
                listType = typeof(List<>).MakeGenericType(numberListType);
                numbersList = (IList)Activator.CreateInstance(listType);
            }
            catch
            {
                ConsoleWithColor("\bType is incorrect", ConsoleColor.Red);
                return;
            }
            while (true)
            {
                Console.Write($"Write array of numbers( integers or decimals), enter a value with a space: ");
                string lineOfNumbers = Console.ReadLine();

                Console.Write($"\nWrite degree what u want to get: ");
                int degreeOfNumbers = 0;
                try
                {
                    degreeOfNumbers = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    ConsoleWithColor("\bDegree is incorrect", ConsoleColor.Red);
                }

                dynamic arrayOfNumbers = 0;
                switch (numbersType)
                {

                    case "integer":
                        try
                        {
                            arrayOfNumbers = MathSolver.StringLineToInt(lineOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }
                        break;
                    case "long":
                        try
                        {
                            arrayOfNumbers = MathSolver.StringLineToLong(lineOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }
                        break;
                    case "double":
                        try
                        {
                            arrayOfNumbers = MathSolver.StringLineToDouble(lineOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }

                        break;
                    case "float":
                        try
                        {
                            arrayOfNumbers = MathSolver.StringLineToFloat(lineOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }
                        break;
                    default:
                        ConsoleWithColor("\b There no such type", ConsoleColor.Red);
                        break;
                }


                Console.Write($"\nWrite function(Divide|Differentiate|Multiply|Summarize): ");
                string functionType = Console.ReadLine();

                var processedNumber = Activator.CreateInstance(numberType);

                switch (functionType)
                {

                    case "Divide":
                        try
                        {
                            processedNumber = solver.Divide(arrayOfNumbers, degreeOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }
                        break;
                    case "Differentiate":
                        try
                        {
                            processedNumber = solver.Differentiate(arrayOfNumbers, degreeOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }
                        break;
                    case "Multiply":
                        try
                        {
                            processedNumber = solver.Multiply(arrayOfNumbers, degreeOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }

                        break;
                    case "Summarize":
                        try
                        {
                            processedNumber = solver.Summarize(arrayOfNumbers, degreeOfNumbers);
                        }
                        catch (Exception ex)
                        {
                            ConsoleWithColor($"\b{ex.Message}\n", ConsoleColor.Red);
                            return;
                        }
                        break;
                    default:
                        ConsoleWithColor("\bThere no such function", ConsoleColor.Red);
                        break;
                }

                Console.WriteLine($"Your answer is: {processedNumber}");

                numbersList.Add(processedNumber);


                Console.Write("\n");
                Console.Write($"\nWant to compare answers?(y/n): ");
                if (Console.ReadKey().KeyChar == 'y')
                {
                    Console.Write("\n Write numeral system for compare [2;32]: ");
                    int numeralBase=0;
                    try
                    {
                        numeralBase = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        ConsoleWithColor("\b Numeral system is incorrect", ConsoleColor.Red);
                    }


                    string[] comparedNumbersArray = null;
                    switch (numbersType)
                    {

                        case "integer":
                            comparedNumbersArray = solver.ArbitrarySystemComparison(numbersList.Cast<long>().ToArray(), numeralBase);
                                break;
                        case "long":
                            comparedNumbersArray = solver.ArbitrarySystemComparison(numbersList.Cast<long>().ToArray(), numeralBase);
                            break;
                        case "double":
                            comparedNumbersArray = solver.ArbitrarySystemComparison(numbersList.Cast<double>().ToArray() , numeralBase);

                            break;
                        case "float":
                            comparedNumbersArray = solver.ArbitrarySystemComparison(numbersList.Cast<double>().ToArray(), numeralBase);

                            break;
                        default:
                            ConsoleWithColor("\b There no such type", ConsoleColor.Red);
                            break;
                    }

                    foreach (var number in comparedNumbersArray)
                    {
                        Console.Write(number);

                        if (number != comparedNumbersArray[comparedNumbersArray.Length - 1])
                            Console.Write(" <= ");
                    }
                }

                Console.Write($"\nWant to continue?(y/n): ");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    break;
                }
                Console.Write("\n");
            }

        }
        private static void ConsoleWithColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
