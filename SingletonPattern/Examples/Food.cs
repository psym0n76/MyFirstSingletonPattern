namespace SingletonPattern
{
    public class Food
    {
        private static volatile Food _instance;
        private static readonly object _mutex = new object();

        private Food()
        {
        }

        public static Food GetInstance()
        {
            if (_instance == null)
            {
                lock (_mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new Food();
                    }
                }
            }

            return _instance;
        }
    }
}