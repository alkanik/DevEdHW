// Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

Console.WriteLine("Введите целое число А от 0 до 1000:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа, которые делятся на {a} без остатка:");

for (int i = a; i <= 1000; i += a)
{
    Console.WriteLine(i);
}