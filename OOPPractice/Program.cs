using System;

Car car1 = new Car("Honda");
car1.Accelerate();

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