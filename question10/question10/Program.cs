Console.WriteLine("enter boarding pass numbers: ");
var passNo = new List<int>();

for(int i = 0;i < 10; i++)
{
    passNo.Add(Convert.ToInt32(Console.ReadLine()));
}

int[] counter1 = new int[3];
int[] counter2 = new int[3];
int[] counter3 = new int[3];

Random rd = new Random();
int size = 10;

for(int i = 0;i < 3; i++)
{
    int rdNo = rd.Next(size);
    counter1[i] =passNo[rdNo];
    passNo.RemoveAt(rdNo);
    size -= rdNo;
}
for (int i = 0; i < 3; i++)
{
    int rdNo = rd.Next(size);
    counter2[i] = passNo[rdNo];
    passNo.RemoveAt(rdNo);
    size -= rdNo;
}
for (int i = 0; i < 3; i++)
{
    int rdNo = rd.Next(size);
    counter3[i] = passNo[rdNo];
    passNo.RemoveAt(rdNo);
    size -= rdNo;
}
Console.WriteLine("boarding pass numbers in counter1: ");
foreach (int i in counter1)
{
    Console.WriteLine(i);
}
Console.WriteLine("boarding pass numbers in counter2: ");
foreach (int i in counter2)
{
    Console.WriteLine(i);
}
Console.WriteLine("boarding pass numbers in counter3: ");
foreach (int i in counter3)
{
    Console.WriteLine(i);
}
Console.WriteLine("choose the available counter: ");
int counterNo =Convert.ToInt32( Console.ReadLine());

if(counterNo == 1)
{
    counter1[0] = counter1[1];
    counter1[1] = counter1[2];
    counter1[2] = passNo[0];
    Console.WriteLine("passes in counter 1: ");
    foreach (var item in counter1)
    {
        Console.WriteLine(item);
    }
}
else if (counterNo == 2)
{
    counter2[0] = counter2[1];
    counter2[1] = counter2[2];
    counter2[2] = passNo[0];
    Console.WriteLine("passes in counter 2: ");
    foreach (var item in counter2)
    {
        Console.WriteLine(item);
    }
}
else if (counterNo == 3)
{
    counter3[0] = counter3[1];
    counter3[1] = counter3[2];
    counter3[2] = passNo[0];
    Console.WriteLine("passes in counter 3: ");
    foreach (var item in counter3)
    {
        Console.WriteLine(item);
    }
}