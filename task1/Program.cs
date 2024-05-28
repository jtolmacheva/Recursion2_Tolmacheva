/*Задача 1: Задайте значения M и N. Напишите 
программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не 
использовать цик лы.

M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/



void OneToN(int n, int m)
{
    
    if (m > n)
    {
        OneToN(m - 1, n);
        System.Console.Write(m + " ");
    }
    else if (n > m)
    {
        OneToN(n - 1, m);
        System.Console.Write(n + " ");
    }
    else if (m == n)
    {
        System.Console.Write(m + " ");

    }
    
    
}
OneToN(4, 8);

