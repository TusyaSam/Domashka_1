// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 0;
if (y>5)  // если введенное число больше 5, то возводим в квадрат
{
    y=x*x;
    Console.WriteLine($"Квадрат числа равен: "+ y);
}
else   // иначе будем возводить в куб
{
    y=x*x*x;
    Console.WriteLine($"Куб числа равен: "+ y);
}
