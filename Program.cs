using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {//Variables

            char ch,loop;

            Console.WriteLine("\n======Temperature Converter======");
            //Loop
            do { 
                //Write

            Console.Write("\n******************\n'C'=> \"Celsius\". \n'f'=> \"Fahrenheit\".\nChoose Character: ");
            ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine("\n******************");

            Console.Write("\nThe Degree =");
            string input = Console.ReadLine();
            //Validation of Value

                if (double.TryParse(input, out double degree))
                {
                    //Read
                Program.PrintTemperature(ch, degree);
                
               
                }
              else { Console.WriteLine("\nInsert Invalid Data"); }
                
                Console.Write("\n**********************\nRepeat ('Y':'N')? ");
                loop = char.ToLower(Console.ReadKey().KeyChar);
            } while (loop.Equals('y'));
        }
        //Print Method
        static void PrintTemperature(char ch,double degree)
        {
            if (ch.Equals('c'))
            {
                    Console.WriteLine($"Converted: {TemperatureConverter.ToCelsius(degree):0.00} °C");
                
            }
            else if (ch.Equals('f'))
            {
                
                    Console.WriteLine($"Converted: {TemperatureConverter.ToFahrenheit(degree):0.00} °f");
                
            }
            else
            {
                Console.WriteLine("\n Insert Invalid Data");
            }
        }
    }
    //Static Class => All Fields and Members are Static
    //             => No Instanciate - No Inheritance
    static class TemperatureConverter
    {
        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
