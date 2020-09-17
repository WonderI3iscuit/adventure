using System;

namespace chooseyourownadventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //the adventure begins

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("type y for yes and n for no");
            
            switch (Console.ReadLine())
            {
                case "y":
                    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.You walk towards it.Do you open it or knock ? ");
                    Console.WriteLine("type knock or open");
                    

                    switch (Console.ReadLine().ToLower())
                    {
                        case "knock":
                            Console.WriteLine("A voice behind the door speaks. It says, Answer this riddle: Poor people have it. Rich people need it. If you eat it you die. What is it?");
                            Console.WriteLine("what is your answer?");
                            string riddleAnswer = Console.ReadLine().ToLower();

                            switch (riddleAnswer)
                            {
                                case "nothing":
                                    Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.THE END.");
                                    break;

                                    

                                default:
                                    Console.WriteLine("you die... game over.");
                                    break;
                            }
                            break;
                        
                        case "open":
                            Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                            Console.WriteLine("enter a number, 1 2 or 3");
                            string numSelection = Console.ReadLine().ToLower();

                            switch (numSelection)
                            { 
                                case "1":
                                    Console.WriteLine("You choose the first key, and.... *CLICK* the door swings wide open. the room is empty. Strange... THE END");
                                    break;

                                case "2":
                                    Console.WriteLine("You choose the second key, and... nothing. the door is locked tight. THE END");
                                    break;
                                
                                case "3":
                                    Console.WriteLine("You choose the third key, and... nothing. the door is locked tight. THE END");
                                    break;
                              
                            }
                             
                            break;
                    }





                    break;
                
                case "n":
                    Console.WriteLine("not much of an adventure if we don't leave our room");
                    break;


            }


        }
    }
}