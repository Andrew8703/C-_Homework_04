// Задача 26: Возведите число А в натуральную степень B, используя цикл.
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 5);
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result * a;
}
Console.WriteLine($"Число {a} в степени {b} равно {result}");