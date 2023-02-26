// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int[] Gen1DArr(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
Print1DArr(Gen1DArr(5, 1, 20));