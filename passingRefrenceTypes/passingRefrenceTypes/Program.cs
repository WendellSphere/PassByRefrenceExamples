using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingRefrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();
            int parsedString;
            bool isInputGood = Int32.TryParse(userInput, out parsedString); // out is the key word 

            if (isInputGood == true)
            {
                if (parsedString > 10)
                {
                    Console.WriteLine("More then 10");
                }
                else
                {
                    Console.WriteLine("Less then 10");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }

            Console.ReadLine();

        

           // Dim n = bird; 

            StringBuilder sb = new StringBuilder();
            FooMethod(sb);                                    // when a pass a refrence type, sb, as a value it will copy the paremter's refrence, foo,
            Console.Write(sb.ToString());  // word test
            Console.ReadLine();
            Console.Write(sb.ToString());
            Console.ReadLine();
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        static void FooMethod(StringBuilder foo)    // foo and sb, the arugment, will point to the same object or instance
        {
            foo.Append(" word");   // refrenced instance changes   
            foo.Append(" test");   // it changes it agian
            StringBuilder foo2 = new StringBuilder();  // we intialize a new instance of StringBuilder called foo2 which holds the refrence to the this new object in the heap
            foo2.Append("different refrence");    // the instance changes, 
            foo = foo2;   // we assign this new refrence to foo, the intial refrence, this doesn't change sb because sb holds the intial refrence. 
            
        }
    }
}



            //take user imput, and check if number is greater then 10 mark it true, if less... false

         
    
