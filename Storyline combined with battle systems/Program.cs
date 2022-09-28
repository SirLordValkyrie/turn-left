using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        string movement;
        Boolean right;

        right = false;
        Console.WriteLine("You wake up in the middle of a forest. You're trying to remember what you were doing before you ended up here");
        sleep(5);
        Console.WriteLine("You can't remember what happened but decide that a wonder in the fresh air will help. ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Do you want to walk or stay?");
        Console.ForegroundColor = ConsoleColor.White;
        movement = Console.ReadLine();
        if (movement == "walk") 
        {
            Console.WriteLine("You walk forward and eventually reach a junction, on the left there is more path, on the right there is a house with what looks like to be signs of life");

            sleep(5);
        }
        else
        {
            Console.WriteLine("After a while you realise that nothing is going to happen, please move forward to progress");
            sleep(5);

            Console.WriteLine("You walk forward and eventually reach a junction, on the left there is more path, on the right there is a house with what looks like to be signs of life");
        }
        while (right == false)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Do you want to left or right");
            Console.ForegroundColor = ConsoleColor.White;
            movement = Console.ReadLine();
            if (movement == "right")
            {
                right = true;
            }
            else
            {
                Console.WriteLine("You realise that there isn't anything over here that's of interest so you return to the junction");
                sleep(3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Do you want to left or right");
                Console.ForegroundColor = ConsoleColor.White;
                movement = Console.ReadLine();
                if (movement == "right")
                {
                    right = true;
                }
                else
                {
                    Console.WriteLine("You realise that there isn't anything over here that's of interest so you return to the junction");
                    sleep(3);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Do you want to left or right");
                    Console.ForegroundColor = ConsoleColor.White;
                    movement = Console.ReadLine();
                    if (movement == "right")
                    {
                        right = true;
                    }
                    else
                    {
                        Console.WriteLine("please for the love of god WALK RIGHT, THER IS NOTHING OVER HERE");
                        sleep(3);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Do you want to left or right");
                        Console.ForegroundColor = ConsoleColor.White;
                        movement = Console.ReadLine();
                        if (movement == "right")
                        {
                            right = true;
                        }
                        else
                        {
                            Console.WriteLine("Right this is the end of the rabbit hole, your going back to the junction and YOUR TURNING RIGHT");
                        }
                    }
                }
            }
        }
        Console.WriteLine("You walk toward the house and notice that someone is moving around inside.");
        sleep(3);
        Console.WriteLine("You end up infront of the house");
        while (right == true)
        {
            sleep(3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Are you knocking on the door or walking on");
            Console.ForegroundColor = ConsoleColor.White;
            movement = Console.ReadLine();
            if (movement == "knock")
            {
                right = false;
                Console.WriteLine("you knock on the door and someone answers");
            }
            else
            {
                Console.WriteLine("you realise that the only way to progress is to knock on the door");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Do you knock or walk on");
                Console.ForegroundColor = ConsoleColor.White;
                movement = Console.ReadLine();
                if (movement == "knock")
                {
                    right = false;
                    Console.WriteLine("you knock on the door and someone answers");
                }
                else
                {
                    Console.WriteLine("why are you being so difficult, go back to the house and knock, please");
                }
            }

            sleep(5);
        }
        Console.WriteLine("The person who opens the door is an elf looking creature and they ask you your name");

        sleep(5);
        Console.WriteLine("You say that your name is Aeryn and that you woke up in the middle of the forest not knowing what happened beforehand");

        sleep(5);
        Console.WriteLine("The elf invites you in. ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Do you go inside?");
        Console.ForegroundColor = ConsoleColor.White;
        movement = Console.ReadLine();
        if (movement == "yes")
        {
        }
        else
        {
            Console.WriteLine("The elf grabs you by the arm and tries to pull you in, but fails because your so much taller than them. they say, please come inside, so you walk inside");
        }
        Console.WriteLine("You enter the small home and see that there is a bookshelf and a bed and not much else");

        sleep(5);
        Console.WriteLine("You notice the dog");

        sleep(5);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Do you want to pet the dog");
        Console.ForegroundColor = ConsoleColor.White;
        movement = Console.ReadLine();
        if (movement == "yes")
        {
            Console.WriteLine("You go to pet the dog but it bites you hand, except you don't feel anything because you hand is skeletal");

            sleep(5);
        }
        else
        {
            Console.WriteLine("You ignore the dog");
        }
        Console.WriteLine("Violet wants to join you in your quest to find other people, you see a caslte in the background and you go toward it");

        sleep(5);
        Console.WriteLine("you travel toward it but before you could get there you sense something from within the forest");

        sleep(5);
        Typewrite("Something appears infront of you stopping you from continuing");
        Console.WriteLine("");
        sleep(3);
        Battlesystem();

        sleep(5);
       Typewrite("WOAH, that was a difficult boss, but don't worry you'll face them again");
       Console.WriteLine("");

    }
    
    

public static void Battlesystem()
    {
        int defendchance;
        int playerhealth;
        int enemyhealth;
        int playerstrength;
        int enemystrength;
        int enemychoice;

        playerhealth = 200;
        enemyhealth = 1000;
        playerstrength = 50;
        enemystrength = 100;
        string varFight;

        Typewrite("Does the player want to fight");
        Console.WriteLine("");
        varFight = Console.ReadLine();
        if (varFight == "yes")
        {
            Typewrite("Your enemy approches");
            Console.WriteLine("");
            sleep(3);
            Typewrite("The battle begins");
            Console.WriteLine("");
            while (enemyhealth > 0 && playerhealth > 0)
            {
                playerstrength = 50;
                enemystrength = 100;
                sleep(2);
                Typewrite("Are you attcking or defending");
                Console.WriteLine("");
                string attDef;

                attDef = Console.ReadLine();
                if (attDef == "attack" && playerhealth > 0)
                {
                    Typewrite("you have decided to attack");
                    Console.WriteLine("");
                }
                else
                {
                    defendchance = random.Next(6);
                    if (defendchance < 5)
                    {
                        Typewrite("you have decided to defend");
                        Console.WriteLine("");
                        enemystrength = 0;
                        playerstrength = 0;
                    }
                    else
                    {
                        Typewrite("you failed to defend");
                        Console.WriteLine("");
                    }

                }
                enemychoice = random.Next(2);
                if (enemychoice == 1)
                {
                    Typewrite("Your enemy attacks you");
                    Console.WriteLine("");
                }
                else
                {
                    defendchance = random.Next(6);
                    if (defendchance < 5)
                    {
                        Typewrite("enemy has decided to defend");
                        Console.WriteLine("");
                        enemystrength = 0;
                        playerstrength = 0;
                    }
                    else
                    {
                        Typewrite("enemy failed to defend");
                        Console.WriteLine("");
                    }
                }
                enemyhealth = enemyhealth - playerstrength;
                playerhealth = playerhealth - enemystrength;
                Typewrite("enemy health is " + enemyhealth);
                Console.WriteLine("");
                Typewrite("player health is " + playerhealth);
                Console.WriteLine("");
            }
            if (playerhealth > 0)
            {
                Typewrite("you won the battle");
                Console.WriteLine("");
            }
            else
            {
                Typewrite("The boss is too strong for you right now, come back when you are more geared up");
                Console.WriteLine("");
            }
        }
        else
        {
            Typewrite("you skip the battle");
            Console.WriteLine("");
        }
    }

    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    static void sleep(int sleep)
    {
        Thread.Sleep(sleep * 1000);
    }

    static void Typewrite(string message)
    {
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            System.Threading.Thread.Sleep(40);
        }
    }
}
