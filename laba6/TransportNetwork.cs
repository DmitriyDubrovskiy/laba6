// Клас TransportNetwork
public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void MoveAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public string CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        // Додайте логіку розрахунку оптимального маршруту тут
        return $"Optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}.";
    }

    public void PassengerBoardingAndDisembarking(Vehicle vehicle, int passengers)
    {
        Console.WriteLine($"Boarding {passengers} passengers onto {vehicle.GetType().Name}.");
        // Додайте логіку посадки та висадки пасажирів тут
    }
}