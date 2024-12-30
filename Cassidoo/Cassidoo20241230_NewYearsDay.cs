using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class Cassidoo20241230_NewYearsDay
{
    public static string NewYearsDay(int year) => new DateOnly(year, 1, 1).DayOfWeek.ToString();
}