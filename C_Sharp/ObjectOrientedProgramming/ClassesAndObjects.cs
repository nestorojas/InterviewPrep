using System;

namespace ClassesAndObjectsNamespace
{
    // 1. What is a Class?
    // A class is a blueprint for creating objects. It defines properties (data) and methods (behavior).
    public class Car
    {
        // Properties (fields/data)
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor: Initializes a new instance of the Car class
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Method (behavior): Defines what the car can do
        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving!");
        }

        // Destructor: Cleans up when the object is no longer needed (called by the garbage collector)
        ~Car()
        {
            Console.WriteLine($"The {Brand} {Model} object is being destroyed.");
        }
    }

    // 2. What is an Object?
    // An object is an instance of a class. You create objects from classes, which hold actual data.
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the Car class
            Car myCar = new Car("Toyota", "Corolla", 2020);

            // Accessing properties
            Console.WriteLine($"Brand: {myCar.Brand}, Model: {myCar.Model}, Year: {myCar.Year}");

            // Calling method on the object
            myCar.Drive();

            // Objects will be automatically cleaned up by garbage collector when no longer in use.
        }
    }

    // 3. Access Modifiers: Public, Private, Protected, Internal
    // Example of encapsulation: Using private fields and public properties to control access.
    public class Person
    {
        // Private field (cannot be accessed directly outside the class)
        private string name;

        // Public property (can be accessed from outside the class)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor with access modifier
        public Person(string name)
        {
            Name = name;
        }
    }

    // 4. Instance vs. Static Members
    // Instance members belong to a specific object, while static members belong to the class itself.
    public class Counter
    {
        // Static member: Shared among all instances of the class
        public static int Count = 0;

        // Instance member: Unique to each instance of the class
        public int InstanceCount = 0;

        public Counter()
        {
            // Incrementing the static variable (shared by all objects)
            Count++;

            // Incrementing the instance variable (unique to each object)
            InstanceCount++;
        }

        public void ShowCounts()
        {
            Console.WriteLine($"Static Count: {Count}, Instance Count: {InstanceCount}");
        }
    }

    // 5. Example to demonstrate Instance vs. Static
    public class InstanceStaticExample
    {
        static void Main(string[] args)
        {
            // Creating instances of Counter class
            Counter counter1 = new Counter();
            Counter counter2 = new Counter();

            // Display the counts
            counter1.ShowCounts(); // Static Count: 2, Instance Count: 1
            counter2.ShowCounts(); // Static Count: 2, Instance Count: 1
        }
    }
}