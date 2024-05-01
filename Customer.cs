using System.Dynamic;

namespace NewInsyProject;

public class Customer
{
    //This will help generate our ID and start from 1 when the constructor is invoked and will not be wiped since it is static.
    private static int autoIncrement = 1;
    
    //This is the Customer ID
    internal int Customer_ID {get;}

    //This is the Customer Name
    internal string Customer_Name {get; set;}

    //This is the Customer Email
    internal string Customer_Email {get; set;}

    //This is the Customer's Phone Number
    internal string Customer_PhoneNumber {get; set;}

    //This is a list where customer info will be stored at.
    public static List <Customer> customerList{get; set;}

    
    //This is a constructor and will be able to be accessed from the main method or another class, and it will keep on generating an ID different from each customer

    public Customer(string name, string email, string phoneNumber)
    {
        Customer_ID = autoIncrement++;
        Customer_Name = name;
        Customer_Email = email;
        Customer_PhoneNumber = phoneNumber;
    }

//This initializes the static customer list before any instances of the Customer class are created or accessed.
//This ensures that the customerList is ready for use when needed.
    static Customer()
    {
        customerList = new List<Customer>();
    }

//This method allows the user to add in a customer to the customerlist
    public static void AddCustomer(Customer customer)
    {
        customerList.Add(customer);
    }

//This method allows the user to remove a customer from the customerlist
    public static void RemoveCustomer(int customerId)
    {
        //This finds the specific customer id with the entered customer ID from the user. If the ID is not found it will allow the user to know, but if found, it will remove them.
        var customerToRemove = customerList.Find(c => c.Customer_ID == customerId);
        if (customerToRemove != null)
        {
            customerList.Remove(customerToRemove);
            Console.WriteLine($"Customer with ID {customerId} has been removed.");
        }
        else
        {
            Console.WriteLine($"Customer with ID {customerId} not found.");
        }
    }

//This method prints out the customer list, and prints out specific customer information that was stored when the user first added in the customer from the "addcustomer" method.
    public static void PrintCustomerList()
    {
        Console.WriteLine("Customer List:");
        foreach(var customer in customerList)
        {
            Console.WriteLine($"ID: {customer.Customer_ID}, Name: {customer.Customer_Name}, Email: {customer.Customer_Email}, Phone Number: {customer.Customer_PhoneNumber}");
        }
    }

    
}
