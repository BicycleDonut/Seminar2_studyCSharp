// Напишите программу, которая на вход принемает 2 числа и проверяет
// является ли одно число квадратом другого.
//5,25 да
//-4,16 да
//25,5 да
//8,9 нет
//
Console.WriteLine("Введите первое число:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int b = Convert.ToInt32(Console.ReadLine());
if(a*a==b || b*b==a) // || - оператор или
{
    Console.WriteLine("ДА");
}
else
{
  Console.WriteLine("НЕТ");  
}