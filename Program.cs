static void Main(string[] args)
{}
interface IDriveable
{
    void Move();
    void Stop();
}

class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes { get; set; }
    public int TrafficLevel { get; set; }
}

class Vehicle : IDriveable
{
    public double Speed { get; set; }
    public double Size { get; set; }
    public VehicleType Type { get; set; }

    public void Move()
    {
        // Логіка руху транспортного засобу
        Console.WriteLine($"{Type} is moving.");
    }

    public void Stop()
    {
        // Логіка зупинки транспортного засобу
        Console.WriteLine($"{Type} has stopped.");
    }
}

enum VehicleType
{
    Car,
    Truck,
    Bus
}

class TrafficSimulator
{
    public List<Road> Roads { get; set; }
    public List<Vehicle> Vehicles { get; set; }

    public void Simulate()
    {
        // Цикл імітації
        foreach (var vehicle in Vehicles)
        {
            // Вибір дороги
            // Перевірка умов руху (швидкість, трафік, перешкоди)
            vehicle.Move();
        }
    }
}
   