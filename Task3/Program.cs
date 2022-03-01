// Пользователь вводит 1 число (A).
// Найдите количество положительных целых чисел, квадрат которых меньше A.


Console.WriteLine("Введите целое положительное число А:");
int a = Convert.ToInt32(Console.ReadLine());
int number = 0;

for (int i = 1; i*i < a; i++)
{
    number++;
}
Console.WriteLine($"Ответ: {number}");