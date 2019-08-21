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

            var f = Fruit.GetInstance();
            var f1 = Fruit.GetInstance();
            var f2 = Fruit.GetInstance();
            var f3 = Fruit.GetInstance();

            var b = Bike.GetInstance();
            var b1 = Bike.GetInstance();
            var b2= Bike.GetInstance();
            var b3 = Bike.GetInstance();

            Console.ReadKey();

        }
    }
}
