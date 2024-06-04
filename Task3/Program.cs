// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintConvers(int length, int[] array)
{
    if (length == 0) return;
    Console.Write($"{array[length - 1]} ");
    PrintConvers(length - 1, array);
}

int[] array = new int[6] { 1, 3, 0, 15, 7, 28 };
int lengtharray = array.Length;

PrintConvers(lengtharray, array);