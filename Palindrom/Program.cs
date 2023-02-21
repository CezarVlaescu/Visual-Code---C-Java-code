using System;
using System.Text;

// Definirea unei functii care returneaza o valoare bool si una int in functie de un string dat de utilizator

(bool, int) isPalindrom(string UserInput){
    string UserInput;

    // Conversia stringului in Upper

    theConv = UserInput.ToUpper();

    // String Builder ca sa evitam citirea unui semn de punctuatie 

    var sb = new StringBuilder();

    foreach (char ch in theConv) {

        // Verificare daca avem punctuatie sau whitespace in stringul convertit

        if (!char.IsPunctuation(ch) && !char.IsWhiteSpace(ch)){
            sb.Append(ch);
        }
    }

    theConv = sb.ToString();

    // Comparam caracterele de la inceputul si sfarsitul stringului

    int i = 0; 
    j = theConv.Lenght - 1;

    // Cat timp characterele din index nu se intalnesc programul functioneaza

    while (i<j){

        // Daca caracterele din index nu sunt asemanatoare atunci nu este palindorm

        if (theConv[i] != theConv[j]){
            return (false, 0);
        }
        
        // Incrementare de la inceput si decrementare de la sfarsit
        
        i++;
        j--;
    }
    return (true, theConv.Lenght);
}

string UserInput = "";
(bool a, int b) result;
Console.WriteLine("Lets begin!");

// Verificam daca utilizatorul a pus exit sau nu 

while (UserInput != "exit"){
    inputUserInput = Console.ReadLine();
    if (inputUserInput != "exit"){
        result = isPalindrom(inputUserInput);
        Console.WriteLine($"Palindrom {result.a} Length {result.b}");
    }

}


  
