using System;

class Program
{
    static void Main(String[] args)
    {
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(i);
        //}

// Nested Loops
for(int i = 0; i <=2; i++)
        {
            Console.WriteLine(i);

// Inner Loop
for(int j=0; j <= 3; j++)
            {
                Console.WriteLine("Inner j " + j);
            }

        }

        // Arrays

        string[] names = ["Roman", "Anuj", "Pratap"];
        Console.WriteLine(names[0]);

        Console.WriteLine(names.Length);

        string[] new_arr =  { "audi", "farari" };
        Console.WriteLine(new_arr);
    }
}