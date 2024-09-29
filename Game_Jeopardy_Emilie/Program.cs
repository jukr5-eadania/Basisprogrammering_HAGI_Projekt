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
        static int pointcategory;
        static int myscore = 0;

        static void Main(string[] args)
        {
            //varible list
            int points = 0;
            string answer;
            


            //The intro, how to play and the score 
            Console.WriteLine("Welcome to Jeopardy!\nHow To Play:\nPick a category by typing the corrosponding number\nof what you want to pick.\nRemember to write: what/who is ...");
            Console.WriteLine($"Your Score: {myscore}\n");

            //Ask what category
            //Ask how many points
            //The player should get the question that corrosponds with the choosen points
            Console.WriteLine("What Category do you want?");
            Console.WriteLine("1. Who is that character   2.Where is that character from   3. Horror   4.   5. \n");
            int choosenCategory = Convert.ToInt32(Console.ReadLine());

            switch (choosenCategory)
            {
                case 1: //Who is that character
                    {
                        Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                        pointcategory = Convert.ToInt32(Console.ReadLine());
                        WhoIsThatCharacter();
                        

                        break;
                    }
                case 2: //.Where is that character from
                    {
                        Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                        pointcategory = Convert.ToInt32(Console.ReadLine());
                        WhereIsTheCharacterFrom();

                        break;
                    }
                case 3: //Horror
                    {
                        Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                        pointcategory = Convert.ToInt32(Console.ReadLine());

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                        pointcategory = Convert.ToInt32(Console.ReadLine());

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                        pointcategory = Convert.ToInt32(Console.ReadLine());

                        break;
                    }
            }
            Console.WriteLine("your score: "+myscore);

                    

            
                        
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
        /// The questions/answer system for "Who is that character"
        /// </summary>
        static void WhoIsThatCharacter()
        {
            switch (pointcategory)
            {
                case 1:
                    {
                        Console.WriteLine("The one who always saves Zelda");
                        string myanswer = Console.ReadLine();
                        if(myanswer == AnswerLink)
                        {
                            RightAnswer();
                            myscore = +100;
                        }
                        else
                        {
                            WrongAnswer();
                            myscore = -100;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("A pink boll with a black hole for a stomach");
                        string myanswer = Console.ReadLine();
                        if (myanswer == AnswerKirby)
                        {
                            RightAnswer();
                            myscore = +200; 
                        }
                        else
                        {
                            WrongAnswer();
                            myscore = -200;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Originally a servant of the Dark Master Malefor,\nshe was the main antagonist in The Legend of Spyro: A New Beginning\nuntil she was defeated and freed by Spyro.");
                        string myanswer = Console.ReadLine();
                        if (myanswer == AnswerCynder)
                        {
                            RightAnswer();
                            myscore = +300;
                        }
                        else
                        {
                            WrongAnswer();
                            myscore = -300;
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("He is a student at Shujin Academy\nand a former track star who lives a double life as a Phantom Thief.\nHe is the protagonist's best friend and the Phantom Thieves' charge commander.");
                        string myanswer = Console.ReadLine();
                        if (myanswer == AnswerRyuji)
                        {
                            RightAnswer();
                            myscore = +400;
                        }
                        else
                        {
                            WrongAnswer();
                            myscore = -400;
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("He is a wandering Rito minstrel who will\nplay the accordion and sing an ancient verse to Link,\ntelling him the location of several shrines throughout Hyrule.");
                        string myanswer = Console.ReadLine();
                        if (myanswer == AnswerKass)
                        {
                            RightAnswer();
                            myscore = +500;
                        }
                        else
                        {
                            WrongAnswer();
                            myscore = -500;
                        }
                        break;
                    }
            }

            
        }
        //the answer for WhoIsThatCharacter
        static string AnswerLink = "who is link";
        static string AnswerKirby = "who is kirby";
        static string AnswerCynder = "who is cynder";
        static string AnswerRyuji = "who is ryuji";
        static string AnswerKass = "who is kass";


        /// <summary>
        /// The question/answer system for "Where is that character from
        /// </summary>
        static void WhereIsTheCharacterFrom()
        {
            Console.WriteLine("");
        }
        //the answer for WhereIsTheCharacterFrom
        string Answer1 = "";
        string Answer2 = "";
        string Answer3 = "";
        string Answer4 = "";
        string Answer5 = "";
    }
}
