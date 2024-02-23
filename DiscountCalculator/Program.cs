
Console.WriteLine("Sisesta hind: ");
int kasutajaSisend = Int32.Parse(Console.ReadLine());

double ale = ArvutaAle(kasutajaSisend);

Console.WriteLine($"Sinu allahindlus on: {ale}%");

double uusHind = ArvutaUusHind(kasutajaSisend, ale);
Console.WriteLine($"Sinu uus hind on: {uusHind} ja allahindlus {ale}%");

static double ArvutaAle(int kokku)
{
    if (kokku < 10)
    {
        return 1;
    }
    else if (kokku >= 10 && kokku < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double ArvutaUusHind(double kokku, double ale)
{
    double result = kokku - (kokku * ale) / 100;
    return result;
}