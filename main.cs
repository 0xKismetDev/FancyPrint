using System;

namespace FancyPrint
{
    public static class fPrint
    {
        public static void Error(string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] " + format, args);
            Console.ResetColor();
        }

        public static void Info(string format, params object[] args)
        {
            Console.WriteLine("[i] " + format, args);
        }

        public static void Okay(string format, params object[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] " + format, args);
            Console.ResetColor();
        }
    }
}
