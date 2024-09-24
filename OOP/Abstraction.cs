using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP
{
    internal class Abstraction
    {

        //public static void Main(string[] args)
        //{

        //    /*

        //    // ===== this will throw an error as abstract class cannot instanciate object ====
        //    Animal animal = new Animal();

        //    */

        //    // Creating an object of class Dog
        //    Dog myDog = new Dog();
        //    myDog.makeSound();
        //}
    }

    abstract class Animal
    {
        public abstract void makeSound();

        public void sleep()
        {
            Console.WriteLine("Zzzz");
        }
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("I am dog and I am making sound !!");
        }
    }

}

