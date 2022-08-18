//Console.WriteLine("Hello, World!");
Console.Clear ( );

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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


// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// //Console.Write( "Ведите три числа и мы скажем какое из них больше");
// Console.Write(" Введите первое число  -  ");
// int a = Convert.ToInt32(Console.ReadLine( ));
// Console.Write(" Введите второе число  -  ");
// int b = Convert.ToInt32(Console.ReadLine( ));
// Console.Write(" Введите третье число  -  ");
// int c = Convert.ToInt32(Console.ReadLine( ));
// int max = a;
// if (a > max) max =a;
// if (b > max) max = b;
// if (c > max) max = c;
// // Console.Write("max =  "); 
// // Console.WriteLine( max ); 
// //Аналогично 
// Console.WriteLine($"Максимальное число =  {max} " );


// // Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Write("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int B = - N ;  // Объявляю новую переменную в которой сохраняю значение N с противоположным знаком

// while ( B <= N) //Условный цикл, который работает до тех пор, пока B меньше или равно N
// {
//     Console.Write( B + "  "); // Выводим на экран значение B и пробел
//     //Увеличиваем b на единицу
//     B ++; 
//      // аналогично b+ = 1 //B = B + 1;
// }
// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write ("Введите число и мы скажем, является ли оно четным - ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x% 2 == 0)
// {
// Console.WriteLine("ДА число четное ");
// }
// else
// {
// Console.WriteLine("НЕТ число не четное");
// }

// // Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.WriteLine( "Введите трехзначное число -   ");
// int num = Convert.ToInt32 ( Console.ReadLine ());
// if (num > 99 && num <= 999)
// {
//     int x = num %10;
//     Console.WriteLine( x );
// }
// else
// {
//   Console.WriteLine ( "Введенное число не трехзначное");  
// }
