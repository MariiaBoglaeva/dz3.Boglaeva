// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number > 9999 && number < 100000)
{
    int[] arrayNumber = new int[5];
    FullFiveDigitArray(number, arrayNumber);
    string answer = CheckArray(arrayNumber);
    Console.WriteLine(answer);
}
else System.Console.WriteLine("Задано некорректное число");

string CheckArray(int[] collection) // метод проверят массив на палиндромность
{
    int size = collection.Length;
    int pos = 0;
    while (pos < size)
    {
        if (collection[pos] != collection[size - 1 - pos]) return "Не палиндром";
        pos++;
    }
    return "Палиндром";
}
void FullFiveDigitArray(int num, int[] coll) // преобразовываем число в массив
{
    int count = 0;
    while (count < 5)
    {
        coll[4 - count] = num % 10;
        num = num / 10;
        count++;
    }
}
