namespace Singleton_Pattern
{
    //A design pattern provides a reusable solution to common software design problems.
    //A Singleton pattern makes sure a class only has one instance and gives global access to it.

    public class SingletonManager
    {
        private static SingletonManager? _instance;
        private static readonly object _lock = new();

        private SingletonManager() { }

        public static SingletonManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new SingletonManager();
                    }
                }
                return _instance;
            }
        }

        public string Singleton { get; set; }
    }
}
