namespace NewInsyProject;

public class Vehicle
{

    private static int autoIncrement =1; //holds a value for VehicleID to start at and incrememnt from there
    internal int VehicleID{get;} //creates variable for VehicleID. internal to prevent unauthorized changes, but has getter for retrieval
    internal string Model{get;} //creates variable for the vehicle's Model (i.e. Sienna, F-150). internal for protection, but has getter for retrieval
    internal string Make{get;} //creates variable for the vehicle's Make (i.e. Toyota, Ford). internal for protection w/ getter for retrieval
    internal int Year{get;} //creates variable for the Year (edition) of the Vehicle. internal for protection w/ getter for retrieval
    internal bool isAvailable{get; set;} /*creates a bool var for the availability of the vehicle. internal for protection w/ getter for retrieval
    and setter for changing the availability as vehicles are checked in and out*/
    internal float rentRate{get; set;} /*creates a float var for the daily price of renting the vehicle. internal for protection w/ getter
    for retrieval and setter to change the price (reflecting the economy + inflation)*/

    public Vehicle(string vehiclemodel, string vehiclemake, int yr, bool availability, float dailyRate) /* Vehicle constructor for
    creation of new Vehicle. Includes all the necessary features of the Vehicle*/
    {
        VehicleID = autoIncrement++; //assigns ID as the vehicleID value that increments automatically
        Model = vehiclemodel; //assigns vehiclemodel as the model value
        Make = vehiclemake; //assigns vehiclemake as the make value
        Year = yr; //assigns yr as the year value
        isAvailable = availability; //assigns availability as the isavailable value
        rentRate = dailyRate; //assigns dailyRate as the rentrate value
    }

    public static List<Vehicle> vehicleList { get; set; } //a list storing existing vehicles in database
    static Vehicle() //Vehicle list constructor
    {
        vehicleList = new List<Vehicle>();
    }

    public static void AddVehicle(Vehicle vehicle) //method to add vehicles onto the vehicleList
    {
        vehicleList.Add(vehicle);
    }

     public static void RemoveVehicle(int vehicleID) //method to remove vehicles from the vehicleList
    {
        var vehicleToremove = vehicleList.Find(v => v.VehicleID == vehicleID); /*var that finds identifies a Vehicle in the vehicleList by its
        vehicleID. this part was made by ChatGPT, I believe Will will send include his prompt in a doc*/
        if (vehicleToremove != null)
        {
            vehicleList.Remove(vehicleToremove); //removes the identified Vehicle
            Console.WriteLine($"Vehicle with ID {vehicleID} has been removed."); //display message to notify user that Vehicle was removed
        }
        else
        {
            Console.WriteLine($"Vehicle with ID {vehicleID} not found."); /*tells user that no Vehicle with that vehicleID exists,
            and therefore the vehicle can't be removed*/
        }
    }

    public static void PrintVehicleList() //method to print out vehicleList
    {
        Console.WriteLine("Vehicle List:"); //prints the title "Vehicle List"
        foreach (var vehicle in vehicleList) //prints out the following statistics for every Vehicle in the vehicleList
        {
            Console.WriteLine($"ID: {vehicle.VehicleID}, Model: {vehicle.Model}, Make: {vehicle.Make}, Year: {vehicle.Year}, Avalibility: {vehicle.isAvailable}, Daily Rate: {vehicle.rentRate}");
        }
    }

}   
