using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace opg_QuizGame
{

    internal class Program
    {
        static int maxLives = 6;
        static void Main(string[] args)
        {
            // Variable liste
            bool play = true;
            bool playAgain = false;
            string response;
            char parsedInput;


            // an empty array for used letters
            List<char> lettersUsed = new List<char>();

            while (play) //The game starts
            {
                int remainingLives = maxLives;
                string word = GetRandomWord();
                StringBuilder hidden = GetHiddenWord(word);


                while (remainingLives > 0)
                {
                    if (playAgain == true)
                    {
                        word = GetRandomWord();
                        hidden = GetHiddenWord(word);
                        playAgain = false;
                    }

                    Console.Clear();
                    Intro(remainingLives, lettersUsed);
                    Console.WriteLine(hidden);


                    //the players input
                    string input = Console.ReadLine();
                    if (input == String.Empty)
                    {
                        Console.WriteLine("You need to write a letter");
                        input = String.Empty;
                        input = Console.ReadLine();

                    }


                    parsedInput = input.ToCharArray()[0]; //parsedInput tager det første bogstav (hvis man er kommet til at skrive flere) og gemmer det som en char


                    if (lettersUsed.Contains(parsedInput))
                    {
                        continue;
                    }
                    else
                    {
                        lettersUsed.Add(parsedInput);

                        if (word.Contains(parsedInput))
                        {
                            int index = 0; //runden vi er nået til

                            foreach (var letter in word)
                            {

                                if (letter == parsedInput)
                                {
                                    hidden[index] = parsedInput; //udskifter "_" med input (bogstav)
                                }
                                index++;
                            }
                        }
                        else
                        {
                            remainingLives--;

                        }
                    }

                    if (!hidden.ToString().Contains("_"))
                    {
                        Console.WriteLine("You Won");

                        //ask the player if they want to play again. if yes (Y) then play stay true, but if no (N) then play turn false
                        Console.WriteLine("Play again? (Y/N)");
                        response = Console.ReadLine();
                        response = response.ToUpper();

                        if (response == "Y")
                        {
                            playAgain = true;
                            remainingLives = 6;
                            lettersUsed.Clear();
                        }
                        else
                        {
                            play = false;
                        }
                    }

                    if (remainingLives == 0)
                    {
                        Console.Clear();
                        Intro(remainingLives, lettersUsed);
                        Console.WriteLine("You Lost");
                        Console.WriteLine("The word was: " + word);
                        //ask the player if they want to play again. if yes (Y) then play stay true, but if no (N) then play turn false
                        Console.WriteLine("Play again? (Y/N)");
                        response = Console.ReadLine();
                        response = response.ToUpper();
                        if (response == "Y")
                        {
                            playAgain = true;
                            remainingLives = 6;
                            lettersUsed.Clear();
                        }
                        else
                        {
                            play = false;
                        }

                    }
                }


            }
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }
        static string GetRandomWord()
        {
            //The Array of 25 words
            string[] wordArray = { "dose", "rack", "budget", "quality", "mill", "neck", "absence", "disagree", "clothes", "ash", "hierarchy", "comfortable", "fever", "formula", "language", "suggest", "decorative", "test", "applaud", "wreck", "explicit", "distributor", "camera", "bench" };

            // The word randomizer. The "string word" calls the wordArray and then in the array pick randomly between the 25 words
            Random randomWord = new Random();
            string word = wordArray[randomWord.Next(0, wordArray.Length)];
            return word;
        }

        /// <summary>
        /// Funktion der gemmer ordet
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        static StringBuilder GetHiddenWord(string word)
        {

            //needs to know how big the word is so we can put in the correct amount of "_"
            int wordLength = word.Length;
            StringBuilder hidden = new StringBuilder();

            for (int i = 0; i < wordLength; i++)
            {
                hidden.Append("_"); //for each character = "_"
            }

            return hidden;
        }

        /// <summary>
        /// Introen sammen med remaining lives
        /// </summary>
        /// <param name="livesRemaining"></param>
        static void Intro(int livesRemaining, List<char> lettersUsed)
        {

            Console.WriteLine("Guess the word\nAll words are in English\nPress a letter and then enter\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Remaining lives: {livesRemaining}\n");
            Console.ResetColor();

            Console.WriteLine("Letters guessed: ");
            Console.WriteLine(string.Join(" ", lettersUsed) + "\n\n");

        }

    }
}