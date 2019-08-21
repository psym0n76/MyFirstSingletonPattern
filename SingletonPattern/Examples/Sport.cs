namespace SingletonPattern
{
    public class Sport
    {
        private static volatile Sport _instance;
        private static readonly object Locker = new object();

        private Sport()
        {
        }

        public static Sport GetInstance()
        {

            if (_instance == null)
            {
                lock (Locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Sport();
                    }
                }
            }

            return _instance;
        }
    }
}