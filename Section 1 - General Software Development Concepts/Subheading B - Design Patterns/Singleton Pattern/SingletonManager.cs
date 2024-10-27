namespace Singleton_Pattern
{
    //A design pattern is a general concept that promotes code reuse, this means they work as templates that can be applied to solve common issues with software design.
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
