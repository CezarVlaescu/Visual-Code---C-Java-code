using System.Globalization;

namespace ProjectFortech
{
    class Solution
    {
        static void Main(string[] args){
            
            string keepGoing;
            do 
            {
                Console.WriteLine("Welcome to my converter.Select an option");
                Console.WriteLine("1. Upper a string");
                Console.WriteLine("2. Reverse a string");
                Console.WriteLine("3. Get the number of vowels from string");
                Console.WriteLine("4. Get the number of words from string");
                Console.WriteLine("5. Get the string as title");
                Console.WriteLine("6. Verify if the word is palindrome");
                string choice = Console.ReadLine();
                string userInput = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string result = userInput.ToUpper();
                        Console.WriteLine(result);
                        break;
                    case "2":
                        string reverseString = string.Empty;
                        for (int i = userInput.Length - 1; i >= 0; i--){
                            reverseString += userInput[i];
                        }
                        Console.WriteLine(reverseString);
                        break;
                    case "3":
                        int vowels_count = 0;
                        int len = userInput.Length;
                        for (int i=0; i<len; i++){
                            if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u') {
                                vowels_count++;
                            }
                        }
                        Console.WriteLine(vowels_count);
                        break;
                    case "4":
                        int l = 0;
                        int wrd = 1;
                        while (l < userInput.Length - 1){
                            if (userInput[l]==' ' || userInput[l]=='\n' || userInput[l]=='\t'){
                                wrd ++;
                            }
                            l++;
                        Console.WriteLine(wrd);
                        }
                        break;
                    case "5":
                        string titileCase = new CultureInfo("en").TextInfo.ToTitleCase(userInput.ToLower());
                        Console.WriteLine(titileCase);
                        break;
                    case "6":
                        string revs = "";
                        for (int i = userInput.Length - 1 ; i >= 0; i--){
                            revs += userInput[i].ToString();
                        }
                        if (revs == userInput){
                            Console.WriteLine("Is Palindrome");
                        }
                        else{
                            Console.WriteLine("Is not Palindrome");
                        }
                        break;       
                }
                Console.ReadLine();
                Console.WriteLine("You want to continue? (Yes/No)");
                keepGoing = Console.ReadLine();
            }
            while (keepGoing == "Yes");
        }
    }

}
