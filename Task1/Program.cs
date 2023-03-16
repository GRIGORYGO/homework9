/*Задача 64: Задайте значение N. Напишите программу, которая выведет
 все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber()
{
    int result = 0;
    while (true)
    {
        Console.WriteLine("введите натуральное число: ");
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не цифру, попробуйте еще раз: ");
        }
    }
    return result;
}

void WriteNubers(int n)
{
    if (n == 1) Console.Write("1 ");
    else
    {
        Console.Write($"{n}, ");
        WriteNubers(n - 1);
    }
}


int numberN = GetNumber();
WriteNubers(numberN);