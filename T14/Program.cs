// Напишите программу, которая принемает на вход число и проверяет
// кратно но ли оно одновременно  7 и 23
//14 нет
//46 нет
//161 да

Console.WriteLine("Введите  число:  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"Число {a} кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно");
}































