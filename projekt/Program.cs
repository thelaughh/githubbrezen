// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//cislo1
Console.WriteLine("Zadejte jakékoliv číslo");
int cislo1 = Convert.ToInt32(Console.ReadLine());

//cislo 2
Console.WriteLine("Zadejte druhé číslo");
int cislo2 = Convert.ToInt32(Console.ReadLine());
// program přečte dvě čísla a seřadí je za sebou
if (cislo1 > cislo2)
{
    Console.WriteLine();
    Console.WriteLine("Výsledky jsou: ");

    Console.WriteLine($"{cislo1}\n{cislo2}");
}
else if (cislo1 < cislo2)
{
    Console.WriteLine();
    Console.WriteLine("Výsledky jsou: ");
    Console.WriteLine($"{cislo2}\n{cislo1}");
}
if (cislo1== cislo2)
{
    Console.WriteLine();
    Console.WriteLine("Výsledky jsou");
    Console.WriteLine("Čísla jsou shodná");

}
else
{
    Console.WriteLine("ahojky ");

}