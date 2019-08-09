using System.Runtime.InteropServices;

namespace SingletonPattern
{
    public class Test
    {
        private static volatile Test _instance;
        private static readonly object _mutex = new object();

        public static Test GetInstance()
        {

            if (_instance == null)
            {
                lock (_mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new Test();
                    }
                }
            }

            return _instance;
        }
    }
}