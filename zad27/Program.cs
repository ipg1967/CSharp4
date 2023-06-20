
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum(int B) 
{
   int s = 0;
    while (B > 0)
    {
        s = s + B%10;
        B = B/10;
    }
return s;
}

System.Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа = {sum(A)} ");

