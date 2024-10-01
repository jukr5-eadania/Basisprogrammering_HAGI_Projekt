﻿using System;
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
        static bool[] checkCategory = new bool[5];
        static bool[] checkQuestion1 = new bool[5];
        static bool[] checkQuestion2 = new bool[5];
        static bool[] checkQuestion3 = new bool[5];
        static bool[] checkQuestion4 = new bool[5];
        static bool[] checkQuestion5 = new bool[5];


        static void Main(string[] args)
        {
            //varible list
                       
            bool playJeopardy = true;
            string response;
            
            


            //The intro, how to play and the score 
            // I want to showcase the points the player has at the top of the screen
            Console.WriteLine("Welcome to Jeopardy!\nHow To Play:\nPick a category by typing the corrosponding number\nof what you want to pick.\nRemember to write: what/who is ...");
            



            //Ask what category
            //Ask how many points
            //The player should get the question that corrosponds with the choosen points
            /*Console.WriteLine("What Category do you want?");
            Console.WriteLine("1. Who is that character   2.Where is that character from   3. Horror   4.Geography   5. \n");
            int choosenAnswer = Convert.ToInt32(Console.ReadLine());*/

            /*int[] ArrayCategory = new int[] { 1, 2, 3, 4, 5 };*/



            checkCategory[0] = true; checkCategory[1] = true; checkCategory[2] = true; checkCategory[3] = true; checkCategory[4] = true;
            // for category 1
            checkQuestion1[0] = true; checkQuestion1[1] = true; checkQuestion1[2] = true; checkQuestion1[3] = true; checkQuestion1[4] = true;
            // for category 2
            checkQuestion2[0] = true; checkQuestion2[1] = true; checkQuestion2[2] = true; checkQuestion2[3] = true; checkQuestion2[4] = true;
            // for category 3
            checkQuestion3[0] = true; checkQuestion3[1] = true; checkQuestion3[2] = true; checkQuestion3[3] = true; checkQuestion3[4] = true;
            // for category 4
            checkQuestion4[0] = true; checkQuestion4[1] = true; checkQuestion4[2] = true; checkQuestion4[3] = true; checkQuestion4[4] = true;
            // for category 5
            checkQuestion5[0] = true; checkQuestion5[1] = true; checkQuestion5[2] = true; checkQuestion5[3] = true; checkQuestion5[4] = true;


            while (playJeopardy)
            {
                Console.WriteLine($"Your Score: {myscore}\n");

                // tjek om pointcategory er blevet brugt en gang 
                // start med at sætte alle --- til true så de kan åbnes
                Console.WriteLine("What Category do you want?");
                Console.WriteLine("1. Who is that character   2.Where is that character from   3. Horror   4.Geography   5. Who am I?\n");
                int choosenAnswer = Convert.ToInt32(Console.ReadLine());

                switch (choosenAnswer)
                {
                    case 1: //Who is that character
                        {
                            // if all questions have been used (set to false) close the category
                            if (checkQuestion1[0] == false && checkQuestion1[1] == false && checkQuestion1[2] == false && checkQuestion1[3] == false && checkQuestion1[4] == false)
                            {
                                Console.WriteLine("you have already tried all the questions in the category\n");
                                checkCategory[0] = false;
                                break;
                            }
                            
                            Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p\n");
                            pointcategory = Convert.ToInt32(Console.ReadLine());
                            WhoIsThatCharacter();
                             
                            
                            break;
                        }
                    case 2: //.Where is that character from
                        {
                            // if all questions have been used (set to false) close the category
                            if (checkQuestion2[0] == false && checkQuestion2[1] == false && checkQuestion2[2] == false && checkQuestion2[3] == false && checkQuestion2[4] == false)
                            {
                                Console.WriteLine("you have already tried all the questions in the category\n");
                                checkCategory[1] = false;
                                break;
                            }
                            Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                            pointcategory = Convert.ToInt32(Console.ReadLine());
                            WhereIsTheCharacterFrom();

                            break;
                        }
                    case 3: //Horror
                        {
                            // if all questions have been used (set to false) close the category
                            if (checkQuestion3[0] == false && checkQuestion3[1] == false && checkQuestion3[2] == false && checkQuestion3[3] == false && checkQuestion3[4] == false)
                            {
                                Console.WriteLine("you have already tried all the questions in the category\n");
                                checkCategory[2] = false;
                                break;
                            }
                            Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                            pointcategory = Convert.ToInt32(Console.ReadLine());
                            Horror();

                            break;
                        }
                    case 4: // Geography
                        {
                            // if all questions have been used (set to false) close the category
                            if (checkQuestion4[0] == false && checkQuestion4[1] == false && checkQuestion4[2] == false && checkQuestion4[3] == false && checkQuestion4[4] == false)
                            {
                                Console.WriteLine("you have already tried all the questions in the category\n");
                                checkCategory[3] = false;
                                break;
                            }
                            Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                            pointcategory = Convert.ToInt32(Console.ReadLine());
                            Geography();

                            break;
                        }
                    case 5:// Who am i
                        {
                            // if all questions have been used (set to false) close the category
                            if (checkQuestion5[0] == false && checkQuestion5[1] == false && checkQuestion5[2] == false && checkQuestion5[3] == false && checkQuestion5[4] == false)
                            {
                                Console.WriteLine("you have already tried all the questions in the category\n");
                                checkCategory[4] = false;
                                break;
                            }
                            Console.WriteLine("What question do you want\n 1: 100p   2: 200p   3: 300p   4: 400p   5: 500p");
                            pointcategory = Convert.ToInt32(Console.ReadLine());
                            WhoAmI();

                            break;

                        }

                }
                
                //if all categorys has been played ask if the player want to play again or exit
                if (checkCategory[0] == false && checkCategory[1] == false && checkCategory[2] == false && checkCategory[3] == false && checkCategory[4] == false)
                {
                    // ask if player wants to play agian.
                    // if yes reset the game. if no close the game
                    Console.WriteLine("your score: " + myscore);
                    Console.WriteLine("\nplay again? (Y/N)");
                    response = Console.ReadLine();
                    response = response.ToUpper();
                    if (response == "Y")
                    {
                        playJeopardy = true;
                    }
                    else
                    {
                        playJeopardy = false;
                    }
                }
                
            }
            Console.WriteLine("Thanks for playing");           
            Console.ReadKey();
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
        /// The Q/A system for "Who is that character" category  
        /// </summary>
        static void WhoIsThatCharacter()
        {
            switch (pointcategory)
            {
                case 1:
                    {
                        if (checkQuestion1[0] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("The one who always saves Zelda");
                         myanswer = Console.ReadLine();
                        string AnswerLink = "who is link";
                        
                        if (myanswer == AnswerLink)
                        {
                            RightAnswer();
                            myscore += 100;
                            
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerLink);
                            myscore -=100;
                            
                        }
                        checkQuestion1[0] = false;
                        break;
                    }
                case 2:
                    {
                        if (checkQuestion1[1] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("A pink ball with a black hole for a stomach");
                         myanswer = Console.ReadLine();
                        string AnswerKirby = "who is kirby";
                        if (myanswer == AnswerKirby)
                        {
                            RightAnswer();
                            myscore +=200; 
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerKirby);
                            myscore -= 200;
                        }
                        checkQuestion1[1] = false;
                        break;
                    }
                case 3:
                    {
                        if(checkQuestion1[2] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("Originally a servant of the Dark Master Malefor,\nshe was the main antagonist in The Legend of Spyro: A New Beginning\nuntil she was defeated and freed by Spyro.");
                         myanswer = Console.ReadLine();
                        string AnswerCynder = "who is cynder";
                        if (myanswer == AnswerCynder)
                        {
                            RightAnswer();
                            myscore += 300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerCynder);
                            myscore -= 300;
                        }
                        checkQuestion1[2] =false;
                        break;
                    }
                case 4:
                    {
                        if(checkQuestion1[3] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("He is a student at Shujin Academy\nand a former track star who lives a double life as a Phantom Thief.\nHe is the protagonist's best friend and the Phantom Thieves' charge commander.");
                         myanswer = Console.ReadLine();
                        string AnswerRyuji = "who is ryuji";
                        if (myanswer == AnswerRyuji)
                        {
                            RightAnswer();
                            myscore += 400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerRyuji);
                            myscore -= 400;
                        }
                        checkQuestion1[3]= false;
                        break;
                    }
                case 5:
                    {
                        if(checkQuestion1[4] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("He is a wandering Rito minstrel who will\nplay the accordion and sing an ancient verse to Link,\ntelling him the location of several shrines throughout Hyrule.");
                         myanswer = Console.ReadLine();
                        string AnswerKass = "who is kass";
                        if (myanswer == AnswerKass)
                        {
                            RightAnswer();
                            myscore += 500;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerKass);
                            myscore -= 500;
                        }
                        checkQuestion1[4] = false;
                        break;
                    }
            }                        
        }
        
        /// <summary>
        /// The Q/A system for "Where is that character from" category 
        /// </summary>
        static void WhereIsTheCharacterFrom()
        {            
            switch (pointcategory)
            {
                case 1:
                    {
                        if (checkQuestion2[0] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("The game franchises that introduced Gorden Freeman");
                        myanswer = Console.ReadLine();
                        string AnswerHalfLife = "what is half-life";
                        if (myanswer == AnswerHalfLife)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerHalfLife);
                            myscore -= 100;
                        }
                        checkQuestion2[0] = false;
                        break;
                    }
                case 2:
                    {
                        if (checkQuestion2[1] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("Play as an orange cat that got separated from their family/friends");
                        myanswer = Console.ReadLine();
                        string AnswerStray = "what is stray";
                        if (myanswer == AnswerStray)
                        {
                            RightAnswer();
                            myscore += 200;
                        }
                        else
                        {
                              WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerStray);
                            myscore -= 200;
                        }
                        checkQuestion2[1] = false;
                        break;
                    }
                case 3:
                    {
                        if (checkQuestion2[2] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("What game debuted Handsome Jack");
                        myanswer = Console.ReadLine();
                        string AnswerJack = "what is borderlands 2";
                        if (myanswer == AnswerJack)
                        {
                            RightAnswer();
                            myscore += 300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerJack);
                            myscore -= 300;
                        }
                        checkQuestion2[2] = false;
                        break;
                    }
                case 4:
                    {
                        if (checkQuestion2[3] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("The game where you get introduced to the outcast Aloy");
                        myanswer = Console.ReadLine();
                        string AnswerAloy = "what is horizon zero dawn";
                        if (myanswer == AnswerAloy)
                        {
                            RightAnswer();
                            myscore += 400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerAloy);
                            myscore -= 400;
                        }
                        checkQuestion2[3] = false;
                        break;
                    }
                case 5:
                    {
                        if (checkQuestion2[4] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("A young kung-fu student looking for revange.\n Everytime he dies he grows older");
                        myanswer = Console.ReadLine();
                        string AnswerSifu = "what is sifu";
                        if (myanswer == AnswerSifu)
                        {
                            RightAnswer();
                            myscore += 500;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerSifu);
                            myscore -= 500;
                        }
                        checkQuestion2[4] = false;
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
                        if (checkQuestion3[0] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("Space-horror game where player\nis up against (or more like hidding from) a Xenomorph");
                        myanswer = Console.ReadLine();
                        string AnswerAlien = "what is alien: isolation";
                        if (myanswer == AnswerAlien)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerAlien);
                            myscore -= 100;
                        }
                        checkQuestion3[0] = false;
                        break;
                    }
                case 2:
                    {
                        if (checkQuestion3[1] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("Horror game, developed by Konami, that became\nknown for its dystopian city and psychological elements\nthat included a character named Heather Manson");
                        myanswer = Console.ReadLine();
                        string AnswerSilentHill = "what is silent hill 3";
                        if (myanswer == AnswerSilentHill)
                        {
                            RightAnswer();
                            myscore += 200;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerSilentHill);
                            myscore -= 200;
                        }
                        checkQuestion3[1] = false;
                        break;
                    }
                case 3:
                    {
                        if (checkQuestion3[2] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("A popular post-apocalyptic game that has been into a tv-serie");
                        myanswer = Console.ReadLine();
                        string Answer = "what is the last of us";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 300;
                        }
                        checkQuestion3[2] = false;
                        break;
                    }
                case 4:
                    {
                        if (checkQuestion3[3] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("Horror-puzzle game where a tiny child in yellow raincoat\nis trying to escape getting eaten/killed");
                        myanswer = Console.ReadLine();
                        string Answer = "what is little nightmares";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 400;
                        }
                        checkQuestion3[3] = false;
                        break;
                    }
                case 5:
                    {
                        if (checkQuestion3[4] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("horror game franchise where your only weapon is a camera ");
                        myanswer = Console.ReadLine();
                        string Answer = "what is fatal frame";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 500;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 500;
                        }
                        checkQuestion3[4] = false;
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
                        if (checkQuestion4[0] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("What country has inspired the setting for Black Myth: Wukong?");
                        myanswer = Console.ReadLine();
                        string AnswerWukong = "what is china";
                        if (myanswer == AnswerWukong)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerWukong);
                            myscore -= 100;
                        }
                        checkQuestion4[0] = false;
                        break;
                    }
                case 2:
                    {
                        if (checkQuestion4[1] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("In what country does Assasin's Creed: Mirage?");
                        myanswer = Console.ReadLine();
                        string AnswerMirage = "what is iraq";
                        if (myanswer== AnswerMirage)
                        {
                            RightAnswer();
                            myscore += 200;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + AnswerMirage);
                            myscore -= 200;
                        }
                        checkQuestion4[1] = false;
                        break;
                    }
                case 3:
                    {
                        if (checkQuestion4[2] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("In what country does Metal Gear Solid 3: Snake Eaater take place?");
                        myanswer = Console.ReadLine();
                        string Answer = "what is russia";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 300;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 300;
                        }
                        checkQuestion4[2] = false;
                        break;
                    }
                case 4:
                    {
                        if (checkQuestion4[3] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("What country has inspired Tomb Raider (2014) setting");
                        myanswer = Console.ReadLine();
                        string Answer = "what is japan";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 400;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 400;
                        }
                        checkQuestion4[3] = false;
                        break;
                    }
                case 5:
                    {
                        if (checkQuestion4[4] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("What country is Resident Evil 4 set in?");
                        myanswer = Console.ReadLine();
                        string Answer = "what is spain";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 500;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 500;
                        }
                        checkQuestion4[4] = false;
                        break;
                    }
            }
        }
        /// <summary>
        /// The Q/A system for "Who am i" category  
        /// </summary>
        static void WhoAmI()
        {
            switch (pointcategory)
            {
                case 1:
                    {
                        if (checkQuestion5[0] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("I am the one that started the Phantom thieves. I have the abillity to smell treasures.\nBut most importenly i'm NOT a CAT!");
                        myanswer = Console.ReadLine();
                        string Answer = "who is morgana";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 100;
                        }
                        checkQuestion5[0] = false;
                        break;
                    }
                case 2:
                    {
                        if (checkQuestion5[1] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("I'm one of the four Champions of Hyrule and the pilot\nof the Divine Beast Vha Medoh");
                        myanswer = Console.ReadLine();
                        string Answer = "who is revali";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 100;
                        }
                        checkQuestion5[1] = false;
                        break;
                    }
                case 3:
                    {
                        if (checkQuestion5[2] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("I was kidnapped and incarcerated by Abstergo, a Templar organisation,\nand forced into a machine called Animus to relive\nthe genetic memories og my ancestors");
                        myanswer = Console.ReadLine();
                        string Answer = "who is desmond miles";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 100;
                        }
                        checkQuestion5[2] = false;
                        break;
                    }
                case 4:
                    {
                        if (checkQuestion5[3] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("I'm a robot with a SOUL, and i'm the sole tv-star of\nthe Underground. My body was made by Alphys");
                        myanswer = Console.ReadLine();
                        string Answer = "who is mettaton";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 100;
                        }
                        checkQuestion5[3] = false;
                        break;
                    }
                case 5:
                    {
                        if (checkQuestion5[4] == false)
                        {
                            Console.WriteLine("Ups! you have already tried this question\n pick another question");
                            break;
                        }
                        Console.WriteLine("I'm a rapping dog");
                        myanswer = Console.ReadLine();
                        string Answer = "who is parappa the rapper";
                        if (myanswer == Answer)
                        {
                            RightAnswer();
                            myscore += 100;
                        }
                        else
                        {
                            WrongAnswer();
                            Console.WriteLine("The answer was:\n" + Answer);
                            myscore -= 100;
                        }
                        checkQuestion5[4] = false;
                        break;
                    }
            }
        }
        
    }
}

   

