// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
int maxN = new Random().Next(0, 50);
int minN = -1;
Console.WriteLine($"Диапазон от {minN} до {maxN}");
Console.WriteLine("Все кубы чисел, заканчивающихся на чётную цифру данного диапазона: ");
while (minN <= maxN)
{
    if ((minN % 2) == 0)
    {
        Console.WriteLine($"Куб числа {minN} = {minN * minN * minN}");
    }
    minN++;
}