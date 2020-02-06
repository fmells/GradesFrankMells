using System;

namespace GradesFrankMells
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! I hear you're taking ISM 4300! Congratulations!");
            Console.WriteLine("On a scale of 0 to 100, what score do you expect to get in this class?");
            Console.WriteLine("Enter score below to see what grade this score will result in!");
            string userScore;
            userScore = Console.ReadLine();
            int score;
            score = Convert.ToInt32(userScore);
            if (score >= 98)
            {
                Console.WriteLine("Your score is: A+, fantastic job!");
            }
            else
            {
                if(score < 98 && score >=92)
                {
                    Console.WriteLine("Your score is: A, awesome job!");
                }
                else
                {
                    if(score < 92 && score >= 90)
                    {
                        Console.WriteLine("Your score is: A-, awesome job!");
                    }
                    else
                    {
                        if(score < 89 && score >= 88)
                        {
                            Console.WriteLine("Your score is: B+, good job!");
                        }
                        else
                        {
                            if(score < 87 && score >= 82)
                            {
                                Console.WriteLine("Your score is: B, good job!");
                            }
                            else
                            {
                                if(score < 81 && score >= 80)
                                {
                                    Console.WriteLine("Your score is: B-. good job!");
                                }
                                else
                                {
                                    if(score < 79 && score >= 78)
                                    {
                                        Console.WriteLine("Your score is: C+, you passed!");
                                    }
                                    else
                                    {
                                        if(score < 77 && score >= 72)
                                        {
                                            Console.WriteLine("Your score is: C, you passed!");
                                        }
                                        else
                                        {
                                            if(score < 71 && score >= 70)
                                            {
                                                Console.WriteLine("Your score is: C-, you passed!");
                                            }
                                            else
                                            {
                                                if(score < 69 && score >= 68)
                                                {
                                                    Console.WriteLine("Your score is: D+, sorry but you didn't pass.");
                                                }
                                                else
                                                {
                                                    if(score < 67 && score >= 62)
                                                    {
                                                        Console.WriteLine("Your score is: D, sorry but you didn't pass.");
                                                    }
                                                    else
                                                    {
                                                        if(score < 61 && score >= 60)
                                                        {
                                                            Console.WriteLine("Your score is: D-, sorry but you didn't pass.");
                                                        }
                                                        else
                                                        {
                                                            if (score < 60)
                                                            {
                                                                Console.WriteLine("Sorry, but you failed the class.");
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
