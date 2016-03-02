using System;

namespace TextUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            var text = "The quick brown fox jumps over the lazy dog";

            foreach (var s in parser.Parse(text))
            {
                Console.WriteLine(s);
            }
        }
    }
}
