/*Задайте произвольный массив. Выведете 
его элементы, начиная с конца. Использовать 
рекурсию, не использовать циклы.
*/



int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    
    return array;
}

void PrintArrayR(int[] array, int i)
{

    if (i > array.Length - 1)
    {
        
        Console.WriteLine();
        return;
    }

    Console.Write(array[i] + " ");   
    PrintArrayR(array, i + 1);
}

void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        Console.Write(array[array.Length - i - 1] + " ");
        PrintArray(array, i + 1);
    }
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArrayR(array, 0);
PrintArray(array);
