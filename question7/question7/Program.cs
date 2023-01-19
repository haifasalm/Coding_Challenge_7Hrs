Console.WriteLine("enter the passenger name: ");
Console.ReadLine();
Console.WriteLine("total miles travelled: ");
int miles = Convert.ToInt32(Console.ReadLine());
int flyerpoints = 0;

if(miles > 10000 & miles <= 20000)
{
    flyerpoints = 10;
    Console.WriteLine("flyerpoints is " + flyerpoints);
    Console.ReadLine();
}
else if (miles > 20000 & miles <= 50000)
{
    flyerpoints = 20;
    Console.WriteLine("flyerpoints is " + flyerpoints);
    Console.ReadLine();
}
else if (miles > 50000 & miles <= 100000)
{
    flyerpoints = 30;
    Console.WriteLine("flyerpoints is " + flyerpoints);
    Console.ReadLine();
}
else if(miles > 100000)
{
    flyerpoints = 50;
    Console.WriteLine("flyerpoints is " + flyerpoints);
    Console.ReadLine();
}
