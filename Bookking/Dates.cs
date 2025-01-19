namespace Bookking;

public class Dates
{
    int startDate;
    int endDate;
    private int month;

    public int StartDate
    {
        get { return startDate; }
        set
        {
            if (value < 1 && value > 31)
            {
                Console.WriteLine("Invalid start date");
            }
            else
            {
                startDate = value;
            }
        }
    }

    public int EndDate
    {
        get { return endDate; }
        set
        {
            if (value < 1 && value > 31)
            {
                Console.WriteLine("Invalid end date");
            }
            else
            {
                endDate = value;
            }
        }
    }
    
    public int Month
    {
        get => month;
        set => month = value;
    }

    public Dates(int startDate = 0, int endDate = 0, int month = 0)
    {
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.Month = month;
        
    }
    
    public int checkStartDate()
    {
        int datesDays = StartDate;
        return datesDays;
    }

    public int checkEndDate()
    {
        int datesDays = EndDate;
        return datesDays;
    }
    
    public int checkDatesMonth()
    {
        int datesMonth = Month;
        return datesMonth;
    }

    public void setStartDate(int startDate)
    {
        this.StartDate = startDate;
    }

    public void setEndDate(int endDate)
    {
        this.EndDate = endDate;
    }

    public void setMonth(int month)
    {
        this.Month = month;
    }
}