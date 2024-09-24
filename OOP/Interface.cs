using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Interface
    {
        // Interface is the another way to achive the abstraction
         
        public static void Main(string[] args)
        {
            Cat cat  = new Cat();
            cat.makeSound();
        }
    }

    interface IAnimal
    {
        void makeSound();
        void sleep();
    }

    class Cat : IAnimal
    {
        public void makeSound()
        {
            Console.WriteLine("Cat is making sound !");
        }

        public void sleep()
        {
            Console.WriteLine("Cat is sleeping !");
        }
    }
}
