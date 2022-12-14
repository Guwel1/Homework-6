// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Введите числа, по завершении набора чисел, наберите 0: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (n!= 0)
{
    if (n>0)
    count++;
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Количество чисел, больше 0: {count}");
