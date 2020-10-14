using System;

namespace EgressAssess.Core
{
    class CustomConsole
    {
        public static void WriteLine(string line)
        {
            Console.WriteLine($"[*] {line}");
        }

        public static void WriteError(string error)
        {
            Console.WriteLine($"[*] {error}");
        }
    }
}