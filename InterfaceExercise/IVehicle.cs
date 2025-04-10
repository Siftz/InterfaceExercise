namespace InterfaceExercise;

public interface IVehicle
{
    //define some properties
    int NumberOfWheels{get;set;}
    int HorsePower{get;set;}
    string FuelType{get;set;}
    bool HasSunroof{get;set;}
    
    void DisplayDetails(); // stubbed method
}