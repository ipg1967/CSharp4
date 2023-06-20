
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Cifra()
{
    System.Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

// int Kol() 
// {
//     int A = Cifra();
//     int count = 0;
//     while (A >0)
//     {
//         A = A / 10;
//         count++;
//     }
// return count;
// }

System.Console.WriteLine($"Сумма цифр числа = {Kol()} ");

