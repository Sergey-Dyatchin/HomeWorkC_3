// Условие:
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Функция генерации массива из целых трехзначных чисел
int[] СreatingArrayThreeDigitInt ()
{
    Console.Write("Введите размер масива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

// Функция подсчета четных чисел в масиве

int CountsEvenNumbers (int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Печатаем результат
Console.Write($"В масиве {CountsEvenNumbers(СreatingArrayThreeDigitInt())} четных чисел");


//тест создания массива
// foreach (int element in СreatingArrayThreeDigitInt())
// {
//     Console.Write($"{element} ");
// }