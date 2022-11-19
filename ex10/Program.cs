// Программа принимает на вход трехзначное число и выдает его вторую цифру

System.Console.WriteLine("Прграмма выдает вторую цифру числа.");

System.Console.Write("Введите трехзначное число: ");
string UserInput = Console.ReadLine();
int number = int.Parse(UserInput);

int CurrentNumber = number / 10 % 10;
System.Console.WriteLine($"{number} -> {CurrentNumber}");
