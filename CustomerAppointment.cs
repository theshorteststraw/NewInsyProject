namespace NewInsyProject;

public class Vehicle //declares the Vehicle class
{

    private string VehicleID; //creates variable for VehicleID. private to prevent unauthorized changes
    private string Model; //creates variable for the vehicle's Model (i.e. Sienna, F-150). private for protection
    private string Make; //creates variable for the vehicle's Make (i.e. Toyota, Ford). private for protection
    private int Year; //creates variable for the Year (edition) of the Vehicle. private for protection
    private bool isAvailable; //creates a bool var for the availability of the vehicle. private for protection
    private float rentRate; //creates a float var for the daily price of renting the vehicle. private for protection

    public Vehicle(string ID, string vehiclemodel, string vehiclemake, int yr, bool availability, float dailyRate) /* Vehicle constructor for
    creation of new Vehicle. Includes all the necessary features of the Vehicle*/
    {
        vehicleID = ID; //assigns ID as the vehicleID value
        model = vehiclemodel; //assigns vehiclemodel as the model value
        make = vehiclemake; //assigns vehiclemake as the make value
        year = yr; //assigns yr as the year value
        isavailable = availability; //assigns availability as the isavailable value
        rentrate = dailyRate; //assigns dailyRate as the rentrate value
    }

    public string vehicleID{get;} //getter for VehicleID. no setter because ID never changes. can only retrieve ID
    
    public string model{get;} //getter for Model. no setter because Model never changes. can only retrieve Model

    public string make{get;} //getter for Make. no setter because Make never changes. can only retrieve Make

    public int year{get;} //getter for Year. no setter because Year never changes. can only retrieve Year

    public bool isavailable{get;set;} /*getter and setter for availability. can retrieve (i.e. customer wants to know if the 2004 
    Toyota Sienna is available) and set by the employees (i.e. if 2004 Toyota Sienna was just returned, employee can mark as 
    available so customers can rent it out) */

    public float rentrate{get;set;} /* getter and setter for rentRate. get is necessary to show customers current price. set
    is for when employees need to change the price to adjust for inflation and whatnot */

}
