using System;

public class Clock : IEquatable<Clock>
{
    private int _totalMinutes;

    public Clock(int hours, int minutes)
    {
        _totalMinutes = minutes + (hours * 60);
    }

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => Add(-minutesToSubtract);

    public int Hours
    {
        get
        {
            if (_totalMinutes < 0)
            {
                int hours = 24 + ((_totalMinutes / 60) % -24);
                return Minutes == 0 ? hours : hours - 1;
            }

            return ((_totalMinutes / 60) % 24);
        }
    }

    public int Minutes
    {
        get
        {
            if (_totalMinutes < 0)
            {
                return(60 + (_totalMinutes % -60)) % 60;
            }

            return _totalMinutes % 60;
        }
    }

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";

    public bool Equals(Clock clock)
    {
        return this.ToString() == clock.ToString();
    }
}