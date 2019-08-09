namespace SingletonPattern
{
    public class Person
    {
        private static volatile Person _instance = null;
        private static readonly object _mutex = new object();

        private Person()
        {
        }

        public static Person GetInstance()
        {

            if (_instance == null)
            {
                lock (_mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new Person();
                    }
                }
            }

            return _instance;
        }
    }
}