DateTime dob;
Console.WriteLine("enter the date of birth: ");
dob = Convert.ToDateTime(Console.ReadLine());
DateTime curr;
curr= DateTime.Now;
TimeSpan ts = curr - dob;
Console.WriteLine("age in days: " + ts.Days);
Console.WriteLine("age in hours: " + ts.Days * 24);
Console.WriteLine("age in weeks: " + ts.Days / 7);
Console.WriteLine("age in months: " + ts.Days / 30);
Console.WriteLine("age in years: " + ts.Days / 365);
int year = dob.Year;
if(year % 4 == 0)
{
    Console.WriteLine("year is a leap year");
}
else
{
    Console.WriteLine("not a leap year");
}