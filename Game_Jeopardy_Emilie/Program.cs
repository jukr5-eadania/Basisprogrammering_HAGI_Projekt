using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Jeopardy_Emilie
{
    internal class Program
    {
        static string answer;

        static void Main(string[] args)
        {
            //varible list
            int points = 0;
            string answer;
            string myanswer;
            int myscore = 0;
            

            //The intro, how to play and the score 
            Console.WriteLine("Welcome to Jeopardy!\nHow To Play:\nPick a category by typing the corrosponding number\nof what you want to pick.\nRemember to write: What is");
            Console.WriteLine($"Your Score: {myscore}\n");

            //Ask what category
            //Ask how many points
            //The player should get the question that corrosponds with the choosen points
            Console.WriteLine("What Category do you want?");
            Console.WriteLine("1. Dogs   2.Games   3. Cats   4.kfh   5.:)\n");
            int choosenCategory = Convert.ToInt32(Console.ReadLine());

            switch (choosenCategory)
            {
                case 1:
                    {
                        CategoryDogs();
                        myanswer = Console.ReadLine();
                        if (myanswer == DogBreedAnswer)
                        {
                            RightAnswer();
                            myscore = +10;
                        }
                        else
                        {
                            WrongAnswer();
                            myscore = -10;
                        }
                        break;
                    }
                case 2:
                    {

                        break;
                    }
            }
            Console.WriteLine("your score: "+myscore);

            /*CategoryDogs();
            myanswer = Console.ReadLine();

            if (myanswer == DogBreedAnswer)
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }*/
            
            

            
                        
            Console.ReadLine();
        }
        static void WrongAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Answer");
            Console.ResetColor();
            
        }

        static void RightAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ResetColor();
        }

        /// <summary>
        /// The questions for the Dog category
        /// </summary>
        static void CategoryDogs()
        {
            Console.WriteLine("The biggest dog breed");
            
        }
        //the answer for biggest dog breed
        static string DogBreedAnswer = "what is a mastiff";

        static void CategoryGame()
        {
            Console.WriteLine("");
        }
    }
}
