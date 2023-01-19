
double[] fares = new double[10];
double fare;
for (int i = 0; i<10; i++)
{
    Console.WriteLine("enter the flight fare: ");
    fare = Convert.ToDouble(Console.ReadLine());
    fares[i] = fare;
}

for( int i=0; i< 10; i++)
{
    Console.WriteLine(fares[i]);
}


string?[] destinations = new string[10];
for (int i=0; i<10;i++)
{
    Console.WriteLine("enter the destination: ");
    destinations[i] = Console.ReadLine();
}

for(int i=0; i<10; i++)
{
    Console.WriteLine(destinations[i]);
}


Console.WriteLine("enter the number: ");
 int n = Convert.ToInt32(Console.ReadLine());

if(n<10)
{
    Console.WriteLine(fares[n]);
    Console.WriteLine(destinations[n]);
}
