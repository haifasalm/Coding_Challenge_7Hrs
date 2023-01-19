using System.Transactions;

Console.WriteLine("enter the flight fare: ");
double fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the time: ");
int time = Convert.ToInt32(Console.ReadLine());

if(time >= 6 && time < 9)
{
    fare = (fare * .1) + fare;
    Console.WriteLine(fare);
}
else if(time >= 9 && time < 17)
{
    fare = (fare * .2) + fare;
    Console.WriteLine(fare);
}
else if (time >= 17 && time < 23)
{
    fare = (fare * .07) + fare;
    Console.WriteLine(fare);
}
else
{
    fare = (fare * .05) + fare;
    Console.WriteLine(fare);
}

