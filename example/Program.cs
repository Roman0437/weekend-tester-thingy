//using System.Diagnostics;
//using System.Runtime.CompilerServices;

//Console.WriteLine("give Numer to see if odd or even");
//int x = Convert.ToInt32(Console.ReadLine());
//int y = x % 2;
//if


//naming days
Console.WriteLine("what day off the week is it? (type the number)");
Console.WriteLine("Monday (1");
Console.WriteLine("Tuesday (2");
Console.WriteLine("Wednesday (3");
Console.WriteLine("Thursday (4");
Console.WriteLine("Friday (5");
Console.WriteLine("Sunday (6");
Console.WriteLine("Saturday (7");
Console.WriteLine();

Console.Write(">> ");
//convert days
string x = Console.ReadLine()+"";
Console.WriteLine();

//output the days
switch (x)
{
    case "7":
        x = $"It's the weekend!";

        break;
    case "1":
        x = $"Aack! I hate Mondays!";

        break;
    case "2":
        x = $"It's Tuesday!";

        break;
    case "3":
        x = $"Hump Daaaay!";

        break;
    case "4":
        x = $"It's Thursday!";

        break;
    case "5":
        x = $"TGIF!";

        break;
    case "6":
        x = $"It's the weekend!";

        break;
    default:
        x = $"Please check Math!";
        break;

}
Console.WriteLine();

//writs the endpoint
Console.WriteLine(x);
