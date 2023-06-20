
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ----------------------------------------------------------
int[] massiv(int N)
{
    int[] array = new int[N];
    for(int i =0; i < N; i++)
    {
        array[i] = Vvod(i+1);
    }
    return array;
}

int Vvod(int A)
{
System.Console.WriteLine($"Введите {A}-е число: ");
return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array, string separator)
{
    System.Console.WriteLine("[" + string.Join(separator, array) + "]");
}

// ----------------------------------------------------

System.Console.WriteLine("массив какого размера сформировать? Введите число элементов: ");
PrintArray(massiv(Convert.ToInt32(Console.ReadLine())), ", ");

