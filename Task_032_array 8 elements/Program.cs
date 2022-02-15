// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
int[] array = new int[8];

int[] FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(0, 2);
    return mass;
}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write($" {mass[i]} ");
}
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");