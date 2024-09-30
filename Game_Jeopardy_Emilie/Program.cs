using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Jeopardy_Emilie
{
    internal class Program
    {
        static string myanswer;
        static int pointcategory;
        static int myscore = 0;

        static void Main(string[] args)
        {
            //varible list
            int points = 0;
            
            


            //The intro, how to play and the score 
            // I want to showcase the points the player has at the top of the screen
            Console.WriteLine("Welcome to Jeopardy!\nHow To Play:\nPick a category by typing the corrosponding number\nof what you want to pick.\nRemember to write: what/who is ...");
            Console.WriteLine($"Your Score: {points}\n");

            //Ask what category
            //Ask how many points
            //The player should get the question that corrosponds with the choosen points
            Console.WriteLine("What Category do you want?");
            Console.WriteLine("1. Who is that character   2.Where is that character from   3. Horror   4.Geography   5. \n");
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
                        Horror();

                        break;
                    }
                case 4: // Geography
                    {
                        Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                        pointcategory = Convert.ToInt32(Console.ReadLine());
                        Geography();

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
        /// The questions/answer system for "Who is that character" category  
        /// </summary>
        static void WhoIsThatCharacter()
        {
            switch (pointcategory)
            {
                case 1:
                    {
                        Console.WriteLine("The one who always saves Zelda");
                         myanswer = Console.ReadLine();
                        string AnswerLink = "who is link";
                        if (myanswer == AnswerLink)
                        {
                            RightAnswer();
                            myscore = +100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerLink);
                            myscore = -100;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("A pink boll with a black hole for a stomach");
                         myanswer = Console.ReadLine();
                        string AnswerKirby = "who is kirby";
                        if (myanswer == AnswerKirby)
                        {
                            RightAnswer();
                            myscore = +200; 
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerKirby);
                            myscore = -200;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Originally a servant of the Dark Master Malefor,\nshe was the main antagonist in The Legend of Spyro: A New Beginning\nuntil she was defeated and freed by Spyro.");
                         myanswer = Console.ReadLine();
                        string AnswerCynder = "who is cynder";
                        if (myanswer == AnswerCynder)
                        {
                            RightAnswer();
                            myscore = +300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerCynder);
                            myscore = -300;
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("He is a student at Shujin Academy\nand a former track star who lives a double life as a Phantom Thief.\nHe is the protagonist's best friend and the Phantom Thieves' charge commander.");
                         myanswer = Console.ReadLine();
                        string AnswerRyuji = "who is ryuji";
                        if (myanswer == AnswerRyuji)
                        {
                            RightAnswer();
                            myscore = +400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerRyuji);
                            myscore = -400;
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("He is a wandering Rito minstrel who will\nplay the accordion and sing an ancient verse to Link,\ntelling him the location of several shrines throughout Hyrule.");
                         myanswer = Console.ReadLine();
                        string AnswerKass = "who is kass";
                        if (myanswer == AnswerKass)
                        {
                            RightAnswer();
                            myscore = +500;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerKass);
                            myscore = -500;
                        }
                        break;
                    }
            }                        
        }
        
        /// <summary>
        /// The question/answer system for "Where is that character from" category 
        /// </summary>
        static void WhereIsTheCharacterFrom()
        {            
            switch (pointcategory)
            {
                case 1:
                    {
                        Console.WriteLine("The game franchises that introduced Gorden Freeman");
                        myanswer = Console.ReadLine();
                        string AnswerHalfLife = "what is half-life";
                        if (myanswer == AnswerHalfLife)
                        {
                            RightAnswer();
                            myscore = +100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerHalfLife);
                            myscore = -100;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Play as an orange cat that got separated from their family/friends");
                        myanswer = Console.ReadLine();
                        string AnswerStray = "what is stray";
                        if (myanswer == AnswerStray)
                        {
                            RightAnswer();
                            myscore = +200;
                        }
                        else
                        {
                              WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerStray);
                            myscore = -200;
                      }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("What game debuted Handsome Jack");
                        myanswer = Console.ReadLine();
                        string AnswerJack = "what is borderlands 2";
                        if (myanswer == AnswerJack)
                        {
                            RightAnswer();
                            myscore = +300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerJack);
                            myscore = -300;
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("The game where you get introduced to the outcast Aloy");
                        myanswer = Console.ReadLine();
                        string AnswerAloy = "what is horizon zero dawn";
                        if (myanswer == AnswerAloy)
                        {
                            RightAnswer();
                            myscore = +400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerAloy);
                            myscore = -400;
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("A young kung-fu student looking for revange.\n Everytime he dies he grows older");
                        myanswer = Console.ReadLine();
                        string AnswerSifu = "what is sifu";
                        if (myanswer == AnswerSifu)
                        {
                            RightAnswer();
                            myscore = +500;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerSifu);
                            myscore = -500;
                        }
                        break;
                    }
            }
        }
      

        /// <summary>
        /// The Q/A system for "Horror" category  
        /// </summary>
        static void Horror()
        {
            switch (pointcategory)
            {
                case 1:
                    {
                        Console.WriteLine("Space-horror game where player\nis up against (or more like hidding from) a Xenomorph");
                        myanswer = Console.ReadLine();
                        string AnswerAlien = "what is alien: isolation";
                        if (myanswer == AnswerAlien)
                        {
                            RightAnswer();
                            myscore = +100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerAlien);
                            myscore = -100;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Horror game, developed by Konami, that became\nknown for its dystopian city and psychological elements\nthat included a character named Heather Manson");
                        myanswer = Console.ReadLine();
                        string AnswerSilentHill = "what is silent hill 3";
                        if (myanswer == AnswerSilentHill)
                        {
                            RightAnswer();
                            myscore = +200;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerSilentHill);
                            myscore = -200;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("A popular post-apocalyptic game that has been into a tv-serie");
                        myanswer = Console.ReadLine();
                        string Answer = "what is the last of us";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore = +300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore = -300;
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Horror-puzzle game where a tiny child in yellow raincoat\nis trying to escape getting eaten/killed");
                        myanswer = Console.ReadLine();
                        string Answer = "what is little nightmares";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore = +400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore = -400;
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("horror game franchise where your only weapon is a camera ");
                        myanswer = Console.ReadLine();
                        string Answer = "what is fatal frame";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore = +300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore = -300;
                        }
                        break;
                    }
            }
        }
       
        /// <summary>
        /// The Q/A system for "Geography" category  
        /// </summary>
        static void Geography()
        {
            switch (pointcategory)
            {
                case 1:
                    {
                        Console.WriteLine("What country has inspired the setting for Black Myth: Wukong?");
                        myanswer = Console.ReadLine();
                        string AnswerWukong = "what is china";
                        if (myanswer == AnswerWukong)
                        {
                            RightAnswer();
                            myscore = +100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerWukong);
                            myscore = -100;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("In what country does Assasin's Creed: Mirage?");
                        myanswer = Console.ReadLine();
                        string AnswerMirage = "what is iraq";
                        if (myanswer== AnswerMirage)
                        {
                            RightAnswer();
                            myscore = +200;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerMirage);
                            myscore = -200;
                        }
                        break;
                    }
                case 3:
                    {

                        break;
                    }
            }
        }
        
    }
}

   

