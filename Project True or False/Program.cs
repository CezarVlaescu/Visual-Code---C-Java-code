using System;
using System.Runtime.InteropServices;

namespace TrueOrFalse
{

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin: ");
        string entry = Console.ReadLine();
        Tools.SetUpInputStream(entry);

        // Step 1 : Setup Array of question type string

        string[] questions = new string[] { };

        // Step 2 : Setup Array of answers type bool

        bool[] answers = new bool[] { true, true, false, false, true };

        // Step 3 : Setup Array of responses type bool, empty with lenght = questions.lenght

        bool[] responses = new bool[questions.Length];
        
        // Step 4 : Built an IF statement to check if the lenght of the questions array IS NOT equal to the lenght of answer. IF they are not equal, write a warning.

        if(questions.Length != answers.Length) 
        {
            Console.WriteLine("Warning! The number of answers supplied does not match the number of questions");
        }

        // Step 5 : Loop in question, asking each question and recording the users responses, create a variable askingIndex and set to 0

        int askingIndex = 0;

        foreach(string question in questions)
        {
            // input - the text the user enters , isBool - true ( if the user input can be converted to a boolean, otherwise false ), inputBool - boolean version of user's entry

            string input;
            bool isBool;
            bool inputBool;

            Console.WriteLine(question);

            Console.WriteLine("True or False?");

            input = Console.ReadLine();

            // Step 6: Convert the user input to a boolean

            isBool = Boolean.TryParse(input, out inputBool);

            // Step 7 : If the response is not bool ask to response again in a while loop

            while(!isBool) 
            {
                Console.WriteLine("Please respond with 'True' or 'False'");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
            }

            // Step 8 : Outside the while loop but inside of foreach store user's boolean answer in responses and increment askingIndex with 1;

            responses[askingIndex] = inputBool;
            askingIndex++;

            // Step 9 : Calculate score

            int scoringIndex = 0;
            int score = 0;

            foreach(bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"Input : {response} | Answer : {answer}");

                if(response == answer)
                {
                    score++;
                }

                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length}");

        }

    }
}
}
