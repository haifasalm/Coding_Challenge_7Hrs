DateTime dob;
int[] ages = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("enter the dob");
    dob = Convert.ToDateTime(Console.ReadLine());
    DateTime curr;
    curr = DateTime.Now;
    TimeSpan diff = curr - dob;
    int age = diff.Days / 365;
    ages[i] = age;

}
foreach (var item in ages)
{
    if(item < 10)
    {
        Console.WriteLine("person is kid");
    }
    else if(item >= 10 & item <30)
    {
        Console.WriteLine("person is youth");
    }
    else if(item >= 30 & item < 60)
    {
        Console.WriteLine("person is adult");
    }
    else
    {
        Console.WriteLine("person is older");
    }
}
    
