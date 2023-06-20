
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ----------------------------------------------------------
// void FillArray(int[] array)
// {
//     Random rand = new Random();
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = rand.Next(0, 2); // new Random().Next(0, 2)
//     }
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// // ----------------------------------------------------

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

// --------------------------- вариант вывода ч выбором разделителя
// void PrintArray(int[] array, string separator)
// {
//     System.Console.WriteLine("[" + string.Join(separator, array) + "]");
// }

// // dsdjl - char, чтобы в число - надо чар в стринг ,потом в инт 
// // string str = "12";
// // int sum = Convert.ToInt32(Convert.ToString(str[0]));
// // System.Console.WriteLine(sum);
