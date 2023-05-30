Car1 car1 = new Car1();
Car2 car2 = new Car2();

Adapter1 adapter1 = new Adapter1();
Adapter2 adapter2 = new Adapter2();

car1.Drive();
car2.Drive();
Console.WriteLine("\tAdapters");
adapter1.DriveCar();
adapter2.DriveCar();




class Adapter1 : Car1
{
    public void DriveCar()
    {
        this.Drive();
    }
}
class Adapter2
{
    Car2 car2 = new Car2();
    public void DriveCar()
    {
        car2.Drive();
    }
}
class Car1
{
    public void Drive()
    {
        Console.WriteLine("+20");
    }
}
class Car2
{
    public void Drive()
    {
        Console.WriteLine("+30");
    }
}