// Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

Console.WriteLine("Введите целое положительное число А:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число B:");
int b = Convert.ToInt32(Console.ReadLine());

int tmp = 1;
int result = 1;

while(tmp <= b)
{
    result = result * a;
    tmp++;
}
Console.WriteLine("A в степени B равно " + result);