using System;

namespace FancyPrint
{
    public class fPrint
    {
        public static void Info(string message)
        {
            Console.WriteLine("[i] {0}", message);
        }
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[-] {0}", message);
            Console.ResetColor();
        }

        public static void Okay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] {0}", message);
            Console.ResetColor();
        }

        public static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[!] {0}", message);
            Console.ResetColor();
        }


    }
}
