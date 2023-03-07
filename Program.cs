// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int pal, num, pal2 = 0;
// Console.Write("Введите пятизначное число: ");
// string s = Console.ReadLine();

// if (int.TryParse(s, out pal))
// {
//     num = pal;
//     while (num > 0)
//     {
//         pal2 *= 10;
//         pal2 += num % 10;
//         num /= 10;
//     }
//     if (pal == pal2) Console.WriteLine("да");
//     else Console.WriteLine("нет");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точки A: ");
// Console.Write("x1: "); int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1: "); int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("c1: "); int c1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B: ");
// Console.Write("x2: "); int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2: "); int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("c2: "); int c2 = Convert.ToInt32(Console.ReadLine());
// double distance = Distance(x1, y1, c1, x2, y2, c2);
// double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
// Console.WriteLine($"{distanceRound}");
// double Distance(int x1, int y1, int c1, int x2, int y2, int c2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((c2 - c1), 2));
// }

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Cube(int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.WriteLine($"{count} {count * count * count}");
//         count++;
//     }
// }
// Cube(number);