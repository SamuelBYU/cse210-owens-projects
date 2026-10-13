using System;

using System.Globalization;
public class Cycling : Activity
{
    private int _speed;

    public Cycling(int speed, int date, int duration) : base(date, duration)
    {
        _speed = speed;
    }

    public override int CalculateDistance()
    {
        return 0;
    }
   

    public override int CalculateSpeed()
    {
        return 0;
    }
   

    public override int CalculatePace()
    {
        return 0;
    }

    public override string Summary()
    {
       string tempString = _date.ToString();
       DateTime parsedDate = DateTime.ParseExact(tempString, "yyyyMMdd", CultureInfo.InvariantCulture);
       string finalDateString = parsedDate.ToString(" MMMM dd, yyyy", CultureInfo.InvariantCulture);
       return Console.WriteLine($"{finalDateString}");
    }
}