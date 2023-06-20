// Задача 24: Напишите программу, которая принимает на вход число (А) и число (В) и выдаёт сумму чисел от А до В.

int ReadInt(string text) //double, int[], string, void
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int A, int B)
{
    int sumInFunction = 0;
    for (int i = A; i <= B; i++)
    {
        sumInFunction += i;
    }
    return sumInFunction;
}

// ---------------------------- ОСНОВНАЯ ЧАСТЬ КОДА ----------------------------------------

int number1 = ReadInt("Введите число от которого мы считаем сумму: ");
int number2 = ReadInt("Введите число до которого мы считаем сумму: ");

int sum = SumNumbers(number1, number2);

System.Console.WriteLine($"Сумма чисел от {number1} до {number2} -> {sum}");