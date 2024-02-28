Console.WriteLine("podaj liczbe:");
int number = int.Parse(Console.ReadLine());

int wynik = number % 2;

if (wynik == 1)
{
    Console.WriteLine($"{number} jest liczba nieparzystą");
}
else
{
    Console.WriteLine($"{number} jest liczba parzystą");
}