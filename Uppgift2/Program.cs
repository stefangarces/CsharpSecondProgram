using System;
using Uppgift2.Calc;


namespace Uppgift2
{
    class Program
    {
        /* TODO
         * 7 Frågor.
         * 5 Matte relaterade frågor.
         * 1 Fråga med 3 stycken true or false frågor.
         * Sista "frågan", ett gissningsspel med slumpmässigt nummer.
         * Kommentarer till koden och test.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 1");
            Console.WriteLine("----------");

            // Jag ville testa för första gången att byta färg på texten.
            // Lyckades sedan göra det, och gjorde det till alla frågor.
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("At a party, everyone shook hands with everybody.");
            Console.WriteLine("There were 66 handshakes.");
            Console.WriteLine("How many people were at the party?");
            Console.ResetColor();
            Console.WriteLine("30 People  [ 1 ]");
            Console.WriteLine("12 People  [ 2 ]");
            Console.WriteLine("14 People  [ 3 ]");

        Quest1:

             int A = Convert.ToInt32(Console.ReadLine());
            if (A == 2)
            {
                Console.WriteLine("Wow, well done!");
                goto Quest2;
            }
            else if (A == 1 || A == 3)
            {
                Console.WriteLine("Wrong answer! GAME OVER...");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("invalid alternative! Try again.");
                goto Quest1;
            }

            Quest2:

            Console.Clear();

            tryAgain2:

                Console.WriteLine("----------");
                Console.WriteLine("QUESTION 2");
                Console.WriteLine("----------");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("If the cost of a baseball bat and a baseball");
                Console.WriteLine("combined is $1.10, and the bat costs 1.00");
                Console.WriteLine("more than the ball, how much is the ball?");
                Console.ResetColor();
                Console.WriteLine("0.10  [ 1 ]");
                Console.WriteLine("1.00  [ 2 ]");
                Console.WriteLine("0.05  [ 3 ]");

                int B = Convert.ToInt32(Console.ReadLine());

                if (B == 3)
                {
                    Console.WriteLine("Great!");
                    goto Quest3;

                }
                else if (B == 2 || B == 1)
                {
                    Console.WriteLine("Oh no, wrong answer! GAME OVER...");
                    System.Environment.Exit(1);

                // Ville hitta ett enkelt sätt att stänga ner programmet om
                // spelaren svarade fel, använde då "System.Environment.Exit(1);"

            }
                else
                {
                    Console.WriteLine("invalid alternative! Try again.");
                    goto tryAgain2;
                }

                Quest3:

                Console.Clear();

        tryAgain3:

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 3");
            Console.WriteLine("----------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2749 + 22854 = ?");
            Console.ResetColor();
            int answer3 = Convert.ToInt32(Console.ReadLine());

            if (25603 == answer3)
            {
                Console.WriteLine("Great!");
                goto Quest4;

            }
            else if (answer3 != 25603)
            {
                Console.WriteLine("Oh no, wrong answer! GAME OVER...");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("invalid alternative! Try again.");
                goto tryAgain3;
            }

        Quest4:

            Console.Clear();

        tryAgain4:

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 4");
            Console.WriteLine("----------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Solve the unfinished equation. What comes next?");
            Console.ResetColor();
            Console.WriteLine("1 = 4");
            Console.WriteLine("2 = 16");
            Console.WriteLine("3 = 64");
            Console.WriteLine("4 = ?");

            int answer4 = Convert.ToInt32(Console.ReadLine());

            if (answer4 == 256)
            {
                Console.WriteLine("Great!");
                goto Quest5;

            }
            else if (answer4 != 256)
            {
                Console.WriteLine("Oh no, wrong answer! GAME OVER...");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("invalid alternative! Try again.");
                goto tryAgain4;
            }

        Quest5:

            Console.Clear();

        tryAgain5:

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 5");
            Console.WriteLine("----------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1.92 / 3 = ?");
            Console.ResetColor();

            String answer5 = (Console.ReadLine());

            if (answer5 == "0.64")
            {
                Console.WriteLine("Great!");
                goto Quest6;

            }
            else if (answer5 != "0.64")
            {
                Console.WriteLine("Oh no, wrong answer! GAME OVER...");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("invalid alternative! Try again.");
                goto tryAgain5;
            }

            Quest6:

            /* Tycker det ger en snyggare look om man tar bort
             * allting från Terminalen när man har gått vidare
             * från en fråga, så jag använder mig av
             * Console.Clear();
             */

            Console.Clear();

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 6");
            Console.WriteLine("----------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Now you are going to get true or false");
            Console.WriteLine("stories, you have three attempts to make it");
            Console.WriteLine("to the last question! Ready?... press enter.");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            TryAgainQuiz1:

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 6");
            Console.WriteLine("----------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A lion's roar can be heard up to eight kilometres away.");
            Console.WriteLine("True or False? (True / False)");
            Console.ResetColor();

            try
            {
                /* Här använde jag mig av "ToUpper" när spelaren ska ge ett svar
                * för att underlätta så att det blir rätt när jag ska jämföra
                * spelarens svar med det som är rätt svar.
                */

                String playerAnswerString = Console.ReadLine().ToUpper();


                if (playerAnswerString == "TRUE")
                {
                    goto LastQuiz;
                }
                else if (playerAnswerString == "FALSE")
                {
                    goto TrueFalse2;
                }
                


            }
            catch
            {
                Console.WriteLine("Invalid answer!");
                goto TryAgainQuiz1;
            }

            Console.Clear();

            TrueFalse2:
            TryAgainQuiz2:

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 6");
            Console.WriteLine("----------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 ATTEMPTS LEFT");
            

            Console.WriteLine("Australia is wider than the moon.");
            Console.WriteLine("True or False? (True / False)");
            Console.ResetColor();

            try
            {

                String playerAnswerString = Console.ReadLine().ToUpper();


                if (playerAnswerString == "TRUE")
                {
                    goto LastQuiz;
                }
                else if (playerAnswerString == "FALSE")
                {
                    goto TrueFalse3;
                }

            }
            catch
            {
                Console.WriteLine("Invalid answer!");
                goto TryAgainQuiz2;
            }

            Console.Clear();

            TrueFalse3:
            TryAgainQuiz3:

            Console.WriteLine("----------");
            Console.WriteLine("QUESTION 6");
            Console.WriteLine("----------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** LAST ATTEMPT ***");
            

            Console.WriteLine("Monaco is the smallest country in the world.");
            Console.WriteLine("True or False? (True / False)");
            Console.ResetColor();

            try
            {
                String playerAnswerString = Console.ReadLine().ToUpper();

                if (playerAnswerString == "FALSE")
                {
                    goto LastQuiz;
                }
                else
                {
                    Console.WriteLine("Wrong answer! GAME OVER...");
                    System.Environment.Exit(1);
                }
            }
            catch
            {
                Console.WriteLine("Invalid answer!");
                goto TryAgainQuiz3;
            }

            LastQuiz:
            Console.Clear();

            {
                Console.WriteLine("--------------");
                Console.WriteLine("THE LAST QUEST");
                Console.WriteLine("--------------");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** BEAT THE COMPUTER! ***");
                Console.WriteLine("The computer have picked a random number");
                Console.WriteLine("between 1-100, you have to guess which number");
                Console.WriteLine("it is, the computer will guide you by telling");
                Console.WriteLine("you if its lower or higher than your previous guess.");
                Console.ResetColor();

                {
                startover:

                    /* Jag ville göra ett gissnings-spel där datorn slumpar en siffra
                    * mellan 1-100, och sedan ska spelaren gissa sig fram till rätt siffra.
                    * Jag visste först inte hur jag skulle göra för att begränsa antalet
                    * gissningar, men jag bröt ner problemet. Först fixa så att jag får 
                    * datorn till att slumpa fram en siffra, och sedan en while if sats där
                    * koden retunerar antingen "HIGHER" eller "LOWER" beroende på vad
                    * användaren har gissat på. Sedan löste jag begränsat antal gissningar 
                    * med att göra en for loop. */

                    try
                    {
                        Random random = new Random();
                        int ReturnV = random.Next(0, 100);

                        int Guess = 0;

                        Console.WriteLine("Start guessing!");

                        for (int i = 0; i < 10; i++)
                        {
                            while (Guess != ReturnV)
                            {
                                Guess = Convert.ToInt32(Console.ReadLine());

                                if (Guess < ReturnV)
                                {
                                    Console.WriteLine("HIGER!", i++);
                                }
                                else if (Guess > ReturnV)
                                {
                                    Console.WriteLine("LOWER!", i++);
                                }
                                else if (Guess == ReturnV)
                                {
                                    Console.WriteLine("YOU HIT BULLS EYE!");
                                    Console.WriteLine(+ReturnV + " is the right number!");
                                }
                                if (i == 6)
                                {
                                    Console.WriteLine("You didn't make it, the right number was " + ReturnV + ". GAME OVER...");
                                    System.Environment.Exit(1);
                                }
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Only numbers please. Lets start over!");
                        goto startover;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Y O U  W O N ! ! !");
                    Console.ResetColor();
                }

            }
        }
    }
}