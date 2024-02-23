
//Kirjutage programm, mis teisendab Fahrenheiti kraadi Celsiuse järgi ja vastupidi.
//* Programm võimaldab kasutajal valida, kas teisendada väärtuse Celciusesse või Farenheiti.
//* Kui kasutaja on oma valiku teinud, programm küsib sisendit, teostab arvutusi ja kuvab tulemuse.
//* fahrenheit = (celsius * 9) / 5 + 32;
//*celsius = (fahrenheit - 32) * 5 / 9;

//NB! Programmis peab olema kaks funktsiooni:

//static void ConverToCelsius(argument) { }
//static void ConvertToFahrenheit(argument) { }

//Jaga programmi koodi siin (programmi koodi võib, aga ei pea, githubisse üles laadida).

Console.WriteLine("Kas soovid temperatuuri teisendada Celsiuse (C) või Fahrenheiti (F) järgi?");
char kasutajaSisend = char.ToUpper(char.Parse(Console.ReadLine()));
Console.WriteLine("Sisesta teisendamist vajav temperatuur: ");
int sisendTemp = Int32.Parse(Console.ReadLine());

if (kasutajaSisend == 'C')
{
    ConvertToCelsius(sisendTemp);
}
else if (kasutajaSisend == 'F')
{
    ConvertToFahrenheit(sisendTemp);
}
else
{
    Console.WriteLine("Vale sisend!");
}

static void ConvertToCelsius(int t)
{
    Console.WriteLine($"{t} kraadi Farhenheiti on võrdne {(t - 32) * 5 / 9} kraadi Celsiust");
}

static void ConvertToFahrenheit(int t)
{
    Console.WriteLine($"{t} kraadi Celsiust on võrdne {(t * 9) / 5 + 32} kraadi Farhenheiti");

}