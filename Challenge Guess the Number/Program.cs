using System;

namespace ChallengeGuesstheNumber {

static void Main(string[] args){

    // Generarea unui numar random intre 0 - 20 si variabila booleana in cazul in care utilizatorul nu ghiceste sa continue jocul

    int theNumber = new Random().Next(20);
    bool keepGoing = true;

    // Ce vede utilizatorul cand deschide programul ( instructiunile jocului )

    Console.WriteLine("Lets play Guess the number");
    Console.WriteLine("I'm thinking of a number between 0 and 20.");
    Console.WriteLine("Guess the number, or -1 to give up");

    // Pastrarea unui track al utilizatorului 

    int numberGuesses = 0;
    int Guesses = 0;

    // Creerea unui do-while loop care se executa de cel putin o data si reprezinta inputul utilizatorului
    
    do{
        Console.WriteLine("What is your guess? : ");
        string userGuess = Console.ReadLine();
        bool result = Int32.TryParse(userGuess, out numberGuesses); // Convertirea stringului dat de utilizator in numar
    
    // Verificam daca ce a pus utilizatorul este un numar, altfel il intrebam

    if (!result){
        Console.WriteLine("There is not a number typed, put a number or end the game!");
    }
    else if (userGuess == -1 ) {

        // Daca utilizatorul pune -1 atunci paraseste jocul
        
        Console.WriteLine($"Good game, try again later. Have a nice day. The number I was thinking : {theNumber}");
        keepGoing = false;
    }
    else {

        // Tinem evidenta decizilor utilizatorului ( incremetam variabila care pastreaza numarul decizilor )

        Guesses++;
        if (userGuess == theNumber){

            // Daca utilizatorul a ghicit numarul atunci ii specificam numarul de incercari si inchidem programul 

            Console.WriteLine($"You got it in {Guesses} guesses");
            keepGoing = false;
        }
        else {

            // Mesaj pentru utilizator care sa il ajute sa ghiceasca numarul ( este mai mare/mic )

            Console.WriteLine("Nope, {0} than that.", userGuess < theNumber ? "higher" : "lower" );
        }
    }
    } while(keepGoing);
    

    
}
}
