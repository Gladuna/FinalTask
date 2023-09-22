/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива строк, разделяя их пробелом:");
        string[] исходныйМассив = Console.ReadLine().Split(' ');

        // Фильтрация строк по длине
        string[] новыйМассив = ФильтроватьСтроки(исходныйМассив);

        // Вывод нового массива
        Console.WriteLine("Новый массив строк с длиной <= 3 символам:");
        foreach (string строка in новыйМассив)
        {
            Console.WriteLine(строка);
        }

        Console.ReadLine();
    }

    static string[] ФильтроватьСтроки(string[] исходныйМассив)
    {
        // Создание временного списка для хранения строк, удовлетворяющих условию
        var временныйСписок = new System.Collections.Generic.List<string>();

        foreach (string строка in исходныйМассив)
        {
            if (строка.Length <= 3)
            {
                // Если строка удовлетворяет условию, добавляем её в список
                временныйСписок.Add(строка);
            }
        }

        // Преобразуем список обратно в массив и возвращаем его
        return временныйСписок.ToArray();
    }
}
*/