using System;
using QuizAppDATAL;
using QuizAppBUSINESSL;
using QuizAppMODEL;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace QuizAppUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your Username: ");
            string username = Console.ReadLine();
            Console.Write("Input your Password: ");
            string pass = Console.ReadLine();

            UserBusiness user = new UserBusiness();
            bool result = user.UserVerification(username, pass);

            if (result)
            {
                QuizMain();
            }
            else
            {
                Console.WriteLine("USER NOT FOUND, PLEASE INPUT THE CORRECT INFO");
            }
        }
            public static void QuizMain() {
            Console.WriteLine();
            Console.WriteLine("USER FOUND");
            Console.WriteLine();
            Console.WriteLine("WELCOME TO ALL OUT PHILIPPINE HISTORY QUIZ");
                Console.WriteLine();
                Console.WriteLine("ROUND 1:  Write the letter of the correct answer");
                Console.WriteLine();
                DisplayRound1();

                Console.Write("Round 1 Completed. Would you like to proceed to Round 2? (y/n): ");
                string proceedRound2 = Console.ReadLine().ToLower();

                //PROCEED TO ROUND 2
                if (proceedRound2 == "y")
                {
                Console.WriteLine();
                Console.WriteLine("ROUND 2:  Write the letter of the correct answer");
                    Console.WriteLine();
                    DisplayRound2();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }

                //PROCEED TO ROUND 3
                Console.Write("Round 2 Completed. Would you like to proceed to Round 3? y/n): ");
                string proceedRound3 = Console.ReadLine().ToLower();

                if (proceedRound3 == "y")
                {
                Console.WriteLine();
                Console.WriteLine("ROUND 3: Write the letter of the correct answer");
                    Console.WriteLine();
                    DisplayRound3();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }

                //PLAY AGAIN OR NOT
                Console.Write("Would you like to play again? (y/n): ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "y")
                {
                    QuizMain(); // Restart the quiz
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }

            }
        

        public static string DisplayRound1()
        {
            QBusiness quiz = new QBusiness();
            List<string> questions = quiz.GetR1Questions();
            List<string> choices = quiz.GetR1Choices();
            List<string> answers = quiz.GetR1Answers();

            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
               
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                Console.WriteLine($"Choices: {choices[i]}");
                string userAnswer = GetUserAnswer();
                if (userAnswer.ToLower() == answers[i].ToLower())
                {
                    Console.WriteLine("CORRECT!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"INCORRECT. The correct answer is: {answers[i]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Quiz completed! Your final score is: {score}/5");
            Console.WriteLine("Press any key to continue");
            return Console.ReadLine();
        }

        public static string DisplayRound2()
        {
            QBusiness quiz = new QBusiness();
            List<string> questions = quiz.GetR2Questions();
            List<string> choices = quiz.GetR2Choices();
            List<string> answers = quiz.GetR2Answers();

            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                Console.WriteLine($"Choices: {choices[i]}");
                string userAnswer = GetUserAnswer();
                if (userAnswer.ToLower() == answers[i].ToLower())
                {
                    Console.WriteLine("CORRECT!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"INCORRECT. The correct answer is: {answers[i]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Quiz completed! Your final score is: {score}/3");
            Console.WriteLine("Press any key to continue");
            return Console.ReadLine();
        }

        public static string DisplayRound3()
        {
            QBusiness quiz = new QBusiness();
            List<string> questions = quiz.GetR3Questions();
            List<string> choices = quiz.GetR3Choices();
            List<string> answers = quiz.GetR3Answers();

            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                Console.WriteLine($"Choices: {choices[i]}");
                string userAnswer = GetUserAnswer();
                if (userAnswer.ToLower() == answers[i].ToLower())
                {
                    Console.WriteLine("CORRECT!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"INCORRECT. The correct answer is: {answers[i]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"QUIZ COMPLETED! Your final score is: {score}/3");
            Console.WriteLine("Press ENTER to continue");
 
            

            return Console.ReadLine();
        }



        public static string GetUserAnswer()
        {
            Console.WriteLine();
            Console.Write("Your answer: ");
            return Console.ReadLine();
        }
    }
}
