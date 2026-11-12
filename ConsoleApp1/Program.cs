//Tootia
//Practice1
try
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Enter salary: ");
    Console.ResetColor();
    var salary = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Hours of work: ");
    Console.ResetColor();
    var hours = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("% of the tax: ");
    Console.ResetColor();
    var tax = Convert.ToInt32(Console.ReadLine());
    var salary1 = hours * salary;
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Salary: ");
    Console.ResetColor();
    Console.Write($"{salary1}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("$");
    Console.ResetColor();
    var pay = (salary1 * tax) / 100;
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Tax: ");
    Console.ResetColor();
    Console.Write($"{pay}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("$");
    Console.ResetColor();
    var finalsalary = salary1 - pay;
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Final salary is: ");
    Console.ResetColor();
    Console.Write($"{finalsalary}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("$");
    Console.ResetColor();
}
catch (FormatException)
{
    Console.WriteLine("Only numbers!");
}
catch (OverflowException)
{
    Console.WriteLine("Ummm... That's too much!");
}
catch
{
    Console.WriteLine("What did you do?");
}
Console.Write("");
