namespace Bookking;

public class Customer
{
    string firstName;
    string lastName;
    int telephone;

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
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

    public void setFirstName(string firstName)
    {
        this.FirstName = firstName;
    }

    public void setLastName(string lastName)
    {
        this.LastName = lastName;
    }

    public void setTelephone(int telephone)
    {
        this.Telephone = telephone;
    }

    public override string ToString()
    {
        return "Customer Details:" + "\nFirstname: " + FirstName + "\nLastname: " + LastName + "\nTelephone: " + Telephone;
    }
}