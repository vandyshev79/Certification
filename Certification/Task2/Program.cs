// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


bool ValidateNumbers(int n, int m)
{
    if (n < 0 || m < 0)
    {
        return false;
    }
    return true;
}

int FunctionAkkermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    { 
        return FunctionAkkermann(n - 1, 1);
    } 
    else return FunctionAkkermann(n - 1, FunctionAkkermann(n, m - 1));
}

void PrintResult(int n, int m)
{
    if (ValidateNumbers(n, m))
    {
        Console.WriteLine($"A({n},{m}) = {FunctionAkkermann(n, m)}" );
    }
    else
    {
        Console.Write("Введите положительные числа");
    }
    Console.WriteLine();
}


Console.Clear();
Console.WriteLine("Введите первое число больше нуля n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число больше нуля m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool ValidateResult = ValidateNumbers(n, m);
PrintResult(n, m);
Console.WriteLine();

