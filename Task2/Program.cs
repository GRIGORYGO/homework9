/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке 
 от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string msg)
{
    Console.Write(msg);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Ввели не цифру, попробуйте еще раз: ");
    }
    return result;
}

void SumNumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}


int m = GetNumber("Bведите число M: ");
int n = GetNumber("Bведите число N: ");
SumNumFromMToN(m, n);
