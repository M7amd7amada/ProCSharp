using static System.Console;
using static System.Environment;

namespace ProCSharp.SimpleCSharpApp;

public class Program
{
    public static int Main(string[] args)
    {
        WriteLine("Hello, World!");

        WriteLine((2222).ToString("C"));

        int num = 9999, numTwo = 2222, numThree = 3333;
        WriteLine($"Num = {num:N}");
        WriteLine($"Num = {numTwo:F}");
        WriteLine($"Num = {numThree:G}");

        bool foo = Char.IsWhiteSpace(' ');

        if (bool.TryParse("True", out bool bazz))
            WriteLine(bazz);
    
        ValueType v = 2;
        Type type = 3.GetType();
        int hashCode = "String".GetHashCode();
        string strOne = 23.ToString();
        bool boolean = 5.Equals(5);

        string dream = bool.FalseString;

        WriteLine(hashCode);

        string str = default!;
        if (str is null)
            WriteLine("NULL");
        else
            WriteLine("NOT NULL");

        // It doesn't depend on string[] args
        string[] listOfArguments = GetCommandLineArgs();

        foreach(string arg in listOfArguments)
        {
            WriteLine(arg);
        }
        // Console.ReadLine();

        ShowEnvironmentVariables();

        static void ShowEnvironmentVariables()
        {
            foreach (string drive in GetLogicalDrives())
            {
                WriteLine(drive);
            }
            WriteLine(OSVersion);
            WriteLine(ProcessorCount);
            WriteLine(Environment.Version);
        }

        return 0;
    }

    // public static void Main(string[] args);
    // public static int Main(string[] args);
    // public static void Main();
    // public static int Main();
    // public static async Task Main();
    // public static async Task<int> Main();
    // public static async Task Main(string[] args);
    // public static async Task<int> Main(string[] args);
}