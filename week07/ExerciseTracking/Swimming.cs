using System;

using System.Globalization;

public class Swimming : Activity
{
    private double _laps;//Length of a lap in the lap pool is 50 meters.

    public Swimming(double laps, int date, double duration) : base(date, duration)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }
   

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _duration) * 60;
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
       
       return $"{finalDateString} Running ({_duration} min) - Distance {CalculateDistance():F1} miles, Speed {CalculateSpeed():F1} mph, Pace: {CalculatePace():F1} min per mile";
       
    }
}