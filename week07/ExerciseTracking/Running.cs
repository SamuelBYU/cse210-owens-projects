using System;

using System.Globalization;

public class Running : Activity
{
    private int _distance;

    public Running(int distance, int date, int duration) : base(date, duration)
    {
        _distance = distance;
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
       string finalDateString = parsedDate.ToString(" dd MMM yyyy", CultureInfo.InvariantCulture);
       
       return $"{finalDateString}";
    }
}