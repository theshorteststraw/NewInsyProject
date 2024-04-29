using System.Dynamic;

namespace NewInsyProject;

public class Customer
{
    private int Customer_ID;
    private string Customer_Name;
    private string Customer_Email;
    private string Customer_PhoneNum;

    public Customer(int Customer_ID, string Customer_Name, string Customer_Email, string Customer_PhoneNum) 
    {
        this.Customer_ID = Customer_ID;
        this.Customer_Name = Customer_Name;
        this.Customer_Email = Customer_Email;
        this.Customer_PhoneNum=Customer_PhoneNum;
    }

    public int customer_ID{get;}
    public string customer_Name{get;set;}
    public string customer_Email{get; set;}
    public string customer_PhoneNum{get; set;}
    
    
}
