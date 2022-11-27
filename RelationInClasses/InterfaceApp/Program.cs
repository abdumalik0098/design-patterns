Car car = new Car();
car.Move();

interface IMovable
{
    void Move();
}

class Car:IMovable
{
    public void Move()
    {
        Console.WriteLine("Car speed 60 km/m");
    }
}