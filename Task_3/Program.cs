// Условие:
// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.

// Функция генерации массива из целых  чисел
int[] СreatingArrayDigitInt ()
{
    Console.Write("Введите размер масива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Массив будет заполненн числами от 0 до введенного Вами включительно: ");
    int max = Convert.ToInt32(Console.ReadLine())+1;
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, max);
    }
    return array;
}

// Функция разворота масива
int[] ReversalArray (int[] array)
{
    int temp;
    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

// Функция печать масива
void PrintArray(int[] array)
{
    foreach (int element in array)
    {
         Console.Write($"{element} ");
    }
}

// Выполнение программы
int[] arrayBasic = СreatingArrayDigitInt ();
Console.Write("Базовый масив: ");
PrintArray(arrayBasic);
Console.Write("\nПеревернутый масив: ");
PrintArray (ReversalArray(arrayBasic));
