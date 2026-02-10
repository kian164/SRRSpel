using System;

namespace EttStegITaget
{
    class Program
    {
        static string name = "Femboy";
        static int comfort = 0;   // hur trygg situationen känns
        static int desire = 0;    // lust
        static int doubt = 0;     // tvekan

        static void Main(string[] args)
        {
            Console.Title = "Ett steg i taget";
            Intro();
            SceneOne();
            SceneTwo();
            Ending();
        }

        static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================");
            Console.WriteLine("        ETT STEG I TAGET");
            Console.WriteLine("=================================");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Alla personer i spelet är 18+.");
            Console.WriteLine("Det här spelet handlar om närhet,");
            Console.WriteLine("osäkerhet och samtycke i verkligheten.");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att börja.");
            Console.ReadKey();
            Console.Clear();
        }

        static void SceneOne()
        {
            Console.WriteLine("SCEN 1");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Du sitter bredvid någon du träffat några gånger.");
            Console.WriteLine("Det är sent. Det är tyst mellan er.");
            Console.WriteLine("Ett ben nuddar ditt.");
            Console.WriteLine();

            Console.WriteLine("Du märker att du tänker mycket:");
            Console.WriteLine("- Vill jag?");
            Console.WriteLine("- Förväntas det något nu?");
            Console.WriteLine("- Kommer det bli konstigt om jag säger något?");
            Console.WriteLine();

            Console.WriteLine("Vad gör du?");
            Console.WriteLine("1. Flyttar dig lite närmare");
            Console.WriteLine("2. Säger: \"Hur känns det här för dig?\"");
            Console.WriteLine("3. Sitter kvar utan att göra något");

            Console.Write("Val (1-3): ");
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "2")
            {
                Console.WriteLine("Du säger det ganska lugnt.");
                Console.WriteLine("Det blir en kort paus.");
                Console.WriteLine("Den andra personen svarar ärligt.");
                Console.WriteLine();
                Console.WriteLine("Det känns mindre spänt efteråt.");

                comfort += 2;
                desire += 1;
                doubt = Math.Max(0, doubt - 1);
            }
            else if (choice == "1")
            {
                Console.WriteLine("Ni sitter närmare nu.");
                Console.WriteLine("Det känns bra, men också lite oklart.");
                Console.WriteLine("Du undrar om ni tolkar situationen lika.");

                desire += 2;
                doubt += 1;
            }
            else
            {
                Console.WriteLine("Inget händer.");
                Console.WriteLine("Stämningen är okej, men lite osäker.");
                Console.WriteLine("Du känner efter mer än du agerar.");

                doubt += 1;
            }

            Pause();
        }

        static void SceneTwo()
        {
            Console.Clear();
            Console.WriteLine("SCEN 2");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Senare samma kväll.");
            Console.WriteLine("Ni kysser varandra långsamt.");
            Console.WriteLine("Det är inte stressigt.");
            Console.WriteLine();

            Console.WriteLine("Samtidigt tänker du:");
            Console.WriteLine("Det här kan bli mer.");
            Console.WriteLine("Men bara om det känns rätt.");
            Console.WriteLine();

            Console.WriteLine("Vad gör du nu?");
            Console.WriteLine("1. Fortsätter utan att säga något");
            Console.WriteLine("2. Säger vad du vill – och frågar vad den andra vill");
            Console.WriteLine("3. Säger att du vill ta en paus");

            Console.Write("Val (1-3): ");
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "2")
            {
                Console.WriteLine("Ni pratar kort, lite trevande.");
                Console.WriteLine("Det är inte perfekt formulerat.");
                Console.WriteLine("Men det är ärligt.");
                Console.WriteLine();
                Console.WriteLine("Efteråt känns allt mer avslappnat.");

                comfort += 3;
                desire += 2;
                doubt = 0;
            }
            else if (choice == "1")
            {
                Console.WriteLine("Det känns intensivt.");
                Console.WriteLine("Men du märker att du inte riktigt slappnar av.");
                Console.WriteLine("Tankarna finns kvar.");

                desire += 2;
                doubt += 2;
            }
            else
            {
                Console.WriteLine("Du säger att du vill stanna upp lite.");
                Console.WriteLine("Den andra personen accepterar det.");
                Console.WriteLine("Det känns både lite tråkigt och tryggt.");

                comfort += 2;
                doubt = Math.Max(0, doubt - 1);
            }

            Pause();
        }

        static void Ending()
        {
            Console.Clear();
            Console.WriteLine("EFTERÅT");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("Så här känns det nu:");
            Console.WriteLine("Trygghet: " + comfort);
            Console.WriteLine("Lust: " + desire);
            Console.WriteLine("Tvekan: " + doubt);
            Console.WriteLine();

            Console.WriteLine("Reflektion:");
            if (comfort >= desire && doubt == 0)
            {
                Console.WriteLine("Det blev en bra upplevelse.");
                Console.WriteLine("Inte för att allt var perfekt,");
                Console.WriteLine("utan för att ni var lyhörda.");
            }
            else if (doubt > comfort)
            {
                Console.WriteLine("Du känner att något var oklart.");
                Console.WriteLine("Det betyder inte att någon gjorde fel.");
                Console.WriteLine("Men det är värt att tänka på.");
            }
            else
            {
                Console.WriteLine("Allt behöver inte hända direkt.");
                Console.WriteLine("Att ta det långsamt är också ett val.");
            }

            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att avsluta.");
            Console.ReadKey();
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
            Console.ReadKey();
        }
    }
}
