using System;

class MainClass {
  public static void Main (string[] args) {

    string secretWord="";
    string[] letters;
    string[] guess;

    Console.Write("Enter secret word: ");
    secretWord = Console.ReadLine();
    letters = Split(secretWord);
    guess = new string[letters.Length];
    for(int i=0; i<guess.Length; i++){
      guess[i] = "_";
    }
    string[] wrongGuesses = new string[7];
    // either store "A" or ""
    for(int i=0; i<wrongGuesses.Length; i++)
       wrongGuesses[i] = "";
       string letter = "";
       bool foundMatch = false;
       while(WrongGuesses(wrongGuesses) < 7 && NumberOfBlanks(guess) > 0){
         Print(letters, guess, wrongGuesses);
         Console.Write("Enter a letter: ");
         letter = Console.ReadLine().ToUpper();

         // Go through (for loop) and check (if statement)
         
         foundMatch = false;
         for(int i=0; i<letters.Length; i++){
           if(letters[i] == letter){
             // matches
             guess[i] = letter;
             foundMatch = true;
           }
         }
         if(!foundMatch){
           //We didn't find a match
           wrongGuesses[WrongGuesses(wrongGuesses)] = letter;
         }
       }
       Print(letters, guess, wrongGuesses);

  }// End Main()


public static int WrongGuesses(string[] guesses){
  // Given the guesses array, return the number of wrong guesses.
  // IE, return the number of elements that are not "".
  int count = 0;
  for(int i=0; i<guesses.Length; i++){
    if(guesses[i] != "")
    count++;
  }
  return count;
}

public static int NumberOfBlanks(string[] guessingArray){
  // Given the guessing array, {"H", "_"}
  // return the number of blanks.
  int count = 0;
  for(int i=0; i<guessingArray.Length; i++){
    if(guessingArray[i] == "_")
    count++;
  }
 return count;
}


  public static void Print(string [] letters, string[] guess, string[] wrongGuesses){
    /*Console.WriteLine("    ____");
    Console.WriteLine("   |    |");
    Console.WriteLine("   O    |");
    Console.WriteLine("  -|-   |");
    Console.WriteLine("   |    |");
    Console.WriteLine("  / \\   |");*/
    // count wrong guesses;
    int count = 0;
    for(int i=0; i<wrongGuesses.Length; i++){
      if(wrongGuesses[i] != "")
      count++;
    }

    Console.WriteLine("    ____");
    Console.WriteLine("   |    |");

    Console.Write("   ");
    if(count >= 1)
    Console.Write("O");
    else
    Console.Write(" ");
    Console.WriteLine("    |");

    if(count >= 4)
    Console.Write("  -");
    else
    Console.Write("    ");

    if(count >= 2)
    Console.Write("|");
    else
    Console.Write(" ");

    if(count >= 5)
    Console.WriteLine("-  |");
    else
    Console.WriteLine("   |");

    if(count >= 3)
    Console.WriteLine("   |    |");
    else
    Console.WriteLine("        |");
    
    if(count >=6)
    Console.Write("  / ");
    else
    Console.Write("    ");

    if(count >= 7)
    Console.WriteLine("\\   |");
    else
    Console.WriteLine("    |");

    //Wrong guesses:
    Console.WriteLine("\n\n");
    for(int i=0; i<wrongGuesses.Length; i++){
      if(wrongGuesses[i] != "")
      Console.Write(wrongGuesses[i] + "  ");
    }
     
    Console.WriteLine("\n\n");
    for(int i=0; i<guess.Length; i++){
      Console.Write(guess[i] + "  ");
    }

    Console.WriteLine("\n\n");
  }




  public static string[] Split(string word){
    word = word.ToUpper();

    // Find the length of the string, and create an array of that length.
    int length = word.Length;
    string[] rv = new string[length];
    string letter;
    // Make a for loop that goes 0 through (length-1)
    for(int i=0; i<length; i++){
          // Make a letter variable, and make it the letter at index i.
          letter = word.Substring(i, 1);
          // Put that letter into the array at the correct spot.
          rv[i] = letter;

    }
     return rv;
  }
}// End MainClass