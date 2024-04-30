namespace NewInsyProject;

public class CustomerAppointment
{
    public Customer c {get; set;}

    public Appointment a {get; set;}

    public CustomerAppointment(Customer c, CustomerAppointment a)
    {
        this.c = c;
        this.a = a;
    }
}
