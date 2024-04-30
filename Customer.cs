using System.Dynamic;

namespace NewInsyProject;

public class Customer
{
    //This will help generate our ID when the constructor is invoked and will not be wiped since it is static.
    private static int autoIncrement;
    
    //This is the Customer ID
    public int Customer_ID {get;}

    //This is the Customer Name
    public string Customer_Name {get; set;}

    //This is the Customer Email
    public string Customer_Email {get; set;}

    //This is the Customer's Phone Number
    public string Customer_PhoneNumber {get; set;}

    public List <Customer> customerList{get; set;}

    
    //This is a constructor and will be able to be accessed from the main method or another class, and it will keep on generating an ID different from each customer
    public Customer() 
    {
        autoIncrement++;
        Customer_ID = autoIncrement;
        customerList = new List<Customer>();
    }

    
}
