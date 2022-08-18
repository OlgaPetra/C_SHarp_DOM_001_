//Console.WriteLine("Hello, World!");
Console.Clear ( );

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write(" Введите первое число  -  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите второе число  -  ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine($"Больше число , { a }");
//     Console.WriteLine($"Меньшее число , { b }");
// }

// else
// {
//     Console.WriteLine($"Большее число,{ b} ");
//     Console.WriteLine($"Меньшее число ,{ a}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Console.Write( "Ведите три числа и мы скажем какое из них больше");
Console.Write(" Введите первое число  -  ");
int a = Convert.ToInt32(Console.ReadLine( ));
Console.Write(" Введите второе число  -  ");
int b = Convert.ToInt32(Console.ReadLine( ));
Console.Write(" Введите третье число  -  ");
int c = Convert.ToInt32(Console.ReadLine( ));
int max = a;
if (a > max) max =a;
if (b > max) max = b;
if (c > max) max = c;
// Console.Write("max =  "); 
// Console.WriteLine( max ); 
//Аналогично 
Console.WriteLine($"Максимальное число =  {max} " );
