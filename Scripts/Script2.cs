using System;

namespace QodanaTest {
    class DateErrors {
        static void Main(string[] args) {
            // Error 1: Use of a possibly uninitialized local variable
            DateTime date;
            Console.WriteLine("Today's date is: " + date.ToString());

            // Error 2: Incorrect format specifier
            DateTime today = DateTime.Now;
            Console.WriteLine("Formatted Date: " + today.ToString("YYYY-MM-DD"));

            // Error 3: Assignment in condition
            if ((date = DateTime.Today) != DateTime.MinValue) {
                Console.WriteLine("Assigned and checked date in condition");
            }
        }
    }
}
