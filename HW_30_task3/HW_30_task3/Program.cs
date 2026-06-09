namespace HW_30_task3;

class Program
{
    static void Main()
    {
        List<int> numbers = new()
        {
            -15, -12, -10, -3, -2, 0, 1, 2, 3, 11, 12, 15, 21, 25, 31, 35, 45, 25, 15
        };
        List<string> strings = new()
        {
            "Sun",
            "moon",
            "River",
            "Book",
            "pen",
            "Paris",
            "Flower",
            "Car"
        };
        List<string> words = new()
        {
            "lorem.ipsum.dolor.sit.amet",
            "consectetur.adipiscing.elit",
            "bdipiscing"
        };
        
        PrintThings.PrintList("Method1", LinqTasks.Method1(numbers) );
        
        Console.WriteLine($"---> Mehtod2 <---");
        Console.WriteLine(LinqTasks.Method2(numbers));
        Console.WriteLine();

        PrintThings.PrintList("Method3", LinqTasks.Method3(numbers) );
        PrintThings.PrintList("Method4", LinqTasks.Method4(numbers, 5));
        PrintThings.PrintList("Method5", LinqTasks.Method5(strings, 6));
        PrintThings.PrintList("Method6", LinqTasks.Method6(numbers) );
        PrintThings.PrintList("Method7", LinqTasks.Method7(words, 8));
    }
}