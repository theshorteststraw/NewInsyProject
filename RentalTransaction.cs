namespace NewInsyProject;

public class RentalTransaction
{
    //Creates a list to store Rental Transaction information
    public static List<RentalTransaction> rentalTransactionList = new List<RentalTransaction>();

    //Creating required varibles as internal and creating getters for them
    internal int Id { get;}
    internal Customer Customer { get;}
    internal Vehicle Vehicle { get;}
    internal DateTime StartDate { get;}
    internal DateTime EndDate { get;}
    
    //Creating a varible as internal and the ? allows it to hold null values 
    internal DateTime? ReturnDate { get;set;}

    //Creating an autoIncrement as an integer that sets the ID 
    private static int autoIncrement = 1;

    //Creating a constructor for rental Transaction
    public RentalTransaction(Customer customer, Vehicle vehicle, DateTime startDate, DateTime endDate)
    {
        //Setting the ID to the autoIncrement and increasing by 1 everytime a rental Transaction is a made
        Id = autoIncrement++;
        
        //Setting varibles to thier corresponding values
        Customer = customer;
        Vehicle = vehicle;
        StartDate = startDate;
        EndDate = endDate;

        //Setting the boolean statement that changes vehicles Availibility to false when it is rented out 
        vehicle.isAvailable = false;

        //Adds a rental transaction to the list
        rentalTransactionList.Add(this);
    }

    //Creating a method for rentVehicle under the rental transaction constructor
    public static RentalTransaction RentVehicle(Customer customer, Vehicle vehicle, DateTime startDate, DateTime endDate)
    {
        //Creating a new rental transaction object called transaction with customer, vehicle, start and end date as parameters
        RentalTransaction transaction = new RentalTransaction(customer, vehicle, startDate, endDate);
        return transaction;
    }

    //Creating a method that returns the vehicle and uses rentalTransaction and returnDate as parameters
    public static void ReturnVehicle(RentalTransaction rentalTransaction, DateTime returnDate)
    {
        //Updates return date of rental transaction with given return date
        rentalTransaction.ReturnDate = returnDate;

        //Setting the boolean statement that sets the vehicle availibilty back to true
        rentalTransaction.Vehicle.isAvailable = true;

        //Creating a print statement that returns Vehcile ID, Customer ID, and return date changing it into a string 
        Console.WriteLine($"Vehicle {rentalTransaction.Vehicle.VehicleID} has been returned by customer {rentalTransaction.Customer.Customer_ID} on {rentalTransaction.ReturnDate.Value.ToShortDateString()}.");
    }

    //Method that returns the list of rental transactions
    public static List<RentalTransaction> GetRentalTransactions()
    {
        return rentalTransactionList;
    }
}
