using System.Dynamic;

namespace NewInsyProject;

public class Customer
{
    //This is the Customer ID
    private int Customer_ID; 

    //This is the Customer Name
    private string Customer_Name;

    //This is the Customer Email
    private string Customer_Email;

    //This is the Customer's Phone Number
    private string Customer_PhoneNum;

    
    //This is a constructor and will be able to be accessed from the main method or another class
    public Customer(int Customer_ID, string Customer_Name, string Customer_Email, string Customer_PhoneNum) 
    {
        this.Customer_ID = Customer_ID;
        this.Customer_Name = Customer_Name;
        this.Customer_Email = Customer_Email;
        this.Customer_PhoneNum=Customer_PhoneNum;
    }

    //This gives access to see the customer ID.
    public int customer_ID
    {
        get
        {
            return Customer_ID;
        }

    }

    //This gives access to see the customer name, and can also be modified.
    public string customer_Name
    {
        get
        { 
            return Customer_Name;
        }
        set
        {
            Customer_Name = value;
        }
    }

    //This gives access to see the customer email, and can also be modified.
    public string customer_Email
    {
        get
        { 
            return Customer_Email;
        }
        set
        {
            Customer_Email = value;
        }
    }

    //This gives access to see the customer phone number, and can also be modified.
    public string customer_PhoneNum
    {
        get
        {
            return Customer_PhoneNum;
        } 
        set
        {
            Customer_PhoneNum = value;
        }
    }
    
    
}
