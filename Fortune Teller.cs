using System;

class MainClass {
  public static void Main (string[] args) {
    string color = "";
    string response = "";
    int num = 0;
    Console.WriteLine ("Pick a color, red, green, yellow, or blue");
    color = Console.ReadLine();

    if(color == "red" || color == "green"){
      Console.Write("Pick a number; 2,3,6,7: ");
    }
    if(color == "blue" || color == "yellow")
    Console.Write("Pick a number; 1,4,5,8: ");

    response = Console.ReadLine();
    num = int.Parse(response);



        if(num == 2 || num ==6 || num == 1 || num == 5){
      Console.Write("Pick a number; 2,3,6,7: ");
    }

    response = Console.ReadLine();
    num = int.Parse(response);

    if(num == 3 || num ==7 || num == 4 || num == 8)
    Console.Write("Pick a number; 1,4,5,8: ");

    response = Console.ReadLine();
    num = int.Parse(response);

        if(num == 2 || num ==6 || num == 1 || num == 5){
      Console.Write("Pick a number; 2,3,6,7: ");
    }
    response = Console.ReadLine();
    num = int.Parse(response);

    if(num == 3 || num ==7 || num == 4 || num == 8)
    Console.Write("Pick a number; 1,4,5,8: ");

    response = Console.ReadLine();
    num = int.Parse(response);

    if(num == 1)
    Console.WriteLine("You'll fall on your face today.");
    if(num == 2)
    Console.WriteLine("You will find $20 on the ground.");
    if(num == 3)
    Console.WriteLine("You will have pizza for dinner, or a picture of pizza for dinner.");
    if(num == 4)
    Console.WriteLine("Your internet will disconnect and your teacher won't believe you");
    if(num == 5)
    Console.WriteLine("The air will be smokey today.");
    if(num == 6)
    Console.WriteLine("You will fail VS.Net");
    if(num == 7)
    Console.WriteLine("Whooop you won the lottery");
    if(num == 8)
    Console.WriteLine("Error: Reading fortune");

  }
}