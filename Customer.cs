namespace NewInsyProject;

public class Customer
{
 public Customer c { get; set; }
    public Appointment a { get; set; }
    
    public Customer(Customer c, Appointment a)
    {
        this.c = c;
        this.a = a;
    }
}
