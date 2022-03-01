// Пользователь вводит целое положительное число, которое является кубом целого числа N.
// Найдите число N методом половинного деления.

Console.WriteLine("Введите целое положительное число:");
int a = Convert.ToInt32(Console.ReadLine());

int right = a;
int left = 0;
int n = 0;

while (n*n*n != a)
{
    n = (right + left)/2;

    if (n*n*n < a)
    {
        left = n;
    }
    else
    {
        right = n;
    }
}

Console.WriteLine($"{n} - его кубический корень");