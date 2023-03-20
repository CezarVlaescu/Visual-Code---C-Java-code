using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
        'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        // Step 1: Ask the user for a message

        Console.WriteLine("Put your secret message here: ");
        string message = Console.ReadLine();

        // Step 2 : Convert the message into an array of chars

        char[] secretMessage = message.ToCharArray(); 

        // Step 3 : Create an empty array for encrypted messsage, with lenght equal to secretMessage lenght

        char[] encryptedMessage = new char[secretMessage.Length]; 

        // Step 4 : Loop through each character of secretMessage

        for( int i = 0; i < secretMessage.Length; i++)
        {
            // Step 5 : Access the character at position i in secretMessage and store in a variable
            
            char letter = secretMessage[i];

            // Step 6 : Find position of the character in the alphabet and store in a variable

            int letterAlphabet = Array.IndexOf(alphabet, letter);

            // Step 7 : Add 3 to a letter position and store the value in a variable

            int newPosition = (letterAlphabet + 3) % 26; // S11

            // Step 8 : Find the new encrypted character by getting the character in the alphabet with new position

            char letterEncoded = alphabet[newPosition];

            // Step 9 : Add the encrypted charater to the array encrypted. Store the character at the index i

            encryptedMessage[i] = letterEncoded;

        }
        
        // Step 10 : Convert the character array to a string ( String.Join() )

        string encode = String.Join("", encryptedMessage);
        Console.WriteLine($"Your message is : {encode}");

        // Step 11 : Because the alphabet is only 26 letters we need to fix put the modulo 26 at line with (+3)

    }
}using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
        'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        // Step 1: Ask the user for a message

        Console.WriteLine("Put your secret message here: ");
        string message = Console.ReadLine();

        // Step 2 : Convert the message into an array of chars

        char[] secretMessage = message.ToCharArray(); 

        // Step 3 : Create an empty array for encrypted messsage, with lenght equal to secretMessage lenght

        char[] encryptedMessage = new char[secretMessage.Length]; 

        // Step 4 : Loop through each character of secretMessage

        for( int i = 0; i < secretMessage.Length; i++)
        {
            // Step 5 : Access the character at position i in secretMessage and store in a variable
            
            char letter = secretMessage[i];

            // Step 6 : Find position of the character in the alphabet and store in a variable

            int letterAlphabet = Array.IndexOf(alphabet, letter);

            // Step 7 : Add 3 to a letter position and store the value in a variable

            int newPosition = (letterAlphabet + 3) % 26; // S11

            // Step 8 : Find the new encrypted character by getting the character in the alphabet with new position

            char letterEncoded = alphabet[newPosition];

            // Step 9 : Add the encrypted charater to the array encrypted. Store the character at the index i

            encryptedMessage[i] = letterEncoded;

        }
        
        // Step 10 : Convert the character array to a string ( String.Join() )

        string encode = String.Join("", encryptedMessage);
        Console.WriteLine($"Your message is : {encode}");

        // Step 11 : Because the alphabet is only 26 letters we need to fix put the modulo 26 at line with (+3)

    }
}
