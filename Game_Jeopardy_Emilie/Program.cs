using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Jeopardy_Emilie
{
    internal class Program
    {
        static int rightAnswer = 0;
        static int wrongAnswer = 0;
        
        static void Main(string[] args)
        {
            //varible list
            int points = 0;
            int answer;
            int myscore = 0;
            

            //The intro, how to play and the score 
            Console.WriteLine("Welcome to Jeopardy!\nHow To Play:\nPick a category by typing the corrosponding number\nof what you want to pick");
            Console.WriteLine($"Your Score: {myscore}\n\n");
            
            //Ask a question and show 4 diffrent answers
            //See if the choosen answer is correct
            //If yes then gain points. If no then lose ponits
            Console.WriteLine("What year is it?");
            Console.WriteLine("1. 1995     2. 2000\n3. 2024     4. 2025");
            answer = Convert.ToInt32(Console.ReadLine());
            rightAnswer = 3;


            switch (answer)
            {                
                case 1:
                    {
                        WrongAnswer();
                        points = -10;
                        break;
                    }
                case 2:
                    {
                        WrongAnswer();
                        points = -10;
                        break;
                    }
                case 3:
                    {
                        RightAnswer();
                        points = -10;
                        break;
                    }
                case 4:
                    {
                        WrongAnswer();
                        points = -10;
                        break;
                    }

            }
                        
            Console.ReadLine();
        }
        static void WrongAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Answer");
            Console.ResetColor();
            Console.WriteLine($"The anwser was {rightAnswer}");
        }

        static void RightAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ResetColor();
        }
    }
}
