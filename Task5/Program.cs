// Пользователь вводит 2 числа (A и B).
// Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
// (Учтите, что при вводе B может оказаться меньше A).

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

int tmp = 0;

if (a>b)
{
    tmp = a;
    a = b;
    b = tmp;
}

int result = 0;

for (int i=a; i<=b; i++)
{
    if (i%7==0)
    {
        result += i;
    }
}

Console.WriteLine($"Результат:{result}");