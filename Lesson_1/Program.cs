//  int a; int a2;          // целые числа
//  double b; float c;      // дробные числа

//  a = 7;a2 = 4;
//  b = 2; c = 3;

// Math.Round(b);     // округление до целого

// Console.Write(Math.Round(b));
// Console.WriteLine($"{c/b}"); // при делении целого на целое получаем целое

// char s1 = '5'; char s2 = '7';//  символьный тип данных за 1 символ таблица Аски 5- 53 7- 58 в сумме выведет 108
// Console.WriteLine(s1+s2);
// string s = "Hello world";    //  Строковый тип данных

/*// напишите программу ктр на вход принимает число и выдает его квадрат
int a;
// int a, b, tempenter;
// string userEnter;  // ввод с консоли всегда идет в текстовую переменную
Console.Write("Введите число: ");
// userEnter = Console.ReadLine()!;
// Console.WriteLine(userEnter);
// return; все закончить
// a = int.Parse(userEnter);     // перевод текста в число
int.TryParse(Console.ReadLine()!, out a);  // второй вариант перевода текста в число
// b = a * a;
// b = (int)Math.Pow(a,2);
// Console.WriteLine($"квадрат введенного числа = {b}");
Console.WriteLine($"квадрат введенного числа = {a * a}");
// Console.WriteLine(" квадрат введенного числа = " + b);
// Console.WriteLine($"квадрат введенного числа = {Math.Pow(int.Parse(Console.ReadLine()), 2)}\n");
*/
/*int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);  // < > <= >= !=(не равно) == (равно)
Console.WriteLine($"квадрат введенного числа = {a * a}");*/
/*if (a > 10)
{
    Console.WriteLine("Получилось!");   
}
else
{
    Console.WriteLine("не получилось");
}*/
/* Задача возведение в квадрат
int a;
Console.Write("Введите число: ");
//bool enterSucces = int.TryParse(Console.ReadLine()!, out a);  // < > <= >= !=(не равно) == (равно)

//if (enterSucces)
if(int.TryParse(Console.ReadLine()!, out a))
{
    Console.WriteLine($"квадрат введенного числа = {a * a}");
}
else
{
    Console.Write("Неверно введено число\n");
}
*/
/* вывести все числа от 1 до 10
int i = 0; // i переменная счетчик

// while (true)  // true false  истинно лож; - бесконечный цикл
while (i < 10)
{
    Console.Write($"{i + 1 } "); // вывести все числа от 1 до 10
    i = i + 1; // i =+ 1 ; i++
}
*/

int a=15;
int b=4;
// if (a/b*b==a)
if (a % b == 0)
{
    Console.WriteLine($"Делится");
}
else
{
  //  Console.WriteLine($"Не делится, остаток = {a-a/b*b}");
    Console.WriteLine($"Не делится, остаток = {a % b}");
}