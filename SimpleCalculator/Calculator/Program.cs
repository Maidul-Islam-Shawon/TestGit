using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            try
            {
                Console.Write("Enter First Number: ");
                double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
            
                Console.Write("Enter Operation: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

        }
    }
}
