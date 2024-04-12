using System;

namespace QodanaTest {
    class LoopArrayErrors {
        static void Main(string[] args) {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Error 1: Off-by-one error in loop boundary
            for (int i = 0; i <= numbers.Length; i++) {
                Console.WriteLine("Number: " + numbers[i]);
            }

            // Error 2: Null reference in foreach loop
            string[] strings = null;
            foreach (var s in strings) {
                Console.WriteLine("String: " + s);
            }

            // Error 3: Variable shadowing
            int x = 10;
            if (x > 5) {
                int x = 20; // This will not compile
                Console.WriteLine("Nested x: " + x);
            }
        }
    }
}
