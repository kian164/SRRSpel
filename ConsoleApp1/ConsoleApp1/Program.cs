// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hur många poäng fick du?");
int poäng = int.Parse(Console.ReadLine());
if (poäng == 1)
{
    Console.WriteLine("Du fick E");
}
else if  (poäng == 2)
{
    Console.WriteLine("Du fick C");
}
else if (poäng == 3)
{
    Console.WriteLine("Du fick A");
}
else
{
    Console.WriteLine("Du kan få 1-3 poäng");
}
while (true)
{
    int HT = (50);
    Console.WriteLine("Du ska gissa det hemliga talet");
    int Guess = int.Parse(Console.ReadLine());
    if (Guess > HT)
    {
        Console.WriteLine("Du gissa för högt");
    }
    else if (Guess < HT)
    {
        Console.WriteLine("Du gissa för lågt");
    }
    else if (Guess == HT)
    {
        Console.WriteLine("Grattis, du gissa rätt");
    }
}
