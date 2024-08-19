using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class Cassidoo20240819_CalculateExecutionTimes
{
    public static List<Tuple<string, int>> CalculateExecutionTimes(List<Cassidoo20240819_Event> events)
    {
        var names = events.Select(e => e.Name).Distinct();

        return (
                from n in names
                let start = events.First(e => e.Name.Equals(n) && "start".Equals(e.Event)).Time
                let end = events.First(e => e.Name.Equals(n) && "end".Equals(e.Event)).Time
                select new Tuple<string, int>(n, end - start)
            ).ToList();
    }

    public record Cassidoo20240819_Event(string Name, int Time, string Event);
}