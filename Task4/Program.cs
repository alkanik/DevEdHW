// Пользователь вводит 1 число (A).
// Вывести наибольший делитель (кроме самого A) числа A.

Console.WriteLine("Введите целое положительное число A:");
int a = Convert.ToInt32(Console.ReadLine());
int divisor = 0;

for (int i = 1; i < a; i++)
{
    if (a%i==0)
    {
        divisor = i;
    }
}
Console.WriteLine(divisor);