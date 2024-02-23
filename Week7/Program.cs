

Console.WriteLine("Kas sa tuled või lähed? (tulen/lähen)");

string valik = Console.ReadLine();

if (valik == "tulen")
{
    Tervitus();
}
else
{
    Lahkumine();
}

static void Tervitus()
{
    Console.WriteLine("Tere, maailm!");
}

static void Lahkumine()
{
    Console.WriteLine("Nägemist!");
}