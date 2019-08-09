using SingletonPattern;
using System;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {

            var t = Employee.GetInstance();
            var t1 = Employee.GetInstance();
            var t2 = Employee.GetInstance();
            var t3 = Employee.GetInstance();

            var s = GenericSingleton<SimpleClass>.Instance();
            var s1 = GenericSingleton<SimpleClass>.Instance();
            var s2 = GenericSingleton<SimpleClass>.Instance();
            var s3 = GenericSingleton<SimpleClass>.Instance();

            Console.ReadKey();

        }
    }
}
