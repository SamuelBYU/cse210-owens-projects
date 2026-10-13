using System;

using System.Globalization;
public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, int date, double duration) : base(date, duration)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * _duration / 60;
    }

   

    public override double CalculatePace()
    {
        return _duration / CalculateDistance();
    }

    public override string Summary()
    {
       string tempString = _date.ToString();
       DateTime parsedDate = DateTime.ParseExact(tempString, "yyyyMMdd", CultureInfo.InvariantCulture);
       string finalDateString = parsedDate.ToString(" dd MMM yyyy", CultureInfo.InvariantCulture);
       
       return $"{finalDateString} Running ({_duration} min) - Distance {CalculateDistance():F1} miles, Speed {_speed:F1} mph, Pace: {CalculatePace():F1} min per mile";
       
    }
}