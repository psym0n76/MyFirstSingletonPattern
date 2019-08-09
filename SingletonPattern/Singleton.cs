using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static volatile Singleton _instance;

        private static readonly object _mutex = new Object();

        private Singleton(object arg1, object arg2)
        {
            // whatever
        }

        public static Singleton GetInstance(object arg1, object arg2)
        {
            if (_instance == null)
            {
                lock (_mutex) // now I can claim some form of thread safety...
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton(arg1, arg2);
                    }
                }
            }

            return _instance;
        }
    }
}