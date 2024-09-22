//namespace Week2_Assignment
//{
//    internal class FibonacciGenerator
//    {
//        static void Main(string[] args)
//        {
//            // Asking user for the number of Fibonacci terms to generate
//            Console.Write("Enter the number of Fibonacci terms to generate: ");
//            int terms = Convert.ToInt32(Console.ReadLine());

//            if (terms < 1)
//            {
//                Console.WriteLine("Please enter a valid number of terms.");
//                return;
//            }

//            // Initializing the first two Fibonacci numbers
//            int first = 1;
//            int second = 1;

//            // Print the first Fibonacci number
//            Console.Write(first);

//            // If the user wants more than 1 Fibonacci number, print the second one
//            if (terms > 1)
//            {
//                Console.Write($" {second} ");
//            }

//            // Generating and printing the rest of the Fibonacci numbers
//            for (int i = 3; i <= terms; i++)
//            {
//                int next = first + second;  // Calculate the next Fibonacci number
//                Console.Write($"{next} ");  // Print the next Fibonacci number with a space

//                // Update the first and second for the next iteration
//                first = second;
//                second = next;
//            }
//        }
//    }
//}
