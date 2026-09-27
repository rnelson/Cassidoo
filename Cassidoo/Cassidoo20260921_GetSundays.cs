namespace Cassidoo;

public static class Cassidoo20260921_GetSundays
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260921.cs
    public static IEnumerable<string> GetSundays(int year, int month)
    {
        var daysInMonth = DateTime.DaysInMonth(year, month);
        var start = new DateOnly(year, month, 1);
        var end = new DateOnly(year, month, daysInMonth);
        
        var days = Enumerable.Range(0, 1 + daysInMonth).Select(start.AddDays).ToArray();
        var sundays = days.Where(d => d.DayOfWeek == DayOfWeek.Sunday).ToArray();
        
        return sundays.Select(d => d.ToString("yyyy-MM-dd"));
    }
}
