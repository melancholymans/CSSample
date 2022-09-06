using System;

namespace FirstNameSpace
{
    class First
    {
        static string program_ver = "sample #1";
        static void Main()
        {
            System.Console.WriteLine(program_ver);
            System.Console.Write("name >> ");
            string? name = System.Console.ReadLine();
            System.Console.WriteLine($"Welcom {name}");
        }
    }
}