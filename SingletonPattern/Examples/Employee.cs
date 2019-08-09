using System;

namespace SingletonPattern
{
    public class Employee
    {
        private static volatile Employee _instance;
        private static readonly object _locker = new object();

        private  Employee()
        {
        }

        public static Employee GetInstance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        Console.WriteLine("initializing instance");
                        _instance = new Employee();
                    }
                }
            }

            return _instance;
        }
    }
}