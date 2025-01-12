using System;

namespace ConsoleApp
{
    #region Class and Objects Explanation
    // The Car class includes an explanation of what classes and objects are
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving!");
        }

        // Method to explain what a class and an object are
        public void ExplainClassAndObject()
        {
            Console.WriteLine("What is a Class?");
            Console.WriteLine("A class is a blueprint or template for creating objects. It defines the properties (data) and methods (behavior) that the objects will have.");
            Console.WriteLine();

            Console.WriteLine("What is an Object?");
            Console.WriteLine("An object is an instance of a class. It is created using the class as a template, and it holds specific data while allowing access to the class's methods.");
            Console.WriteLine();

            Console.WriteLine("Example in the context of this Car class:");
            Console.WriteLine("- The 'Car' class defines properties such as Brand, Model, and Year, and a method named Drive.");
            Console.WriteLine("- An object of the 'Car' class represents a specific car, such as a Toyota Corolla made in 2020.");
        }
    }
    #endregion

    #region Object Oriented Programming Concepts
    // 1. Encapsulation: Define a Person class with private fields and public properties
    public class Person
    {
        private string name; // Private field
        private int age;     // Private field

        // Public property with getter and setter for name
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        // Public property with getter and setter for age
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
    }

    // 2. Inheritance: Define a base class Vehicle and a derived class Car
    public class Vehicle
    {
        public void Start() => Console.WriteLine("Vehicle is starting...");
    }

    public class Car : Vehicle
    {
        public void Drive() => Console.WriteLine("Car is driving...");
    }

    // 3. Polymorphism: Use method overriding to show different behaviors
    public class Animal
    {
        public virtual void Speak() => Console.WriteLine("Animal makes a sound");
    }

    public class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Dog barks");
    }

    public class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Cat meows");
    }

    // 4. Abstraction: Use an abstract class for shapes
    public abstract class Shape
    {
        public abstract void Draw(); // Abstract method
    }

    public class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing a circle");
    }

    public class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing a rectangle");
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Car class
            Car carExample = new Car();
            carExample.Brand = "Toyota";
            carExample.Model = "Corolla";
            carExample.Year = 2020;

            // Call the explanation method to display the explanation
            carExample.ExplainClassAndObject();

            // Print OOP Pillars Explanations

            Console.WriteLine("1. Encapsulation:");
            Console.WriteLine("Encapsulation is the concept of bundling the data (fields) and the methods that operate on the data into a single unit (a class).");
            Console.WriteLine("It also involves restricting direct access to some of the object's components to maintain control and security.");
            Console.WriteLine("Example: The Person class has private fields for Name and Age, which can only be accessed or modified through public properties.");
            Console.WriteLine();

            // 1. Encapsulation Example: Create a Person object and set its properties
            Person person = new Person();
            person.Name = "John";
            person.Age = 30;
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            Console.WriteLine();

            Console.WriteLine("2. Inheritance:");
            Console.WriteLine("Inheritance allows a class (child class) to inherit the properties and methods of another class (parent class).");
            Console.WriteLine("It promotes code reuse and establishes a hierarchical relationship between classes.");
            Console.WriteLine("Example: The Car class inherits the Start method from the Vehicle class.");
            Console.WriteLine();

            // 2. Inheritance Example: Demonstrate Vehicle and Car
            Car car = new Car();
            car.Start(); // From Vehicle class
            car.Drive(); // From Car class
            Console.WriteLine();

            Console.WriteLine("3. Polymorphism:");
            Console.WriteLine("Polymorphism allows methods in different classes to be called through the same interface.");
            Console.WriteLine("It means 'one interface, many implementations'.");
            Console.WriteLine("Example: The Dog and Cat classes override the Speak method, demonstrating different behaviors.");
            Console.WriteLine();

            // 3. Polymorphism Example: Demonstrate method overriding
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Speak();
            cat.Speak();
            Console.WriteLine();

            Console.WriteLine("4. Abstraction:");
            Console.WriteLine("Abstraction is the process of hiding the implementation details and exposing only the essential features of an object.");
            Console.WriteLine("It focuses on 'what' an object does rather than 'how' it does it.");
            Console.WriteLine("Example: The Shape class is abstract, and we have Circle and Rectangle classes that provide specific implementations of the Draw method.");
            Console.WriteLine();

            // 4. Abstraction Example: Demonstrate drawing shapes
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();
            circle.Draw();
            rectangle.Draw();
        }
    }
}