// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) CubeTable(number);
else System.Console.WriteLine("Задано некорректное число");

void CubeTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        System.Console.WriteLine($"|{count,4}|{Math.Pow(count, 3),4}|");
        count++;
    }
}