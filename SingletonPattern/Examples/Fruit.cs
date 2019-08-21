using System;

namespace SingletonPattern
{
    public class Fruit
    {
        private static volatile Fruit _instance;
        private static readonly object _object = new object();

        private Fruit()
        {
        }

        public static Fruit GetInstance()
        {
            if (_instance == null)
            {
                lock (_object)
                {
                    if (_instance == null)
                    {
                        Console.WriteLine("initializing instance");
                        _instance = new Fruit();
                    }
                }
            }

            return _instance;
        }
    }
}