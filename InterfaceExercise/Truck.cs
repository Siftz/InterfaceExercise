namespace InterfaceExercise;
using System;
public class Truck : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; } = 6;
    public string FuelType { get; set; }
    public int HorsePower { get; set; }
    public bool HasSunroof { get; set; }

    public string Name { get; set; }
    public string Logo { get; set; }

    public double BedSize { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Truck - {Name} ({Logo})\nWheels: {NumberOfWheels}, Fuel: {FuelType}, HP: {HorsePower}, Sunroof: {HasSunroof}, Bed Size: {BedSize} ft\n");
    }
}