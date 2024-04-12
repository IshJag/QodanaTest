using System;

namespace QodanaTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, world!");

            // Error 1: Unused variable
            int unusedVariable = 5;

            // Error 2: Incorrect casing in method name according to .NET naming conventions
            printmessage("Testing Qodana");

            // Error 3: Potential null reference exception
            string message = null;
            PrintLength(message);
        }

        // Error 2 continued: Method should be capitalized
        static void printmessage(string message) {
            Console.WriteLine(message);
        }

        static void PrintLength(string input) {
            // Error 4: No null check before accessing the string
            Console.WriteLine("Length of the input string: " + input.Length);
        }
    }
}
