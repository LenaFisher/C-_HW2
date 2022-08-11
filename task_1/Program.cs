// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1000 & number > 99)
// {
//     int temp1 = (number / 100) * 100;
//     int temp2 = (number - temp1) / 10;
//     Console.WriteLine(temp2);
//     break;
// }






// Console.WriteLine("Вы ввели не трехзначное число");

if (number < 1000 & number > 99)
{
    int temp1 = (number / 100) * 100;
    int temp2 = (number - temp1) / 10;
    Console.WriteLine(temp2);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}








