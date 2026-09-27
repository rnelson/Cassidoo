namespace Cassidoo;

public static class Cassidoo20260921_GetSundays
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260921.cs
    public static IEnumerable<string> GetSundays(int year, int month)
    {
        return Enumerable
            .Range(0, 1 + DateTime.DaysInMonth(year, month))
            .Select(new DateOnly(year, month, 1).AddDays)
            .Where(d => d.DayOfWeek == DayOfWeek.Sunday)
            .Select(d => d.ToString("yyyy-MM-dd"));
    }
}
