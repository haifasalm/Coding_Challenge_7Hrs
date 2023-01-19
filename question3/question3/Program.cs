using System.Reflection.Metadata.Ecma335;
double[] fares = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("enter the flight fare: ");
    fares[i] = Convert.ToDouble(Console.ReadLine());
}

Array.Sort(fares);
Console.WriteLine("ascending order: ");
foreach (var i in fares)
{
    Console.WriteLine(i+" ");
}

Array.Reverse(fares);
Console.WriteLine("descending order: ");
foreach(var i in fares)
{
    Console.WriteLine(i+" ");
}

Console.WriteLine("enter the search element: ");
 double search = Convert.ToDouble(Console.ReadLine());
var result = Array.Find(fares, element => element == search);
if(result != 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("not found");
}


Console.WriteLine("Maximum fare: " + fares[0]);
Console.WriteLine("Minimum fare: " + fares[4]);

for(int i = 0;i<5; i++)
{
    for (int j = i+1; j < 5; j++)
    {
        if (fares[i] == fares[j])
        {
            Console.Write("duplicate found ");
            Console.WriteLine(fares[i]);
        }
        
       
    }
}