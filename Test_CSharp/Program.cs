using System;

namespace Test_CSharp {
    class Program {
        static void Main(string[] args) {
            string text1 = "Hello";
            string text2 = ", World! ";
            string typeMessage = Console.ReadLine();
            
            Console.Write(text1 + text2 + typeMessage);
        }
    }
}