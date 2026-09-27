using Cassidoo;

namespace Tests;

public class Tests20260921
{
    [Theory]
    [InlineData(2026, 9, new[]{"2026-09-06", "2026-09-13", "2026-09-20", "2026-09-27"})]
    [InlineData(2024, 2, new[]{"2024-02-04", "2024-02-11", "2024-02-18", "2024-02-25"})]
    public void Test(int year, int month, string[] expected)
    {
        var actual = Cassidoo20260921_GetSundays.GetSundays(year, month);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ dotnet test --filter FullyQualifiedName~Tests20260921 -v:detailed
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll

    Build succeeded in 1.0s
    Running tests from Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64)
    Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64) passed (937ms)

    Test run summary: Passed!
      total: 2
      failed: 0
      succeeded: 2
      skipped: 0
      duration: 1s 147ms
    [rnelson@roto cassidoo]$
 */
