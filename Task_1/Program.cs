// Условие:
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Функция запроса текста с консоли
string ReadInput()
{
    Console.Write("Введите текст: ");
    return Console.ReadLine();
}

// Функция проверки на ввод "q"
bool ComparisonsWithQ(string text)
{
    return (text == "q");
}

// Функция проверки четности сумм цифр
bool СheckingParitySumDigits(string text)
{
    int number;
    if (int.TryParse(text, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            return true;
        }
    }
    return false;
}
// Функция бесконечного запроса пока не будетт введен q или числа, сумма цифр которого чётная.
void EndlessRequestBeforeExiting()
{
    string txt; 
    while (true)
    {
        txt = ReadInput();
        if (ComparisonsWithQ(txt) || СheckingParitySumDigits(txt))
        {
            break;
        }
    }
}

// Запуск основной функции
EndlessRequestBeforeExiting();

// тесты
// Console.Write(ReadInput());
// Console.Write(ComparisonsWithQ(ReadInput()));
// Console.Write(СheckingParitySumDigits(ReadInput()));
