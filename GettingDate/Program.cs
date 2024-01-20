// See https://aka.ms/new-console-template for more information
using GettingDate;

Console.WriteLine(" a: Show current date and time ");
Console.WriteLine(" b: Show Today date");
Console.WriteLine(" c: show current UTC current time");
Console.WriteLine(" d: show max value of DateTime");
Console.WriteLine(" e: min max value of DateTime");
String s=Console.ReadLine();
if (s == "a")
{
    CurrentTime c = new CurrentTime();
}
else if (s == "b")
{
    Todaydat t = new Todaydat();
}
else if (s == "c")
{
    Utc u = new Utc();
}
else if (s == "d")
{
    MaxV d = new MaxV();
}
else if (s == "e")
{
    MinV d = new MinV();
}

else
    Console.WriteLine("Invalid Choice");