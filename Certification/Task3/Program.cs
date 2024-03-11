// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


int[] RandommArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100); 
    }
    return array;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();    
}

int[] ArrayRotation(int[] array, int current = 0)
{
    if (current == array.Length)
    {
        return array;
    }
    else
    {
        ArrayRotation(array, current + 1);
        Console.Write($"{array[current]}\t");
    }
    return array;
}



Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] array = RandommArray(n);
Console.WriteLine("Начальный массив: ");
PrintArr(array);
Console.WriteLine();
Console.WriteLine("Перевёрнутый массив: ");
ArrayRotation(array);
