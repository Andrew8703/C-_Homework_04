//Задача 28: Подсчитайте сумму цифр в числе.
int number = new Random().Next(100, 10000);
Console.WriteLine("Число: " + number);
int sumDigits = 0;
int deldigit = 0;
while (number > 0)
{
    deldigit = number % 10;
    number = number / 10;
    sumDigits = sumDigits + deldigit;
}
Console.Write("Сумма цифр числа : "+sumDigits);


