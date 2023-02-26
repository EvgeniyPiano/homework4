// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// *Написать калькулятор с операциями +, -, /, * и возведение в степень

int ReadData(string line)// Модуль запрос на введение числа
{
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

void PrintResult(string line)// Модуль на вывод результата в терминале
{
    Console.WriteLine(line);
}

int ExtentNumber(int numA, int exponent) // Модуль -формула с циклом, согласно задачи
{
    int ext = 1;
    for (int i = 0; i < exponent; i++)
    {
        ext *= numA;//sum=sum+i
    }
    return ext;
}
// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

int numberA = ReadData("Введите число А: ");
int extent = ReadData("Введите степень: ");
int res = ExtentNumber(numberA, extent);
PrintResult($"Число {numberA} в степени {extent}: " + res);