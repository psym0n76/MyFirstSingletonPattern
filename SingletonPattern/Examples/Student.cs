namespace SingletonPattern
{
    public class Student
    {
        private static volatile Student _instance;
        private static readonly object Mutex = new object();

        public string Name { get; }
        public int Age { get; }

        private Student(string name, int age)
        {
            // whatever
            Age = age;
            Name = name;
        }

        //if you want to pass items to constructor
        public static Student GetInstance(string name, int age)
        {
            if (_instance == null)
            {
                lock (Mutex) // now I can claim some form of thread safety...
                {
                    if (_instance == null)
                    {
                        _instance = new Student(name, age);
                    }
                }
            }

            return _instance;
        }
    }
}