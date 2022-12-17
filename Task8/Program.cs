// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
System.Console.WriteLine("Задача 8");
System.Console.Write("Введите длину массива: ");
int Number = Convert.ToInt32(Console.ReadLine());// Приобразование стороки в число

for (int i = 1; i <= Number; i++)
    if (i % 2 == 0)
        Console.WriteLine("Чётное число: " + i);

