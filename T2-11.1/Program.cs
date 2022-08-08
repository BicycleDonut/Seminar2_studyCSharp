// Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.(семинар)
//456 -> 46
//782 -> 72
//918 -> 98

// 1 способ

//int number = new Random().Next(100,999);
//Console.WriteLine($"Наше случайное число: {number}");
//int a=number/100;
//int b=number%10;
//Console.WriteLine($"{a}{b}");

// 2 способ

string s = new Random().Next(100, 1000).ToString(); // конвертация числа в строку ToString
Console.WriteLine($"Наше случайное число: {s}");
int first = int.Parse(s[0].ToString()); // проход int.Parse по строке ToString с нахождением элемента s[0]
int last = int.Parse(s[s.Length - 1].ToString()); // s[s.Length - 1 размер массива минус 1 получаем 3 знак числа   
Console.WriteLine($"{first}{last}");



