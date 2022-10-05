//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Clear();
// Console.WriteLine("Введите число а:");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b:");
// int b=Convert.ToInt32(Console.ReadLine());

// if (a>b)
// {
//     Console.WriteLine($"Наибольшее число а={a}, наименьшее число b={b}");
// }
// else
// {
//     Console.WriteLine($"Наибольшее число b={b}, наименьшее число a={a}");
// }

//второй вариант
//Console.Clear();
// Console.WriteLine("Введите число а:");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b:");
// int b=Convert.ToInt32(Console.ReadLine());
// int max=a;
// if (a>max) max=a;
// if (b>max) max=b;
// Console.WriteLine($"Наибольшее число ={max}");



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear();
// Console.WriteLine("Введите число а:");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b:");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c:");
// int c=Convert.ToInt32(Console.ReadLine());

//  if (a>b)
// {
//       if (a>c)
//     {
//        Console.WriteLine($"Наибольшее число а={a}");
//     }
//     else
//         if (b>c)
//         {
//             Console.WriteLine($"Наибольшее число b={b}");
//         }
//         else Console.WriteLine($"Наибольшее число c={c}");
// }
// else
//         if (b>c)
//         {
//             Console.WriteLine($"Наибольшее число b={b}");
//         }
//         else Console.WriteLine($"Наибольшее число c={c}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Clear();
// Console.WriteLine("Введите число x:");
// double x=Convert.ToDouble(Console.ReadLine());
// if (x%2==1)
// {
//      Console.WriteLine($"Данное число x={x} не является четным");
// }
// else 
//  Console.WriteLine($"Данное число x={x} четное");




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
while (N%2==1);
{
    Console.WriteLine($"Последовательность четных чисел равна {N}");
    N++;
}
