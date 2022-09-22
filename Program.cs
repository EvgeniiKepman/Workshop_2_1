// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.WriteLine("Введите число N: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int firstNumber = number / 100;
int lastNumber = number % 10;
int midleNumber = (number - firstNumber*100 - lastNumber)/10;

Console.WriteLine($"{midleNumber}");
