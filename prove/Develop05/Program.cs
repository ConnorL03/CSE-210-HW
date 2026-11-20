using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        int totalpoints = 0;
        int choice = 0 ;
        List<Goal> goals = new List<Goal>();
        while (choice != 6)
        {
            Console.WriteLine($"You have {totalpoints} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            // Here I did extra, I researched how to implement "valid choice logic". To check and make sure we get a valid choice 
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
            Console.Write("Select a choice from the menu: ");
            }

            



            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");

                //Here as well
                int goalChoice;
                while (!int.TryParse(Console.ReadLine(), out goalChoice) || goalChoice < 1 || goalChoice > 3)
                {
                    Console.Write("What kind of goal would you like to make? (1-3): ");
                }
                

                if (goalChoice == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What are the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    bool completed = false;

                    SimpleGoal simpleGoal = new SimpleGoal(title, description, points, completed);
                    goals.Add(simpleGoal);
                    
                }
                else if (goalChoice == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What are the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    EternalGoal eternalGoal = new EternalGoal(title, description, points);
                    goals.Add(eternalGoal);
                }
                else if (goalChoice == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int timesToComplete = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse (Console.ReadLine());
                    int timesCompleted = 0;

                    ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, timesToComplete, bonusPoints, timesCompleted);
                    goals.Add(checklistGoal);

                }
            }
            else if (choice == 2)
            {
                int i = 1; 
                foreach (Goal goal in goals)
                {
                    Console.Write($"{i}. ");
                    goal.Display();
                    i++;
                }
                i = 1;
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string savetofilename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(savetofilename))
                {
                    outputFile.WriteLine(totalpoints);
                    foreach(Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.SaveToFileFormat());
                    }
                } 
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string loadfromfilename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadfromfilename);
                totalpoints = int.Parse(lines[0]);

                int totalgoals = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string typeofgoal = parts[0];
                    if(typeofgoal == "SimpleGoal")
                    {
                        string title = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool completed = bool.Parse(parts[4]);
                        SimpleGoal simpleGoal = new SimpleGoal(title, description, points, completed);
                        goals.Add(simpleGoal);

                        totalgoals ++;
                    }
                    else if (typeofgoal == "EternalGoal")
                    {
                        string title = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        EternalGoal eternalGoal = new EternalGoal(title, description, points);
                        goals.Add(eternalGoal);

                        totalgoals ++;
                    }
                    else if (typeofgoal == "ChecklistGoal")
                    {
                        string title = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int bonusPoints = int.Parse(parts[4]);
                        int timesToComplete = int.Parse(parts[5]);
                        int timesCompleted = int.Parse(parts[6]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, timesToComplete, bonusPoints, timesCompleted);
                        goals.Add(checklistGoal);

                        totalgoals ++;
                    }
                    
                }
                Console.WriteLine("Succsess!");
                Console.WriteLine($"You have downloaded: {totalgoals} goals");
            }
            else if (choice == 5)
            {
                // here I did extra to make sure the user doesn't record a goal before they have made any goals
                if (goals.Count == 0)
                {
                    Console.WriteLine("There are no goals to record.");
                    continue;
                }
                
                //here I implemented more "valid choice logic" to make sure the user types enter valid data.
                int goalAcomplished;
                while (!int.TryParse(Console.ReadLine(), out goalAcomplished) || goalAcomplished < 1 || goalAcomplished > goals.Count)
                {
                    Console.Write($"Please enter a goal number from 1 to {goals.Count}: ");
                }
                
                int Index = goalAcomplished - 1;
                Goal TargetGoal = goals[Index];

                if(TargetGoal is SimpleGoal simpleGoal)
                {
                    simpleGoal.IsCompleted = true;
                }

                if(TargetGoal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.UpdateTimesCompleted();
                    totalpoints += checklistGoal.CheckBonusPoints();
                }

                int points = TargetGoal.GetPoints();
                totalpoints += points;
                Console.WriteLine($"Congrats! You have earned {points} points!");
                Console.WriteLine($"You now have {totalpoints} points."); 
            }
        }
        
    }
}