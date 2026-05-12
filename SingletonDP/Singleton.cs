namespace SingletonDP
{
    public sealed class Singleton
    {        
        // This field implements the concepts of one single object and thread safety.
        // However, it provides eager initialization, not lazy/late initialization.
        private static readonly Singleton _instance = new();

        // No one can create the Singleton object from outside the class.
        private Singleton()
        {
            Console.WriteLine("Creating the Singleton instance...");
        }

        // The global access point to the Singleton instance.
        public static Singleton Instance
        {
            get => _instance;
        }

        public void ShowMessage() => Console.WriteLine("\nHello from the Singleton object!");
    }
}
