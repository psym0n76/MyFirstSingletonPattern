using System;

namespace SingletonPattern
{
    /// <summary> Generic singleton with double check pattern and with instance parameter </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericSingleton<T> where T : class, new()
    {
        /// <summary> Lock object </summary>
        private static readonly object _lockingObject = new object();

        /// <summary> Instance </summary>
        private static T _singleObject;

        /// <summary> Protected ctor </summary>
        protected GenericSingleton()
        {
        }

        //test21

        /// <summary> Instance with parameter </summary>
        /// <param name="param">Parameters</param>
        /// <returns>Instance</returns>
        public static T Instance(params dynamic[] param)
        {
            if (_singleObject == null)
            {
                lock (_lockingObject)
                {
                    if (_singleObject == null)
                    {
                        Console.WriteLine("initializing instance");
                        _singleObject = (T)Activator.CreateInstance(typeof(T), param);
                    }
                }
            }
            return _singleObject;
        }
    }
}