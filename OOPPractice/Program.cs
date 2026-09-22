using System;

// Class 1
class Car
{
    public string Brand;
    public int Speed;

    public Car(string brand)
    {
        Brand = brand;
        Speed = 0;
    }

    public void Accelerate()
    {
        Speed += 10;
        Console.WriteLine($"{Brand} speed: {Speed}");
    }
}

// Class 2
class Student
{
    public string Name;
    public int Marks;

    public void ShowResult()
    {
        Console.WriteLine($"{Name} scored {Marks} marks");
    }
}

// Main Program (Entry point)
class Program
{
    static void Main(string[] args)
    {
        // Object of Car
        Car car1 = new Car("Honda");
        car1.Accelerate();

        // Object of Student
        Student s1 = new Student();
        s1.Name = "Rahul";
        s1.Marks = 85;
        s1.ShowResult();
    }
}