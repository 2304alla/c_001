//Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//a = 25; b = 5 -> да
//a = 10; b = 2 -> нет
//a = -3; b = 9 -> нет
//a = 9; b = -3 -> да

Console.Write("Введите число№1");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число№2");
int num2 = Convert.ToInt32(Console.ReadLine());


if(num == num2*num2)
{
    Console.Write("Является квадратом");
}
else
{
    Console.Write("Не является квадратом");
}
