using System;

namespace FirstNameSpace
{
    enum Day
    {
        Sun,Mon,Tue,Wed,Thu,Fri,Sat
    }
    class First
    {
        static string program_ver = "sample #1";
        static void Main()
        {
            System.Console.WriteLine(program_ver);
            System.Console.Write("name >> ");
            string? name = System.Console.ReadLine();
            System.Console.WriteLine($"Welcom {name}");
            Console.WriteLine(Day.Mon);
        }
    }
}