// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear(); //  Позволяет очистить в консоле.
System.Console.WriteLine("Задача 4");
System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{// Условный оператор логического И (&&).
    Console.WriteLine("Первое число является max = " + a);
}
else if (b > c)
{
    Console.WriteLine("Второе число является max = " + b);
}
else
{
    Console.WriteLine("Третье число является max = " + c);
} 