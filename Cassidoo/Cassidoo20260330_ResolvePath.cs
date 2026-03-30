using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20260330_ResolvePath
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260330.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static string? ResolvePath(Filesystem filesystem, string path) =>
        filesystem.Resolve(path);

    public class Filesystem
    {
        private readonly ConcurrentDictionary<Guid, List<string>> _overEngineering = new();
        private readonly Dictionary<string, string?> _paths = new();

        public void Add(string source, string? destination)
        {
            if (!_paths.TryAdd(source, destination))
                throw new ArgumentException("source already exists", nameof(source));
        }

        public string? Resolve(string path)
        {
            if (!_paths.TryGetValue(path, out var destination))
                throw new ArgumentException("path does not exist", nameof(path));

            if (destination is null)
                return path;
            
            var guid = Guid.NewGuid();
            _overEngineering[guid] = [path];
            
            return Resolve(path, path, guid);
        }

        private string? Resolve(string originalPath, string path, Guid guid)
        {
            while (true)
            {
                if (!_paths.TryGetValue(path, out var destination))
                {
                    _overEngineering.Remove(guid, out _);
                    throw new ArgumentException($"{originalPath} leads to {path}, which does not exist", nameof(path));
                }

                if (destination is null)
                {
                    _overEngineering.Remove(guid, out var pastBits);
                    return pastBits!.Last();
                }

                // Add this new path
                var bits = _overEngineering[guid];
                bits.Add(destination!);
                _overEngineering[guid] = bits;

                // If we have duplicate paths in `bits`, we're in a cycle and need to bail
                if (bits.GroupBy(b => b)
                    .Where(g => g.Count() > 1)
                    .Any(g => g.Count() > 1))
                {
                    _overEngineering.Remove(guid, out _);
                    return null;
                }

                path = destination!;
            }
        }
    }

    public static Filesystem TestFilesystem { get; private set; }

    static Cassidoo20260330_ResolvePath()
    {
        TestFilesystem = new();
        TestFilesystem.Add("/a", "/b");
        TestFilesystem.Add("/b", "/c");
        TestFilesystem.Add("/c", null);
        TestFilesystem.Add("/loop1", "/loop2");
        TestFilesystem.Add("/loop2", "/loop1");
        TestFilesystem.Add("/real", null);
        TestFilesystem.Add("/alias", "/real");
    }
}
