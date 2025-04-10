namespace InterfaceExercise;
using System;
public class SUV : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; } = 4;
    public string FuelType { get; set; }
    public int HorsePower { get; set; }
    public bool HasSunroof { get; set; }

    public string Name { get; set; }
    public string Logo { get; set; }

    public int NumberOfSeats { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"SUV - {Name} ({Logo})\nWheels: {NumberOfWheels}, Fuel: {FuelType}, HP: {HorsePower}, Sunroof: {HasSunroof}, Seats: {NumberOfSeats}\n");
    }
}