using System;

namespace SingletonPattern
{
    public class Bike
    {
        private static volatile Bike _instance;
        private static readonly object _locker = new object();

        private Bike()
        {
        }

        //small comment

        public static Bike GetInstance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        Console.WriteLine("initializing instance");
                        _instance = new Bike();
                    }
                }
            }

            return _instance;
        }
    }
}