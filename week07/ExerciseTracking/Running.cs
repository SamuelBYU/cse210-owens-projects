using System;

using System.Globalization;

public class Running : Activity
{
    private double _distance;

    public Running(double distance, int date, double duration) : base(date, duration)
    {
        _distance = distance;
    }

    
   

    public override double CalculateSpeed()
    {
        return (_distance / _duration) * 60;
    }
   

    public override double CalculatePace()
    {
        return _duration / _distance;
    }

    public override string Summary()
    {
       string tempString = _date.ToString();
       DateTime parsedDate = DateTime.ParseExact(tempString, "yyyyMMdd", CultureInfo.InvariantCulture);
       string finalDateString = parsedDate.ToString(" dd MMM yyyy", CultureInfo.InvariantCulture);
       
       return $"{finalDateString} Running ({_duration} min) - Distance {_distance:F1} miles, Speed {CalculateSpeed():F1} mph, Pace: {CalculatePace():F1} min per mile";
    }
}