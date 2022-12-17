// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear(); //  Позволяет очистить в консоле.
System.Console.WriteLine("Задача 2");
System.Console.Write("Введите первое число: ");
string inputValue = Console.ReadLine(); //  Ввод стороки с терминала.
int a = Convert.ToInt32(inputValue); // Приобразование стороки в число.

System.Console.Write("Введите второе число: ");
string inputValue2 = Console.ReadLine();
int b = Convert.ToInt32(inputValue2); // ToInt32(String) Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число со знаком.
// Класс Convert включает статические методы, которые можно вызывать для преобразования целочисленных значений.
int max = a; // Целочисленный тип int - это основной тип данных для хранения чисел.

if (a > max || b < max) // (N > max) - условие. || (условное логическое ИЛИ).
{
    max = a;
    System.Console.WriteLine("Первое число является max = " + a);
}
else if (b > max)
{
    max = b;
    System.Console.WriteLine("Второе число является max = " + b);
}
