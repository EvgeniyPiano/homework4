// SЗадача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadData(string line)// Модуль запрос на введение числа
{
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

int SumAllNum(int num) // Модуль -формула согласно задачи
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int num = ReadData("Введите число: ");
Console.WriteLine($"Сумма всех чисел в {num} ={SumAllNum(num)}");
