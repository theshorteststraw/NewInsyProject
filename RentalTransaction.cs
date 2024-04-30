namespace NewInsyProject;

public class RentalTransaction
{
    public int Id { get; set; }

    public Customer Customer { get; set; }

    public Vehicle Vehicle { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime ReturnDate { get; private set; }
}
