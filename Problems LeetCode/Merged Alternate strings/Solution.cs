using System.ComponentModel.Design;

class Program
{
    static public void Main(string[] args)
    {
        //Merged("abc", "pqr");
        Console.WriteLine(Merged("ab", "pq"));
    }

    static public string Merged(string word1, string word2)
    {
        int totalLenght = word1.Length + word2.Length;
        char[] charMerged = new char[totalLenght];

        if(word1.Length < word2.Length) 
        {
            string subword2 = word2.Substring(word1.Length); // rs
            string newWord2 = word2.Substring(0, word1.Length); // pq
            char[] chars1 = word1.ToCharArray(); // 'a' , 'b'
            char[] chars2 = newWord2.ToCharArray(); // 'p' , 'q'
            for (int i = 0; i < chars1.Length; i++)
            {
                // charMerge[0] = 'a', charMerge[1] = 'p'
                // charMerge[2] = 'b', charMerge[3] = 'q'
                // i = 0, i = 1
                // 2 * i , 2 * i + 1
                charMerged[2 * i] = chars1[i];
                charMerged[2 * i + 1] = chars2[i];
            }
            return new string(charMerged) + subword2;
        }
        else if(word2.Length < word1.Length) 
        {
            string subword1 = word1.Substring(word2.Length);
            string newWord1 = word1.Substring(0, word1.Length);
            char[] chars1 = word1.ToCharArray(); 
            char[] chars2 = newWord1.ToCharArray(); 
            for (int i = 0; i < chars1.Length; i++)
            {
                charMerged[2 * i] = chars1[i];
                charMerged[2 * i + 1] = chars2[i];
            }
            return new string(charMerged) + subword1;
        }
        else
        {
            char[] chars1 = word1.ToCharArray(); 
            char[] chars2 = word2.ToCharArray(); 
            for (int i = 0; i < chars1.Length; i++)
            {
                charMerged[2 * i] = chars1[i];
                charMerged[2 * i + 1] = chars2[i];
            }
            return new string(charMerged);
        }

        
    }

}
