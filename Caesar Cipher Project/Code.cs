using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
        'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        Console.WriteLine("Put your secret message here: ");
        string message = Console.ReadLine();

        char[] secretMessage = message.ToCharArray(); 

        char[] encryptedMessage = new char[secretMessage.Length]; 

        for( int i = 0; i < secretMessage.Length; i++)
        {
            
            char letter = secretMessage[i];

            int letterAlphabet = Array.IndexOf(alphabet, letter);

            int newPosition = (letterAlphabet + 3) % 26; // S11

            char letterEncoded = alphabet[newPosition];

            encryptedMessage[i] = letterEncoded;

        }

        string encode = String.Join("", encryptedMessage);
        Console.WriteLine($"Your message is : {encode}");

    }
}
