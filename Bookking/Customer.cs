namespace Bookking;

public class Customer
{
    string firstName;
    string lastName;
    int telephone;

    public string FirstName
    {
        get => firstName;
        set => firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Telephone
    {
        get => telephone;
        set => telephone = value;
    }

    public Customer(string firstName = default, string lastName = default, int telephone = 0)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Telephone = telephone;
    }
}