


Console.WriteLine("Sisesta tehtemärk (+/-):");
char tehteMärk = Char.Parse(Console.ReadLine());

Console.WriteLine("Sisesta esimene arv:");
int esimeneNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Sisesta teine arv:");
int teineNum = Int32.Parse(Console.ReadLine());

switch (tehteMärk)
{
    case '+':
        Liitmine(esimeneNum, teineNum);
        break;
    case '-':
        Lahutamine(esimeneNum, teineNum);
        break;
    default:
        Console.WriteLine("tehtemärk vigane");
        break;
}

static void Liitmine(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}
static void Lahutamine(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}