using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)

        {
            bool keepgoing = true;

            string[] students = { "Dakota Slabbekoorn", "Joshua Bultsma", "Tommy Waalkes", "James Dockery", "Maricela Rivera", "KimVy Nguyen" };
            string[] location = { "Kent City", "Grand Rapids", "Raleigh NC", "Grand Rapids, MI", "Morelia , Mex", " Grand Rapids" };
            string[] favoratiefood = { "Pho", "Cheese Tortellini", "Indian Style Chicken Curry", "Cheeseburgers/FrenchFries", "Tacos", "Sushi" };

            int id = 0;
            int studentnumber = 0;
            string name = " ";

            while (keepgoing == true)
            {
                Console.WriteLine("Welcome to our C# class.  Which student would you like to learn more about? (enter a  number 1 - 6)");
                try
                {
                    string input1 = Console.ReadLine();
                    int idparse = int.Parse(input1);
                    int stu = (idparse - 1);

                    id = stu;
                    studentnumber = idparse;

                    string[] firstname = students[id].Split();
                    name = firstname[0];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("I'm sorry that is not a student please enter a number between 1-6");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("I'm sorry that is not a number please try again");
                }

                bool keepgoing1 = true;
                while (keepgoing1 == true)
                {
                    try
                    {
                        Console.WriteLine("Student number " + studentnumber + " is " + students[id] + ". What would you like to know about " + name + " ? (enter “hometown” or “favorite food”)");
                        string answer1 = Console.ReadLine();

                        if (answer1.Contains("hometown"))
                        {
                            Console.WriteLine(students[id] + " homewtown is " + location[id] + " would you like to continue yes/no");
                            string repeat1 = Console.ReadLine();
                            if (repeat1 == "yes")
                            {
                                break;
                            }
                            else if (repeat1 == "no")
                            {
                                keepgoing = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Im sorry that is not a valid answer please answer \"yes\" or \"no\"");
                                continue;
                            }
                        }

                        else if (answer1.Contains("favorite food"))
                        {
                            Console.WriteLine(students[id] + " favorite food is " + favoratiefood[id] + " would you like to continue yes/no");
                            string repeat1 = Console.ReadLine();
                            if (repeat1 == "yes")
                            {
                                break;
                            }
                            else if (repeat1 == "no")
                            {
                                keepgoing = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Im sorry that is not a valid answer please answer \"yes\" or \"no\"");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter either \"hometown or\" \"favorite food\"");
                        }
                    }

                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("I'm sorry that is not a student please enter a number between 1-6");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("I'm sorry that is not a number please try again");
                    }
                }
            }
            Console.WriteLine("Thanks for using our application, Have a wonderful day");
        }
    }
}
