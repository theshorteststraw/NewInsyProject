namespace NewInsyProject;

public class Customers
{
    public List<Customers> customerList { get; set; }

    public Customers()
    {
        customerList = new List<Customers>();

    }

    public Customer Authenticate (string username, string password)
    {
        var c = customerList.Where(o => (o.Username == username) && (o.Password == password));
        if(c.count()>0)
        {
            return c.First();

        }
        else
        {
            return null;
        }
        
    }

}
