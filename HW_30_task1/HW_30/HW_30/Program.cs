using HW_30.Extensions;

namespace HW_30;

class Program
{
 
 static void Main()
 {
  Console.OutputEncoding = System.Text.Encoding.UTF8;
  
  Console.WriteLine("Введите ваше предложение");
  string? input = Console.ReadLine();

  if (input.IsNullOrEmptyWhiteSpace())
  {
   Console.WriteLine("Внимание: Предложение не может быть пустым или состоять из одних пробелов.");
   return;
  }

  string sentence = StringExtensions.Trim(input);
  Console.WriteLine("Выберите действие: ");
  Console.WriteLine("1 - привести к верхнему регистру \n2 - привести к нижнему регистру");
  string choice = Console.ReadLine();
  switch (choice)
  {
   case "1":
    Console.WriteLine(StringExtensions.ToUpper(sentence));
    break;
   case "2":
    Console.WriteLine(StringExtensions.ToLower(sentence));
    break;
   default:
    Console.WriteLine("Введите 1 или 2");
    break;
  }
 }
}