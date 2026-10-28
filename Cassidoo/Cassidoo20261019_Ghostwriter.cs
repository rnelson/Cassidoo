using System.Text;

namespace Cassidoo;

public static class Cassidoo20261019_Ghostwriter
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20261019.cs
    public static string Ghostwriter(string input)
    {
        var sb = new StringBuilder();
        var a = input.ToCharArray();

        foreach (var c in a)
        {
            var last = sb.Length - 1;
            
            switch (c)
            {
                case '~':
                    if (last < 0) break;
                    sb.Append(sb[last]);
                    
                    break;
                case '#':
                    sb.Remove(last, 1);
                    
                    break;
                default:
                    sb.Append(c);
                    
                    break;
            }
        }
        
        return sb.ToString();
    }
}


/*
This week's question:
There's a ghost in your keyboard! It keeps typing weird symbols in
your words. Given a string you typed (with the ghost), # deletes the
last character and ~ duplicates it, if one exists. Return the final
text.

ghostwriter("ghost")
> "ghost"

ghostwriter("a#~b")
> "b"

ghostwriter("ab~c#")
> "abb"

ghostwriter("BBB##O~")
> 'BOO'

 */