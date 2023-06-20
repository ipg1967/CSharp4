// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int PowNumbers(int A, int B)
{
    int result = A;
    if (B = 0)
    {
        result = 1;
    }
    else
    {
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
    }
}

// - ОСНОВНАЯ ЧАСТЬ --

int number1 = ReadInt("Введите число - основание степени: ");
int number2 = ReadInt("Введите число - показатель степени: ");

int PN = PowNumbers(number1, number2);

System.Console.WriteLine($"Число {number1} в степени {number2} -> {PN}");

