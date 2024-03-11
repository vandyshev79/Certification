// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


string PrintNumbers(int number1, int number2)
{
    if (number1 == number2)
    {
        return Convert.ToString(number1);
    }
    return number1 + " " + PrintNumbers(number1 + 1, number2);
}



Console.Clear();
Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write(PrintNumbers(number1, number2));
