using System;

namespace Test_CSharp {
    class Program {
        static void Main(string[] args) {
            string text1 = "Hello";
            string text2 = ", World! ";

            Console.WriteLine("Please type another string!");
            string typeMessage = Console.ReadLine();

            Console.Write("{0}{1}{2}\n", text1, text2, typeMessage); // This is C Style

            Program program = new Program();
            Console.WriteLine(program.Plus(10, 10));
        }

        int Plus(int number1, int number2) { // This is new function
            return number1 + number2;
        }
    }
}