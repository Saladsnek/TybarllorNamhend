using System;

class MainClass
{
    public static void Main(string[] args)
    {


        int n;

        for (n = 1; n <= 10; n++)
        {
            Console.WriteLine(n);
        }


        int m;

        m = 1;
        while (m <= 10)
        {
            Console.WriteLine(m);
            m = m + 1;
        }




        game();
    }


    public static void game()
    {
        string myname;

        Console.WriteLine("Greetings weary traveller, what is thine name?" + "\n");
        myname = Console.ReadLine();
        Console.WriteLine(myname + ", hmm, a peculiar name, I must say. But if that's your name, that's your name" + "\n");
        Console.WriteLine("Say, it is unrealistically dark in here, I cannot see you, would you mind telling me what race you are?" + "\n");
        Console.WriteLine("AVAILABLE RACES: human, elf, orc, displaced, undead, dwarf, drowben" + "\n");
        string race;

        race = Console.ReadLine();

        race = race.ToLower();

        if (race == "human")
        {
            Console.WriteLine("Ah, a courageous " + race + ", it is a pleasure to meet you " + race + " " + myname + "\n");
            Console.WriteLine("AS A HUMAN, YOUR COMMONALITY MAKES YOU OPEN TO MANY ALLIES, BUT ALSO MAKES SOME ENEMIES MORE HOSTILE DUE TO THE HUMANS SELFISH NATURE" + "\n");
        }
        else
        {
            if (race == "elf")
            {
                Console.WriteLine("ah, I see you are a wise " + race + ", it is an honour to meet you " + race + " " + myname + "\n");
                Console.WriteLine("AS AN ELF, YOUR WISDOM ALLOWS YOU TO REASON WITH ENEMIES, BUT FAILING CAUSES ENEMIES TO BE MORE AGGRESSIVE AND DEAL MORE DAMAGE" + "\n");
            }
            else
            {
                if (race == "orc")
                {
                    Console.WriteLine("Hmm, a powerful " + race + ", I should have guessed by the voice. It is a pleasure to meet you " + race + " " + myname + "\n");
                    Console.WriteLine("AS AN ORC, YOU ARE A BRUTAL FIGHTER WHO, AS THEY TAKE MORE DAMAGE, CAN DISH OUT MORE DAMAGE, BUT YOUR LOWER INTELLIGENCE ALLOWS SHOP KEEPS TO SNEAKILY CHARGE MORE FOR THEIR WARES" + "\n");
                }
                else
                {
                    if (race == "displaced")
                    {
                        Console.WriteLine("You are one of those " + race + " automatons from the future? I'd suggest you keep your disguise up " + race + " " + myname + ", people are frequently cautious of your kind" + "\n");
                        Console.WriteLine("AS A DISPLACED, YOU CAN UNDERSTAND AN ENEMIES WEAKNESSES AND STRENGTHS BY A SIMPLE GLANCE, BUT ARE HOSTILE TO ANY FRIENDLY NPC'S IF FOUND WITH YOUR DISGUISE DOWN" + "\n");
                    }
                    else
                    {
                        if (race == "undead")
                        {
                            Console.WriteLine("An " + race + "? a victim of the Necrolyte plague I assume. " + race + " " + myname + "keep your head down, people aren't too used to your kind just yet." + "\n");
                            Console.WriteLine("AS AN UNDEAD, YOU NO LONGER REQUIRE FOOD OR WATER, BUT YOU MUST SEE A HEALER EACH DAY TO REPLENISH YOUR BODY TO PREVENT IT FROM ROTTING AWAY" + "\n");
                        }
                        else
                        {
                            if (race == "dwarf")
                            {
                                Console.WriteLine("A masterful " + race + ", good to meet you " + race + " " + myname + "\n");
                                Console.WriteLine("AS A DWARF, YOUR NATURAL BONUS MASTERY OF COMBAT FORMS PROVIDES A BONUS ATTACK WITH MELEE HITS, BUT YOU REQUIRE MORE FREQUENT RESTS" + "\n");
                            }
                            else
                            {
                                if (race == "drowben")
                                {
                                    Console.WriteLine("A dark, water dwelling " + race + ", it's not every day I meet one of you, keep your dark power to yourself, and you'll be fine " + race + " " + myname + "\n");
                                    Console.WriteLine("AS A DROWBEN, YOU HAVE A NATURAL WATER BREATHING ABILITY AS WELL AS AN AFFINTY TO DARK POWERS, BUT YOU ARE WEAKER TO HOLY POWER AND DRY AREAS" + "\n");
                                }
                            }
                        }
                    }
                }
            }
        }

        string age;
        int newage;

        string sentance = "Say, how old are you?";

        Console.WriteLine(sentance);
        do
        {
            age = Console.ReadLine();

            newage = Int32.Parse(age);
            Console.WriteLine(sentance);
            //sentance ="Really? how old are you?";

        }
        while (newage < 0 || newage > 110);


        Console.WriteLine("And so Adventurer, your journey begins NOW" + "\n");
        Console.WriteLine("Do you want to go left or right?" + "\n");
        string direction;

        direction = Console.ReadLine();
        if (direction == "left")
        {
            Console.WriteLine("You went left" + "\n");
        }
        else
        {
            Console.WriteLine("You went right" + "\n");
        }
    }
}
