

Console.WriteLine("Sisesta midagi");
string kasutajaSisend = Console.ReadLine();

sisendKordaViis(kasutajaSisend);

static void sisendKordaViis(string s)
{
    s = s.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(s);
    }
}