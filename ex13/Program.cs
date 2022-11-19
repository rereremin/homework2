// Вывести третью цифру числа, если она имеется
System.Console.WriteLine("Третья цифра в числе?");
System.Console.Write("Введите число: ");
string UserInput = Console.ReadLine();

int length = UserInput.Length;
int number = int.Parse(UserInput);

int CurrentNumber;
double a = Math.Pow(10, length - 3);
if(length >= 3)
{
    CurrentNumber = number / (int)a % 10;
    System.Console.WriteLine($"{number} -> {CurrentNumber}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет.");
}

