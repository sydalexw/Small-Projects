using System;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine("Test code Part 1: Square()");
Console.WriteLine("Expect: The square of 10 is 100");
Square(10);
Console.WriteLine("Expect: The square of 0 is 0");
Square(0);
Console.WriteLine("Expect: The square of -5 is 25");
Square(-5);

Console.WriteLine("\n\nTest code Part 2: ConcatN()");
Console.WriteLine("Expect: AAAAAAAAAA");
ConcatN("A", 10);
Console.WriteLine("Expect: ");
ConcatN("Hello", 0);
Console.WriteLine("Expect: World");
ConcatN("World", 1);

Console.WriteLine("\n\nTest code Part 3: Guess()");
Guess(12); // Type in 13, 11, 12 as in the example above to test.



Console.WriteLine("\n\nTest code Part 4: Factors()");
Console.WriteLine("Expect: 1, 2, 3, 4, 6, 12");
Factors(12);
Console.WriteLine("Expect: 1, 13");
Factors(13);
Console.WriteLine("Expect: 1, 5, 25");
Factors(25);


Console.WriteLine("\n\nTest code Part 5: Prime()");
Console.WriteLine("Expect: 12 is composite");
Prime(12);
Console.WriteLine("Expect: 13 is prime");
Prime(13);
Console.WriteLine("Expect: 25 is composite");
Prime(25);

Signature();

  }




public static void Square(double a){

double ans = a * a;

Console.WriteLine("The square of " + a + " is " + ans);
}



public static void ConcatN(string a, int amount){
  for(int i = 0; i<=amount; i++){
    Console.Write(a);
  }
}

public static void Guess(int actual){
  int given = 0;
  string response = "";

while(given != actual){
  Console.Write("Enter a number: ");
  response = Console.ReadLine();
  given = int.Parse(response);
    if(given > actual)
  Console.WriteLine("Too high!");

  if(given < actual)
  Console.WriteLine("Too low!");
}

if(given == actual)
  Console.WriteLine("Correct");
}



public static void Factors(int whole){

  int fact = 1;
while(fact <= whole){

     Console.WriteLine(fact + " is a factor of " + whole);
     fact++;
   }

  }

  public static void Prime(int num){

   int check = 2;


if(check <= num){
     if(check%num != 0){
     Console.WriteLine("This number is composite");
     check++;
     }
}
        else
     Console.WriteLine("This number is prime");
  }

 public static void Signature(){
    Console.WriteLine("");

    Console.WriteLine("");

    Console.WriteLine("");

    Console.WriteLine("  .-')                _ .-') _       .-') _   ('-.              ");

    Console.WriteLine(" ( OO ).             ( (  OO) )     ( OO ) )_(  OO)             ");

    Console.WriteLine("(_)---\\_)  ,--.   ,--.\\     .'_ ,--./ ,--,'(,------. ,--.   ,--.");

    Console.WriteLine("/    _ |    \\  `.'  / ,`'--..._)|   \\ |  |\\ |  .---'  \\  `.'  / ");

    Console.WriteLine("\\  :` `.  .-')     /  |  |  \\  '|    \\|  | )|  |    .-')     /  ");

    Console.WriteLine(" '..`''.)(OO  \\   /   |  |   ' ||  .     |/(|  '--.(OO  \\   /   ");

    Console.WriteLine(".-._)   \\ |   /  /\\_  |  |   / :|  |\\    |  |  .--' |   /  /\\_  ");

    Console.WriteLine("\\       / `-./  /.__) |  '--'  /|  | \\   |  |  `---.`-./  /.__) ");

    Console.WriteLine(" `-----'    `--'      `-------' `--'  `--'  `------'  `--'      ");

    Console.WriteLine("");

    Console.WriteLine("");

    Console.WriteLine("");

    Console.WriteLine("Thanks for using my program");


  }
  

  
}
