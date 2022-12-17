using OOPSDemo.Abstraction;
using OOPSDemo.Inheritance;
using OOPSDemo.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPS Concept");
            Console.WriteLine("1.Inheritance\n2.Abstraction\n3.Method Ovreriding\n4.Method OVerLoading\n5.Encapsulation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Vehicle v = new Vehicle();
                    v.brand = "BMW";
                    v.price = 2345670;
                    v.VehicleDtails();
                                  
                    Car c = new Car();
                    c.brand = "Ford";
                    c.price = 175670;
                    c.VehicleDtails();
         
                    Bike b= new Bike();
                    b.brand = "FZ";
                    b.price = 95000;
                    b.VehicleDtails();
                    break;

                case 2:
                    Pig pig = new Pig();
                    pig.AnimalSound();
                    pig.Sleep();
                    break;

                case 3:
                    Animal1 animal1 = new Animal1();
                    animal1.Run();
                    Dog dog = new Dog();
                    dog.Run();
                    break;

                case 4:
                    Addition addition = new Addition();
                    Console.WriteLine("Sum: "+addition.Add(10,20));
                    Console.WriteLine("Sum: " +addition.Add(5,35,87));
                    Console.WriteLine("Sum: " +addition.Add(10,50.12f,20));
                    break;
                
                case 5:
                    Account account = new Account();
                    Console.WriteLine("before:"+account.Name);
                    account.Name = "abcd";
                    Console.WriteLine("after:\n"+account.Name);
                    break;
                  
               default:
                    Console.WriteLine("Please Choose the number within given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
