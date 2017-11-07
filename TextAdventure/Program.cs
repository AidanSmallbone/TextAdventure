using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

///Text-based choose you own adventure game
///Aidan Smallbone + Zachary Evans
///ICS3U Unit 3 Summative
///November 2017

namespace TextAdventure
{
    class Program
    {

        ///The "scene" class is used to store the text that the user will see. No logic is performed in this class, simply the code to output text to the console
        ///The voids inside of the "scene" class are numbered based on the order they would appear in the game, but they are also commented to explain what role they play in the story

        public class scene
        {

            public void one() //Welcome screen that shows controls and info about the game
            {
                Console.WriteLine("AIDAN SMALLBONE AND ZACH EVANS");
                Console.WriteLine("ICS3U UNIT THREE SUMMATIVE:");
                Console.WriteLine("FALLOUT 4 THEMED TEXT ADVENTURE GAME");
                Console.WriteLine("");
                Console.WriteLine("CONTROLS:");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 = Z");
                Console.WriteLine("OPTION 2 = X");
                Console.WriteLine("OPTION 3 = C");
                Console.WriteLine("OPTION 4 = V");
                Console.WriteLine("QUIT = ESC");
                Console.WriteLine("");
                Console.WriteLine("PLAY GAME - Z | VIEW INFO - X | EXIT - ESC");
            }

            public void two() //Info screen that has some background about the development of the game
            {
                Console.WriteLine("INFO");
                Console.WriteLine("");
                Console.WriteLine("This game is a classic text-based adventure game based off of Fallout 4.");
                Console.WriteLine("It was written using C# in console and PabloDraw for any ASCII art.");
                Console.WriteLine("");
                Console.WriteLine("There's no formal license to use the game's code, however I don't care");
                Console.WriteLine("what you do with it as long as you give credit.");
                Console.WriteLine("");
                Console.WriteLine("The source code is available on GitHub on @AidanSmallbone");
                Console.WriteLine("");
                Console.WriteLine("EXIT TO MAIN MENU - Z");
            }

            public void four() //First screen when the user starts the game. Sets up the story.
            {
                Console.WriteLine("WELCOME TO THE GAME!");
                Console.WriteLine("");
                Console.WriteLine("YOU WAKE UP FROM A LONG SLEEP, CONFUSED AND TIRED.");
                Console.WriteLine("UPON LOOKING AROUND, YOU DISCOVER YOU ARE IN A DESTROYED FALLOUT SHELTER.");
                Console.WriteLine("YOU DON'T REMEMBER MUCH, BUT YOU CAN TELL YOU'VE BEEN ASLEEP FOR A LONG TIME.");
                Console.WriteLine("YOU THINK YOU REMEMBER A CONSTRUCTION CREW BUILDING A SHELTER IN YOUR NEIGHBORHOOD, BUT THAT'S ALL.");
                Console.WriteLine("");
                Console.WriteLine("MAKE A DECISION:");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 - EXPLORE THE SEEMINGLY ABANDONED FALLOUT SHELTER TO SEE IF YOU CAN FIND ANY SIGNS OF WHAT HAPPENED");
                Console.WriteLine("OPTION 2 - LEAVE THE FALLOUT SHELTER AND TAKE A LOOK AROUND OUTSIDE");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 - Z | OPTION 2 - X | EXIT TO MAIN MENU - ESC");
            }

            public void five() //The user decides to look around the vault to look for resources
            {
                Console.WriteLine("OPTION ONE SELECTED!");
                Console.WriteLine("");
                Console.WriteLine("YOU BEGIN TO LOOK AROUND THE SHELTER FOR ANY SIGNS OF WHAT'S GOING ON.");
                Console.WriteLine("IT LOOKS LIKE IF THERE WERE ANY PEOPLE HERE, THEY'RE LONG GONE NOW.");
                Console.WriteLine("SHELVES LABELLED WITH WHAT THEY ONCE HELD ARE RANSACKED, THE PLACE LOOKS EMPTY");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void seven() //This is a chance based event that allows the user to find a gun, which increases their odds of success later on in the game
            {
                Console.WriteLine("ALTHOUGH ALMOST EVERYTHING ELSE IS GONE, YOU SEE SOMETHING OUT OF THE CORNER OF YOUR EYE");
                Console.WriteLine("IT'S A GUN. IT LOOKS LIKE IT MIGHT HAVE BEEN USED BY SECURITY WHILE THE SHELTER WAS INHABITED.");
                Console.WriteLine("SINCE YOU HAVE NO IDEA WHAT MIGHT BE ON THE OUTSIDE YOU PICK IT UP.");
                Console.WriteLine("LUCKY FIND!");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void eight() //The user is unlucky and doesn't find the gun, so they are left only with the option to leave the vault
            {
                Console.WriteLine("YOU DON'T SEE ANYTHING GOOD, SO YOU DECIDE TO TURN AROUND");
                Console.WriteLine("AND HEAD TOWARDS THE ENTRANCE.");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void nine() //The user discovers their old neighborhood is completely destroyed, and hears a noise coming from where their house once was
            {
                Console.WriteLine("YOU WALK OUT THE DOOR AND SEE WHAT LOOKS LIKE YOUR OLD NEIGHBORHOOD,");
                Console.WriteLine("BUT MOST OF THE HOUSES ARE HEAVILY DAMAGED AND ALL OF THE PLANT LIFE IS DEAD.");
                Console.WriteLine("OBVIOUSLY SOMETHING TERRIBLE HAPPENED, BUT YOU STILL HAVE NO IDEA WHAT.");
                Console.WriteLine("");
                Console.WriteLine("YOU WALK OUT OF THE ENTRANCE WAY AND GET A BETTER LOOK");
                Console.WriteLine("IT MIGHT BE RISKY, BUT YOU DON'T HAVE ANYTHING TO LOSE, SO YOU START WALKING");
                Console.WriteLine("TOWARDS YOUR OLD HOUSE.");
                Console.WriteLine("");
                Console.WriteLine("AS YOU'RE WALKING, YOU HEAR A NOISE. IT SOUNDS LIKE IT MIGHT BE OTHER PEOPLE,");
                Console.WriteLine("AND IT'S COMING FROM RIGHT WHERE YOUR HOUSE WOULD BE.");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 - YOU'RE INTRUIGUED, BUT YOU KNOW IT'S RISKY TO INVESTIGATE,");
                Console.WriteLine("SO YOU HEAD AWAY FROM THE NOISE, AND YOUR OLD NEIGHBORHOOD");
                Console.WriteLine("");
                Console.WriteLine("OPTION 2 - YOU'RE DETERMINED TO FIND OUT WHAT HAPPENED, AND YOU THINK THAT");
                Console.WriteLine("IF THERE'S PEOPLE, THEY MIGHT BE ABLE TO EXPLAIN WHAT'S GOING ON.");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 - Z | OPTION 2 - X");
            }

            public void ten() //The user decides to walk away from their old neighborhood and into the forest to avoid danger
            {
                Console.WriteLine("YOU WALK INTO THE BARREN FOREST TO SEE IF THERE'S ANY RESOURCES THAT MIGHT MAKE YOU MORE EQUIPPED");
                Console.WriteLine("TO DEAL WITH WHATEVER MADE THAT NOISE, INCASE IT/THEY ARE HOSTILE.");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void eleven() //The user is killed by a bloatfly in the forest
            {
                Console.WriteLine("TURNS OUT BEING PREPARED IS GOOD IN THEORY, BUT IN PRACTISE IT DOESN'T WORK OUT.");
                Console.WriteLine("WHILE YOU'RE LOOKING FOR RESOURCES, A BLOATFLY COMES UP BEHIND YOU AND ATTACKS.");
                Console.WriteLine("THE BITE IS A PRETTY BAD ONE, AND YOU BLEED OUT ON THE FOREST FLOOR.");
                Console.WriteLine("");
                Console.WriteLine("YOU DIED.");
                Console.WriteLine("");
                Console.WriteLine("EXIT TO MAIN MENU - ESC");
            }

            public void twelve() //The user heads toward the noise and discovers a pack of raiders
            {
                Console.WriteLine("YOU KNOW IT'S RISKY, BUT YOU'RE DETERMINED TO FIND OUT WHAT HAPPENED.");
                Console.WriteLine("YOU HEAD TOWARDS THE NOISE WITH CAUTION, READY FOR THE WORST.");
                Console.WriteLine("");
                Console.WriteLine("AS YOU GET CLOSER, YOU REALISE IT'S BAD NEWS. THE NOISE WAS BEING MADE BY A GROUP");
                Console.WriteLine("OF PEOPLE, BUT THEY LOOK LIKE THEY'RE UP TO NO GOOD.");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 - TRY TO BEFRIEND THE RAIDERS AND GET INFORMATION AS TO WHAT HAPPENED,");
                Console.WriteLine("AND WHY YOU WERE THE ONLY ONE LEFT IN THE FALLOUT SHELTER.");
                Console.WriteLine("");
                Console.WriteLine("OPTION 2 - YOU DECIDE THAT THE RAIDERS AREN'T THE TYPE TO USE THEIR WORDS, SO YOU");
                Console.WriteLine("DECIDE TO TRY AND SNEAK UP ON THEM AND KILL THEM.");
                Console.WriteLine("");
                Console.WriteLine("OPTION 1 - Z | OPTION 2 - X");
            }

            public void thirteen() //The user tries to befriend the raiders, and they kill the user
            {
                Console.WriteLine("YOU WALK UP TO THE RAIDER CAMP AND TRY TO INTRODUCE YOURSELF.");
                Console.WriteLine("THAT DOESN'T GO TOO WELL, SINCE THE RAIDERS ARE HEAVILY ARMED");
                Console.WriteLine("AND DON'T SEEM TOO HAPPY ABOUT YOUR PRESENCE. THEY SHOOT YOU.");
                Console.WriteLine("");
                Console.WriteLine("YOU DIED.");
                Console.WriteLine("");
                Console.WriteLine("EXIT TO MAIN MENU - ESC");
            }

            public void fourteen() //The user decides to sneak up on the raiders and attempt to kill them
            {
                Console.WriteLine("YOU SNEAK UP BEHIND THE RAIDERS, AND PREPARE TO ATTACK THEM.");
                Console.WriteLine("GOOD THING YOU FOUND THAT GUN EARLIER! YOU LOAD IT UP AND COCK IT.");
                Console.WriteLine("YOU PULL THE TRIGGER, AND...");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void fifteen() //The user didn't find the gun earlier on, so they have to use a rock to attempt to kill the raiders
            {
                Console.WriteLine("YOU SNEAK UP BEHIND THE RAIDERS, AND PREPARE TO ATTACK THEM.");
                Console.WriteLine("YOU DON'T HAVE A WEAPON, SO YOU USE A ROCK.");
                Console.WriteLine("YOU SWING IT OVER YOUR HEAD, AND...");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void sixteen() //This is a chance event dependant on whether or not the user found the gun. If lucky, they kill the raiders.
            {
                Console.WriteLine("YOU DID IT! YOU SUCCESSFULLY KILLED THE RAIDERS, AND CAME OUT UNSCATHED.");
                Console.WriteLine("YOU FIGURE ONE OF THE RAIDERS MIGHT HAVE SOMETHING ON THEM THAT WOULD EXPLAIN WHAT'S GOING ON");
                Console.WriteLine("SO YOU DIG THROUGH THEIR POCKETS.");
                Console.WriteLine("ONE OF THEM HAS A NOTE THAT LOOKS LIKE IT'S PROMISING. IT READS...");
                Console.WriteLine("");
                Console.WriteLine("OK - Z");
            }

            public void seventeen() //This is the event that triggers when the user gets unlucky and fails to kill the raiders
            {
                Console.WriteLine("IT DIDN'T WORK OUT TOO WELL FOR YOU.");
                Console.WriteLine("ONE OF THE RAIDERS SAW YOU AND SHOT YOU BEFORE YOU COULD USE YOUR WEAPON.");
                Console.WriteLine("");
                Console.WriteLine("YOU DIED");
                Console.WriteLine("");
                Console.WriteLine("EXIT TO MAIN MENU - ESC");
            }

            public void eighteen() //This is the endgame screen and the note that the user discovers on the raider when they kill them successfully
            {
                Console.WriteLine("WHEN THE BOMBS DROPPED, MANY WERE ABLE TO GET INTO THEIR DESIGNATED FALLOUT SHELTER ON TIME,");
                Console.WriteLine("BUT SOME OF US WEREN'T AS LUCKY. THOSE WHO DIDN'T DIE INSTANTLY HAD TO HIDE OUT FOR DAYS ON END");
                Console.WriteLine("UNTIL THE DUST SETTLED AND IT WAS SOMEWHAT SAFE TO GO OUTSIDE. EVERYTHING WE KNEW AND LOVED WAS GONE.");
                Console.WriteLine("IN TIMES LIKE THESE, WE HAVE TO DO WHATEVER IT TAKES TO SURVIVE");
                Console.WriteLine("WHETHER THAT MEANS, KILL, STEAL, OR WORSE. SOMETIMES I WISH I HAD DIED IN THE BLAST.");
                Console.WriteLine("");
                Console.WriteLine("- RAIDER ENGINEER");
                Console.WriteLine("");
                Console.WriteLine("WAR, WAR NEVER CHANGES.");
                Console.WriteLine("");
                Console.WriteLine("YOU WON! THANKS FOR PLAYING! PRESS ESC TO RETURN TO THE MAIN MENU.");
            }

        }

        public class method //The "method" class is used to store methods that will be used often throughout the game, such as keeping track of user input or generating a random number
        {
            public int randomOutput; //Variable stores number from random number generator
            public string selectedOption; //Variable stores what option the user selected on a given screen

            public void random() //A random number generator that sets the value of an int to a number between 1-10 when called
            {
                Random random = new Random(); //Creates a new object for us to refer to when we create the random number
                randomOutput = random.Next(1, 11); //Generates a number between 1-10 and sets our variable to that number
            }

            public void input() //switch case statement that checks for user input when needed, this will be used at least once per decision
            {
                ConsoleKeyInfo input;

                input = Console.ReadKey(); 

                switch (input.Key) //takes the key pressed by the user if it's valid and sets the variable to that value
                {
                    case ConsoleKey.Z: //all of the cases set the same variable to the key the user pressed
                        {
                            Console.Write("\b");
                            selectedOption = "Z";
                            break;
                        }

                    case ConsoleKey.X:
                        {
                            Console.Write("\b");
                            selectedOption = "X";
                            break;
                        }

                    case ConsoleKey.C:
                        {
                            Console.Write("\b");
                            selectedOption = "C";
                            break;
                        }

                    case ConsoleKey.V:
                        {
                            Console.Write("\b");
                            selectedOption = "V";
                            break;
                        }

                    case ConsoleKey.Escape:
                        {
                            Console.Write("\b");
                            selectedOption = "Escape";
                            break;
                        }
                }
            }
        }

        static void Main(string[] args) //All methods are called here, as well as some of the logic that only needs to happen once
        {
            SoundPlayer backgroundMusic = new SoundPlayer(); //plays background music
            backgroundMusic.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\theme.wav";
            backgroundMusic.PlayLooping();

            Console.ForegroundColor = ConsoleColor.Green;

            beginning:
            
            scene scene = new scene(); //object to call scene methods
            method method = new method(); //object to call logic methods
            bool weaponObtained = false; //string to keep track of whether the use found a weapon

            scene.one(); //displays the welcome screen
            method.input(); //checks for user input (this is used a ton)

            switch (method.selectedOption) //this switch case checks what option the user selected
            {
                case "X": //displays info screen
                    {
                        Console.Clear();
                        scene.two();
                        method.input();
                        if (method.selectedOption == "Z")
                        {
                            Console.Clear();
                            goto beginning;
                        }
                        break;
                    }

                case "Z": //starts game
                    {
                        Console.Clear();
                        goto startgame;
                    }

                case "Escape": //exits to windows
                    {
                        Environment.Exit(0);
                        break;
                    }
            }

            startgame:

            Console.Clear();
            scene.four(); //launches the first part of the game
            method.input();

            switch (method.selectedOption)
            {
                case "Z": //user decides to explore vault
                    {
                        Console.Clear();
                        scene.five();
                        method.input();
                        if (method.selectedOption == "Z") //user gets some info about the vault
                        {
                            method.random();
                            if (method.randomOutput > 2) //decides whether to give the user a weapon based on random number generation
                            {
                                Console.Clear();
                                scene.seven();
                                weaponObtained = true;
                                method.input();
                                if (method.selectedOption == "Z")
                                {
                                    Console.Clear();
                                    goto outside;
                                }
                            }
                            else //forces the user to go outside of the vault regardless of whether they found a weapon
                            {
                                Console.Clear();
                                scene.eight();
                                method.input();
                                if (method.selectedOption == "Z")
                                {
                                    goto outside;
                                }
                            }
                        }
                        break;
                    }
                case "X": //takes the user outside of the vault since they didn't explore
                    {
                        Console.Clear();
                        goto outside;
                    }
                case "Escape": //takes the user back to the main menu
                    {
                        Console.Clear();
                        goto beginning;
                    }
            }

            outside:

            Console.Clear();
            scene.nine(); //user exits the vault, and hears a noise coming from his old neighborhood. user has to decide whether to investigate
            method.input();

            switch (method.selectedOption)
            {
                case "Z": //user decides not to investigate
                    {
                        Console.Clear();
                        scene.ten();
                        method.input();
                        if (method.selectedOption == "X") //user dies and has to start from beginning
                        {
                            Console.Clear();
                            scene.eleven();
                            method.input();
                            if (method.selectedOption == "Escape")
                            {
                                Console.Clear();
                                goto beginning;
                            }
                        }
                        break;
                    }
                case "X":
                    {
                        goto walktonoise; //user decides to investigate
                    }
            }

            walktonoise:

            Console.Clear();
            scene.twelve();
            method.input();

            switch (method.selectedOption) //user discovers raiders
            {
                case "Z": //tries to befriend raiders
                    {
                        Console.Clear();
                        scene.thirteen();
                        method.input();
                        if (method.selectedOption == "ESC") //dies
                        {
                            Console.Clear();
                            goto beginning;
                        }
                        break;
                    }
                case "X": //sneaks up on raiders
                    {
                        Console.Clear();
                        goto killraiders; //jumps to killing raiders
                    }
            }

            killraiders:

            if (weaponObtained == true) //checks if you got the weapon
            {
                method.random(); 
                if (method.randomOutput > 2) //random number generator for odds of killing raiders
                {
                    Console.Clear();
                    scene.fourteen();
                    method.input();
                    if (method.selectedOption == "Z") //gonna shoot the weapon
                    {
                        Console.Clear();
                        scene.sixteen();
                        method.input();
                        if (method.selectedOption == "Z") //kill the raiders
                        {
                            Console.Clear();
                            scene.eighteen(); //read note
                            method.input();
                            if (method.selectedOption == "Escape") //go back to main screen
                            {
                                Console.Clear();
                                goto beginning;
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();  
                    scene.fourteen(); //doesnt kill raiders
                    method.input();
                    if (method.selectedOption == "Z") 
                    {
                        Console.Clear();
                        scene.seventeen();
                        method.input();
                        if (method.selectedOption == "Escape") //dies
                        {
                            Console.Clear();
                            scene.one();
                            goto beginning; //back to main screen
                        }
                    }
                }
            }
            else
            {
                method.random();
                if (method.randomOutput > 4) //user didn't find weapon, lowers odds of killing raiders
                {
                    Console.Clear();
                    scene.fifteen();
                    method.input();
                    if (method.selectedOption == "Z") //kill raiders
                    {
                        Console.Clear();
                        scene.sixteen();
                        method.input();
                        if (method.selectedOption == "Z") //throw rock
                        {
                            Console.Clear();
                            scene.eighteen();
                            method.input();
                            if (method.selectedOption == "Escape") //finish game
                            {
                                Console.Clear();
                                goto beginning;
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    scene.fifteen();
                    method.input();
                    if (method.selectedOption == "Z") //throw rock
                    {
                        if (method.selectedOption == "Escape") //die
                        {
                            Console.Clear();
                            goto beginning;
                        }
                    }
                }
            } 
        }
    }
}
