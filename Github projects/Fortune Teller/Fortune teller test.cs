using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Fortune Teller");
    //Declare your variables up here
    string response;
    string color;
    int num1, num2, num3;


    Console.WriteLine("Pick a color: Red, Green, Blue, or Yellow");
    color = Console.ReadLine();
  
  
    if(color == "red" || color == "green")
      Console.Write("Pick a number, 1,4,5,8: ");
    if(color == "blue" || color == "yellow")
      Console.Write("Pick a number, 2,3,6,7: ");

    response = Console.ReadLine();
    num1 = int.Parse(response);

    if(num1 == 1 || num1 == 5 || num1 == 3 || num1 == 7)
      Console.Write("Pick another number 1,3,5");
    if(num1 == 4 || num1 == 8 || num1 == 2 || num1 == 6)
      Console.Write("Pick another number 2,4,6");

      response = Console.ReadLine();
      num2 = int.Parse(response);
    
    if(num2 == 3 || num2 == 4 || num2 == 6)
      Console.Write("Pick your final number 1,2,3,4");
    if(num2 == 1 || num2 == 2 || num2 == 5)
      Console.Write("Pick your final number 5,6,7,8");

    response = Console.ReadLine();
    num3 = int.Parse(response);

    if(num3 == 1)
    Console.WriteLine("You suck");
    if(num3 == 2)
    Console.WriteLine("You'll have good luck");
    if(num3 == 3)
    Console.WriteLine("You'll have fun in school tomorrow");
    if(num3 == 4)
    Console.WriteLine(":] welp i guess");
    if(num3 == 5)
    Console.WriteLine("Have fun in jail G");
    if(num3 == 6)
    Console.WriteLine("School will suck tomorrow");
    if(num3 == 7)
    Console.WriteLine("Odd flex dude");
    if(num3 == 8)
    Console.WriteLine("You'll win the lottery");
    //ask for a 3rd number

    //Display fortune
  }
}