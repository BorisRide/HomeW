// Задача 1: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNatureNumbersBetweenMN(int nummin, int nummax) // метод первый, N > M
{
    if (nummax == nummin - 1) return; // условие окончания рекурсии
    PrintNatureNumbersBetweenMN(nummin, nummax - 1); // здесь параметр уменьшается на единицу
    Console.Write($"{nummax} "); // печатаем числа 
}

void PrintNatureNumbersBetweenNM(int nummin, int nummax) // метод второй, N < M
{
    if (nummin == nummax + 1) return; // условие окончания рекурсии
    PrintNatureNumbersBetweenNM(nummin + 1, nummax); // здесь параметр уменьшается на единицу
    Console.Write($"{nummin} "); // печатаем числа
}

// Пишем тело программы

// Ввод чисел с консоли
Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN > 0 && numberM > 0) // проверяем на ввода натуральных (неотрицательных) чисел
{
    if (numberN == numberM)
    {
        Console.WriteLine("Запустите программу ещё раз и повторите ввод, числа N и M не должны быть равны");
    }
    if (numberN > numberM)
    {
        PrintNatureNumbersBetweenMN(numberM, numberN); // Вызов метода (рекурсии)
    }
    else
    {
        PrintNatureNumbersBetweenNM(numberN, numberM); // Вызов метода (рекурсии)
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}