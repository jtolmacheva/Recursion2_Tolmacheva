/*Задача 2: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n. 
*/

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
}

int result = FunctionAkkerman(2, 3);
System.Console.Write(result);

