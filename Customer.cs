using System.Dynamic;

namespace NewInsyProject;

public class Customer
{
    //This will help generate our ID when the constructor is invoked and will not be wiped since it is static.
    private static int autoIncrement;
    
    //This is the Customer ID
    public int Customer_ID {get;}

    //This is the Customer Name
    private string Customer_Name {get; set;}

    //This is the Customer Email
    private string Customer_Email {get; set;}

    //This is the Customer's Phone Number
    private string Customer_PhoneNum {get; set;}

    
    //This is a constructor and will be able to be accessed from the main method or another class, and it will keep on generating an ID different from each customer
    public Customer() 
    {
        autoIncrement++;
        Customer_ID = autoIncrement;
    }
    
    
}
