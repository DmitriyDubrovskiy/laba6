class Program
{
    static void Main()
    {
        // Приклад використання
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        TransportNetwork transportNetwork = new TransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        transportNetwork.MoveAllVehicles();

        Route route = new Route("City A", "City B");
        Console.WriteLine(transportNetwork.CalculateOptimalRoute(route, car));

        transportNetwork.PassengerBoardingAndDisembarking(bus, 20);
    }
}
