using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

//.........class, object, method starts.............//

            Person person1 = new Person();

            person1.setAge(12);

            int myage = person1.getAge();

            Console.WriteLine(person1.getAge());

            Person.greet(); // Example for static keyword


            //.........class, object, method Finish.............//



            //.........Try,Catch,Finally....Exception and Throw Starts.............//

            //string newText = "Here are some text".Substring(9, 1233);
            //Console.WriteLine(newText);

            try
            {
                //string newText = "Here are some text".Substring(9, 1233);

                Console.Write("Enter a string Value: ");
                string input = Console.ReadLine();

                try
                {
                    ConverStringToInt StringToIntConverter = new ConverStringToInt();
                    StringToIntConverter.Convert(input);

                }
                catch(Exception ex)
                {
                    Console.WriteLine("There was an error with Conversion: {0}", ex.Message);
                }

                string newText = "Here are some text".Substring(9, 1233);

                //int newNumber;

                //bool isNewNumber = int.TryParse(newText, out newNumber);

                //if (!isNewNumber)
                //{
                //    throw new Exception("This value is out of range");
                //}

            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an Error: {0}", ex.Message);
            }
            Console.WriteLine("The rest of the application works fine.");

//.........Try,Catch,Finally....Exception and Throw End.............//


            //.......Condition Start..........//

            /*
                string UserName = Console.ReadLine();
                string password = Console.ReadLine();

                if(UserName.Equals("Shawon", StringComparison.OrdinalIgnoreCase) && password.Equals("abc123"))
                {
                    Console.WriteLine("Hello Admin!");
                }
                else if(UserName.Equals("Joe") && password.Equals("abc124"))
                {
                    Console.WriteLine("Hello Moderator !");
                }
                else
                {
                    Console.WriteLine("Hello Guest !");
                }
             */

            //.......Condition Finish..........//



            //.......string Start..........//

            /*
                string someText = "Here is some text";
                string someOtherText = "Here is some OTHER Text";

                bool isEqual =  someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);

                string formatText = string.Format("{0} {1} its Working", someOtherText, someText);

                Console.WriteLine(formatText);

                Console.WriteLine(someText.Substring(8,4));

                string replacedText = someText.Replace("text", "string");
                Console.WriteLine(replacedText);
            */

            //.......string Finish..........//


            // Console.ReadKey();
        }
    }
}
