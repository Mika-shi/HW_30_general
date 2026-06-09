using HW_30_Task2.Extensions;

namespace HW_30_Task2;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 7, 3, 10, 50, 49, 63, 11 };
        List<int> sortedNumbers = numbers.CustomSort();
        
        Console.WriteLine("Исходный список: ");
        PrintList(numbers);
        
        Console.WriteLine("После сортировки: ");
        PrintList(sortedNumbers);
    }
    
    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write($"{item}  ");
        }
        Console.WriteLine();
    }
}