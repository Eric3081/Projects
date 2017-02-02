using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace WorkoutGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> exercises = new List<string>();
            List<string> randomExercises = new List<string>();
            Random randomizer = new Random();

            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Welcome to the 10 minute Workout Generator!");
            Console.Beep(); System.Threading.Thread.Sleep(1000); Console.Beep(); Console.Beep(); Console.Beep();
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            Console.SetCursorPosition(35, 10);
            Console.WriteLine("You never to have to do the same exact workout again!");
            System.Threading.Thread.Sleep(3500);
            Console.Clear();

            Console.SetCursorPosition(20, 10);
            Console.WriteLine("I will generate a new 10 minute workout for you based on the exercises you provide");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("You will do a random exercise for a random interval of time.  Your total workout time will be 10 minutes");
            System.Threading.Thread.Sleep(4500);
            Console.Clear();

            Console.WriteLine("Please enter an exercise(i.e. pushups, jumping jacks, situps etc...)");
            exercises.Add(Console.ReadLine());

            string anotherExercise = "";
            Console.WriteLine("Would you like to add another exercise? [y] or [n]");
            anotherExercise = Console.ReadLine();
            Console.Clear();

            while (anotherExercise == "y")
            {
                Console.WriteLine("Please enter an exercise(i.e. pushups, jumping jacks, etc...");
                exercises.Add(Console.ReadLine());

                Console.WriteLine("Would you like to add another exercise? [y] or [n]");
                anotherExercise = Console.ReadLine();
                Console.Clear();
            }
            int totalTimeInSeconds = 600;

            Console.WriteLine("Press enter when ready to begin");
            Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("3, 2");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("3, 2, 1");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("3, 2, 1, GO!");
            Console.Beep();
            System.Threading.Thread.Sleep(500);

            Console.Clear();

            for (int i = 0; i < exercises.Count; i++)
            {
                randomExercises.Add(exercises[randomizer.Next(0, exercises.Count)]);
            }

            Console.Clear();

            int sumOfTimeOfExercises = 0;
            do
            {
                foreach (string exercise in randomExercises)
                {
                    int timeOfExercies = randomizer.Next(10, 60);
                    sumOfTimeOfExercises += timeOfExercies;
                    while (timeOfExercies > 0 && totalTimeInSeconds != 0)
                    {
                        TimeSpan time2 = TimeSpan.FromSeconds(totalTimeInSeconds);
                        string str = time2.ToString(@"mm\:ss");
                        Console.SetCursorPosition(45, 10);
                        Console.WriteLine(timeOfExercies + " seconds of " + exercise);
                        Console.SetCursorPosition(45, 12);
                        Console.WriteLine("Time remaining: " + str);
                        timeOfExercies--;

                        totalTimeInSeconds--;
                        System.Threading.Thread.Sleep(1000);

                        Console.Clear();
                    }
                    Console.Beep();
                    if (totalTimeInSeconds != 0)
                    {
                        Console.SetCursorPosition(45, 8);
                        Console.WriteLine("Switch Exercise");
                    }
                    else
                    {
                        Console.SetCursorPosition(45, 8);
                        Console.WriteLine("Great Job!");
                    }
                }
            } while (sumOfTimeOfExercises <= 600 && sumOfTimeOfExercises != 0);
        }
    }

}

