// Amir Moeini Rad
// September 2025

// The Singleton Design Pattern
// Version: 2.0

// In this pattern, a class has only one instance.
// This is useful when exactly one object is needed to coordinate actions across the system or application.

// Modern version of the Singleton pattern in C#.
// The private static readonly field guarantees singularity, thread-safety and lazy initialization by default.

namespace SingletonDP
{    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("The Singleton Design Pattern in C#.NET.");
            Console.WriteLine("---------------------------------------\n");

            // We cannot create an instance of Singleton directly because its constructor is private.            
            Singleton s1 = Singleton.Instance;
            s1.ShowMessage();

            Singleton s2 = Singleton.Instance;
            s2.ShowMessage();

            Console.WriteLine("\nAre s1 and s2 the same? " + (ReferenceEquals(s1, s2) ? "Yes" : "No"));
            Console.WriteLine("\nDone.");
        }
    }
}
