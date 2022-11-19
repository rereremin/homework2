// принимает цифру соответствующую дню недели и определяет выходной ли он?
System.Console.WriteLine("Выходной ли день?");
System.Console.Write("Какой день по счету? ");
string UserInput = Console.ReadLine();

int day = int.Parse(UserInput);

if(day == 6 | day == 7) 
{
    System.Console.WriteLine($"{day} -> выходной");
}
else if(day > 0 && day < 6) 
{
    System.Console.WriteLine($"{day} -> рабочий");
}
else
{
    System.Console.WriteLine($"{day} -> не день недели");
}