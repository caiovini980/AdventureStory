using System;

namespace AdventureStory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title: The Mysterious Noise
            //Author: Caio Aguiar

            //Start by asking the user's name
            Console.WriteLine("Hello friend, so you are interested to know more about this story, huh?\nOkay then, but I need a little information:\nWhat's your name?");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Alright {name}, welcome to our story!");

            //The noise on the hall
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall.\nDo you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToUpper();
            Console.Clear();

            if(noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room.\nTHE END.");
            }
            
            else if (noiseChoice == "YES")
            {
                //The door choice
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it.Do you open it or knock ? ");
                Console.Write("Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine().ToUpper();
                Console.Clear();

                if (doorChoice == "KNOCK")
                {
                    //the riddle
                    Console.WriteLine("A strong and deep voice behind the door speaks. It says, 'Answer this riddle: '");
                    Console.WriteLine("'Poor people have it. Rich people need it. If you eat it you die. What is it?'");
                    Console.Write("Type your answer");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    Console.Clear();

                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    } else {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
                    }
                }

                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1 - 3) for the key: ");
                    string keyChoice = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch(keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                            Console.WriteLine("The door opens and NOTHING is there. Strange...");
                            Console.WriteLine("You turn off the light and run back to your room and lock the door.\nTHE END.\n");
                            Console.WriteLine("Press ENTER to continue...");
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            Console.WriteLine("You turn off the light and run back to your room and lock the door.\nTHE END.\n");
                            Console.WriteLine("Press ENTER to continue...");
                            Console.ReadLine();
                            break;

                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            Console.WriteLine("You turn off the light and run back to your room and lock the door.\nTHE END.\n");
                            Console.WriteLine("Press ENTER to continue...");
                            Console.ReadLine();
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine($"Well {name}, this story was made early 2021 when the author was studying C#, \nI think that's the correct name of it, I'm a storyteller, not a programmer.\n\nAnyway, the author said that he wants to improve this story with a real narrative, characters and plots.\nSo, if you want to be part of this project, just need to contact him.\nMy time has come {name}, was a pleasure to meet you!\nSee you next time and stay safe.");
                }
            }
        }
    }
}
