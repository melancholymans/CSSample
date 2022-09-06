using System;
using System.Linq.Expressions;

namespace FirstNameSpace
{
    //struct
    struct ItemStruct
    {
        public int Number;
        public string Name;
    }
    //interface
    interface IGetInfo
    {
        void GetInfo();
    }
    class SampleClass : IGetInfo
    {
        public void GetInfo()
        {
            Console.WriteLine("SampleClass");
        }
    }
    class Sample2Class : IGetInfo
    {
        public void GetInfo()
        {
            Console.WriteLine("Sample2Class");
        } 
    }

    class Car
    {
        public string name = "";
        public int seats=5;
    }
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

            //Car test
            Car mycar = new Car();
            mycar.name = "スカイライン";
            Console.WriteLine(mycar.name);
            Console.WriteLine(mycar.seats);
            //interface
            var s = new SampleClass();
            s.GetInfo();
            var s2 = new Sample2Class();
            s2.GetInfo();
            IGetInfo[] arr = new IGetInfo[2] {s,s2 };
            foreach (IGetInfo i in arr){
                i.GetInfo();
            }
            //try-catch-finaly
            try
            {
                int a = 10;
                int b = 0;
                a /= b;
            }
            catch{
                Console.WriteLine("例外");

                }
            finally
            {
                Console.WriteLine("終了");
            }
            //struct
            ItemStruct item;
            item.Number = 62;
            item.Name = "takemori";
            Console.WriteLine(item.Number);
            Console.WriteLine(item.Name);
            //tuple型の戻り値
            (string name,int age) GetMember()
            {
                var n = "Wing";
                var a = 10;
                return (n, a);
            }
            var m = GetMember();
            Console.WriteLine(m.name);
            Console.WriteLine(m.age);
        }
    }
}