// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckermanFunction(int n, int m) // задаем рекурсивную функцию
{
    if (n == 0) return (m + 1);
    if (m == 0) return AckermanFunction(n - 1, 1);
    return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

// Пишем тело программы

// Ввод чисел с консоли
Console.WriteLine("Введите натуральное число N: "); // Ввод числа N
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число M: ");// Ввод числа M
int numberM = Convert.ToInt32(Console.ReadLine());

if (numberN >= 0 && numberM >= 0) // проверяем на правильность ввода неотрицательных чисел
{
    int result = AckermanFunction(numberN, numberM);
    Console.WriteLine($"Значение функции Аккермана равно {result}");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}