using System.Runtime.CompilerServices;

namespace Projekt1Prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här kommer vi skapa vårt program
            //Välkommen
            Console.WriteLine("Välkommen till spelet 21!");
            Console.WriteLine("REGLER: Du spelar mot DEALER om att komma närmast 21 utan att gå över.");
            Console.WriteLine("Spelet använder tärningar (1 - 6) istället för spelkort.");
            //Start
            Console.WriteLine("---");
            Console.WriteLine("- Skriv 'SPELA' för att spela");
            string MenuChoice = " ";
            while (MenuChoice != "spela")
            {
                MenuChoice = Console.ReadLine();
                MenuChoice.ToLower().Trim();
            }
            //Delar ut
            //Repetera
            bool playStatus = true;
            int cash = 0;
            int bet = 0;
            while (playStatus)
            {
                Console.WriteLine("Hur mycket vill du satsa?");
                bet = int.Parse(Console.ReadLine());
                Console.WriteLine("Två tärningskast var:");

                int PlayerHand = 0;
                int DealerHand = 0;

                Random random = new Random();
                int tärning = random.Next(1, 7);
                PlayerHand = PlayerHand + tärning;
                tärning = 0;
                tärning = random.Next(1, 7);
                PlayerHand = PlayerHand + tärning;
                tärning = 0;

                tärning = random.Next(1, 7);
                DealerHand = DealerHand + tärning;

                Console.WriteLine("SPELARE: " + PlayerHand);
                Console.WriteLine("DEALER: " + DealerHand + " + ?");

                //Spel loop
                string playChoice = "slå";
                int temporaryCounter = 0;
                string result = " ";
                while (playChoice == "slå")
                {
                    if (temporaryCounter == 0)
                    {
                        temporaryCounter = 1;
                    }
                    else
                    {
                        tärning = random.Next(1, 7);
                        PlayerHand = PlayerHand + tärning;
                        Console.WriteLine("SPELARE: " + PlayerHand);
                        Console.WriteLine("DEALER: " + DealerHand + " + ?");
                        if (PlayerHand > 21)
                        {
                            Console.WriteLine("Du blev tjock.");
                            result = "tjock";
                            break;

                        }
                    }
                    Console.WriteLine("Vill du 'SLÅ' (slå ett till slag) eller 'STANNA' (slå inte ett till slag)");
                    playChoice = Console.ReadLine();
                    playChoice.ToLower().Trim();
                    if (playChoice == "stanna")
                    {
                        result = "c";
                    }

                }
                //Dealern spelar
                if (result == "c")
                {
                    while (result == "c")
                    {
                        if (DealerHand <= 18)
                        {
                            Console.WriteLine("DEALER slår...");
                            tärning = random.Next(1, 7);
                            DealerHand = DealerHand + tärning;
                            Console.WriteLine("SPELARE: " + PlayerHand);
                            Console.WriteLine("DEALER: " + DealerHand);
                        }
                        else if (DealerHand > 18 && DealerHand < 22)
                        {
                            Console.WriteLine("DEALER stannar.");
                            result = "cc";
                        }
                        else if (DealerHand > 21)
                        {
                            Console.WriteLine("DEALER blev tjock.");
                            result = "Dtjock";
                        }
                    }
                }

                //Resultat
                if (result == "tjock")
                {
                    Console.WriteLine("DEALER vann.");
                    cash = cash - bet;
                }
                else if (result == "cc")
                {
                    if (PlayerHand > DealerHand)
                    {
                        Console.WriteLine("Spelare vann, du fick närmare 21 än DEALER.");
                        cash = cash + 2 * bet;
                    }
                    else if (DealerHand > PlayerHand)
                    {
                        Console.WriteLine("DEALER vann, DEALER fick närmare 21 än dig.");
                        cash = cash - bet;
                    }
                }
                else if (result == "Dtjock")
                {
                    Console.WriteLine("Spelare vann.");
                    cash = cash + 2 * bet;
                }
                Console.WriteLine("Du har nu: $" + cash + ".");
                Console.WriteLine("Vill du spela igen? (Y / N)");
                string yn = Console.ReadLine();
                yn.ToLower().Trim();
                if (yn == "n")
                {
                    playStatus = false;
                }
                
            }
            


        }
    }
}
