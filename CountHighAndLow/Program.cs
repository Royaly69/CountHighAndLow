using System.Security.Cryptography;

Console.WriteLine("Indtast på motivations scorer som heltal på en linje, del med Space");
string ans = Console.ReadLine();
Console.WriteLine(CountHighLow(ans));

static string CountHighLow(string s)
{
    string[] arr = s.Split(" ");
    int l=0;
    int h=0;
    foreach (string n in arr)
    {
        if (Convert.ToInt32(n) > 7)
        {
            h++;
        }
        else
        {
            l++;
        }
    }

    return "der er "+ h+" Høje og "+l+" Lave";
}