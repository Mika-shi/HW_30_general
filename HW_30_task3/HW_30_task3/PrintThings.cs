namespace HW_30_task3;

public class PrintThings
{
    public static void PrintList<T>(string name, IEnumerable<T> values)
    {
        Console.WriteLine($"---> {name} <---");
        Console.WriteLine(string.Join(", ", values));
        Console.WriteLine();
    }
}