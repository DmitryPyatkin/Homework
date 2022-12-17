// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
System.Console.WriteLine("Задача 6");
System.Console.Write("Введите число ");// Вывод приглашения ввода.
string inputValue = Console.ReadLine(); // Ввод стороки с терминала
int Number = Convert.ToInt32(inputValue);// Приобразование стороки в число

if (Number % 2 == 0)
{
    System.Console.Write("Число " + Number + " является чётным.");
}
else
{
    System.Console.Write("Число " + Number + " является нечётным.");
}

