namespace NewInsyProject;

public class Program
{

    static void Main(string[] args)
    {

        //Main menu for the user to interact with put into a loop so it contines until the user wants to quit
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Remove customer");
            Console.WriteLine("3. Print list of customers");
            Console.WriteLine("4. Add vehicle");
            Console.WriteLine("5. Remove vehicle");
            Console.WriteLine("6. Print list of vehicles");
            Console.WriteLine("7. Rent a vehicle");
            Console.WriteLine("8. Return a vehicle");
            Console.WriteLine("9. View rental information");
            Console.WriteLine("10. See options");
            Console.WriteLine("11. Quit");

            //Allowing user to enter a choice 
            Console.Write("\nEnter your choice: ");
            int choice;
            
            //If it is unable to be turned into an int it will print a error message
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            //Switch statment based on the users choice to perform the correct method
            switch (choice)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    RemoveCustomer();
                    break;
                case 3:
                    PrintCustomerList();
                    break;
                case 4:
                    AddVehicle();
                    break;
                case 5:
                    RemoveVehicle();
                    break;
                case 6:
                    PrintVehicleList();
                    break;
                case 7:
                    RentVehicle();
                    break;
                case 8:
                    ReturnVehicle();
                    break;
                case 9:
                    ViewRentalInformation();
                    break;
                case 10:
                    break;
                //if user wishes to quit
                case 11:
                    Console.WriteLine("Exiting program...");
                    return;
                //For any input that is not corresponding with a case
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 11.");
                    break;
            }
        }
    }

    //Add customer method that adds a customer and its info into a list based on the users input(calls from customer class)
    static void AddCustomer()
    {
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine();
        Console.Write("Enter customer email: ");
        string email = Console.ReadLine();
        Console.Write("Enter customer phone number: ");
        string phoneNumber = Console.ReadLine();

        //Adding customer to list
        Customer customer = new Customer(name, email, phoneNumber);
        Customer.AddCustomer(customer);
        Console.WriteLine("Customer added successfully.");
    }

    //Remove customer method that removes customer from the list based on the customers id(calls from customer class)
    static void RemoveCustomer()
    {
        Console.Write("Enter customer ID to remove: ");
        
        //Turning user input into a int and checking if ID exists 
        if (!int.TryParse(Console.ReadLine(), out int customerId))
        {
            Console.WriteLine("Invalid customer ID.");
            return;
        }

        Customer.RemoveCustomer(customerId);
    }

    //Print list of customers(calls method from Customer class)
    static void PrintCustomerList()
    {
        Customer.PrintCustomerList();
    }

    //Add Vehicle method that adds a vehicle and its info into a list based on the users input(calls from Vehicle class)
    static void AddVehicle()
    {
        Console.Write("Enter vehicle model: ");
        string model = Console.ReadLine();
        Console.Write("Enter vehicle make: ");
        string make = Console.ReadLine();
        Console.Write("Enter vehicle year: ");
        
        //Checking to see if it is a valid year 
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Invalid year.");
            return;
        }
        
        //Checking to see if either ture of false is entered
        Console.Write("Enter vehicle availability (true/false): ");
        if (!bool.TryParse(Console.ReadLine(), out bool availability))
        {
            Console.WriteLine("Invalid availability.");
            return;
        }
        
        //Checking to see if the user input is able to be changed into a float
        Console.Write("Enter vehicle daily rate: ");
        if (!float.TryParse(Console.ReadLine(), out float dailyRate))
        {
            Console.WriteLine("Invalid daily rate.");
            return;
        }

        Vehicle vehicle = new Vehicle(model, make, year, availability, dailyRate);
        Vehicle.AddVehicle(vehicle);
        Console.WriteLine("Vehicle added successfully.");
    }

    //Remove Vehicle method that removes vehicle from the list based on the vehicles id(calls from vehicle class)
    static void RemoveVehicle()
    {
        //Checking to see if a valid vehicle ID is Entered 
        Console.Write("Enter vehicle ID to remove: ");
        if (!int.TryParse(Console.ReadLine(), out int vehicleId))
        {
            Console.WriteLine("Invalid vehicle ID.");
            return;
        }

        Vehicle.RemoveVehicle(vehicleId);
    }

    //Print list of vehicles (Calls from vehicle class)
    static void PrintVehicleList()
    {
        Vehicle.PrintVehicleList();
    }

    //Rent a vehicle method that rents a vehicle based on user inputs(Calls from rental transaction class)
    static void RentVehicle()
    {
        Console.WriteLine("\nRent a vehicle:");
        Console.Write("Enter customer ID: ");
        
        //Checking to see if it is a valid customer ID
        if (!int.TryParse(Console.ReadLine(), out int customerId))
        {
            Console.WriteLine("Invalid customer ID.");
            return;
        }

        // Finding the customer Id and checking to see if it exists 
        Customer customer = Customer.customerList.Find(c => c.Customer_ID == customerId);
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        Console.Write("Enter vehicle ID: ");
        
        //Checking to see if it is a valid vehicle ID
        if (!int.TryParse(Console.ReadLine(), out int vehicleId))
        {
            Console.WriteLine("Invalid vehicle ID.");
            return;
        }

        //Finding Vehicle ID and checking to see if it exists 
        Vehicle vehicle = Vehicle.vehicleList.Find(v => v.VehicleID == vehicleId);
        if (vehicle == null)
        {
            Console.WriteLine("Vehicle not found.");
            return;
        }

        Console.Write("Enter start date (yyyy-MM-dd): ");

        //Checking to see if a valid start date is entered 
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
        {
            Console.WriteLine("Invalid start date.");
            return;
        }

        Console.Write("Enter end date (yyyy-MM-dd): ");
        
        //checking to see if a valid end date is entered 
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
        {
            Console.WriteLine("Invalid end date.");
            return;
        }

        //Rents vehicle by calling method 
        RentalTransaction transaction = RentalTransaction.RentVehicle(customer, vehicle, startDate, endDate);
        Console.WriteLine($"Vehicle rented successfully. Transaction ID: {transaction.Id}");
    
    }

    //Return a vehicle method that returns a vehicle based on user inputs(Calls from rental transaction class)
    static void ReturnVehicle()
    {

        Console.WriteLine("\nReturn a vehicle:");
        Console.Write("Enter transaction ID: ");
        
        //Checking to see if valid Id was entered 
        if (!int.TryParse(Console.ReadLine(), out int transactionId))
        {
            Console.WriteLine("Invalid transaction ID.");
            return;
        }

        //Finding transaction ID and checking to see if it exists
        RentalTransaction transaction = RentalTransaction.rentalTransactionList.Find(t => t.Id == transactionId);
        if (transaction == null)
        {
            Console.WriteLine("Transaction not found.");
            return;
        }

        Console.Write("Enter return date (yyyy-MM-dd): ");
        
        //Checking to see if a valid return date was entered 
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime returnDate))
        {
            Console.WriteLine("Invalid return date.");
            return;
        }

        //Returns vehicle
        RentalTransaction.ReturnVehicle(transaction, returnDate);
    }


    
    

    //View Rental information method that prints the list of all existing rental transactions(Calls from rental transaction class)
    static void ViewRentalInformation()
    {
        Console.WriteLine("\nView all rental transactions:");

        //Grabs all rental transactions from rental transaction list
        List<RentalTransaction> rentalTransactions = RentalTransaction.GetRentalTransactions();

        //Checks to see if at least one exists 
        if (rentalTransactions.Count == 0)
        {
            Console.WriteLine("No rental transactions found.");
            return;
        }

        //Displays details of each rental transaction
        foreach (var transaction in rentalTransactions)
        {
            Console.WriteLine($"Transaction ID: {transaction.Id}");
            Console.WriteLine($"Customer ID: {transaction.Customer.Customer_ID}");
            Console.WriteLine($"Vehicle ID: {transaction.Vehicle.VehicleID}");
            Console.WriteLine($"Start Date: {transaction.StartDate}");
            Console.WriteLine($"End Date: {transaction.EndDate}");
            Console.WriteLine($"Return Date: {transaction.ReturnDate}");
            Console.WriteLine();
        }

    }


}
