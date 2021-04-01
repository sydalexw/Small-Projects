using System;

class MainClass {
  public static void Main (string[] args) {
Console.BackgroundColor = ConsoleColor.DarkBlue;

    int cat1=0, cat2=0, cat3=0, cat4=0;
    string ans = "";


    ans = Q1();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q2();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q3();
    if(ans=="d")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="a")
    cat4 += 10;

    ans = Q4();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q5();
    if(ans=="c")
    cat1 += 10;
    if(ans=="a")
    cat2 += 10;
    if(ans=="b")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q6();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q7();
    if(ans=="b")
    cat1 += 10;
    if(ans=="d")
    cat2 += 10;
    if(ans=="a")
    cat3 += 10;
    if(ans=="c")
    cat4 += 10;

    ans = Q8();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q9();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

    ans = Q10();
    if(ans=="a")
    cat1 += 10;
    if(ans=="b")
    cat2 += 10;
    if(ans=="c")
    cat3 += 10;
    if(ans=="d")
    cat4 += 10;

if(cat1 >= cat2 && cat1 >= cat3 && cat1 >= cat4)
    Console.WriteLine("Congratulations, you got Rei! She was " + cat1 + " % of your answers");

    if(cat2 >= cat1 && cat2 >= cat3 && cat2 >= cat4)
    Console.WriteLine("Congratulations, you got Shinji! He was " + cat2 + " % of your answers");

    if(cat3 >= cat1 && cat3 >= cat2 && cat3 >= cat4)
    Console.WriteLine("Congratulations, you got Asuka! She was " + cat3 + " % of your answers");

    if(cat4 >= cat1 && cat4 >= cat2 && cat4 >= cat3)
    Console.WriteLine("Congratulations, you got Kaworu! He was " + cat4 + " % of your answers");
  }

  public static string Q1(){
    Console.WriteLine("What is your favorite food");
    Console.WriteLine("A. A nice salad");
    Console.WriteLine("B. Baked chicken");
    Console.WriteLine("C. Fresh fish");
    Console.WriteLine("D. A nice hearty steak");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

    public static string Q2(){
    Console.WriteLine("What would you do if you heard a sound at night?");
    Console.WriteLine("A. Check downstairs");
    Console.WriteLine("B. Go back to sleep");
    Console.WriteLine("C. Call for help");
    Console.WriteLine("D. Hide");
    string returnValue = Console.ReadLine();
    return returnValue;
  }


    public static string Q3(){
    Console.WriteLine("What would you do if you saw a stray cat");
    Console.WriteLine("A. A Leave it, what could I do anyways?");
    Console.WriteLine("B. Try to bring it home with you");
    Console.WriteLine("C. Feed it and leave it be");
    Console.WriteLine("D. Call animal control");
    string returnValue = Console.ReadLine();
    return returnValue;
  }


    public static string Q4(){
    Console.WriteLine("What type of a person would you describe youself as");
    Console.WriteLine("A. Coolheaded sensible person");
    Console.WriteLine("B. To be honest I don't really know");
    Console.WriteLine("C. A slightly less coolheaded person but still successful");
    Console.WriteLine("D. I'm weird at first but sweet if you get to know me");
    string returnValue = Console.ReadLine();
    return returnValue;
  }


    public static string Q5(){
    Console.WriteLine("How would you describe your selfesteem");
    Console.WriteLine("A. Trash");
    Console.WriteLine("B. Depends on the situation");
    Console.WriteLine("C. I'm realistic about myself... I guess");
    Console.WriteLine("D. A I'm mostly confident in myself");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

  public static string Q6(){
    Console.WriteLine("How would you describe what you look for in friends");
    Console.WriteLine("A. ...Friends?");
    Console.WriteLine("B. A few really good friends");
    Console.WriteLine("C. A lot of okay friends");
    Console.WriteLine("D. One best friend");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

  public static string Q7(){
    Console.WriteLine("How's your work ethic");
    Console.WriteLine("A. Pretty okay");
    Console.WriteLine("B. Work is consistent, always");
    Console.WriteLine("C. I get it done, even if it takes a while");
    Console.WriteLine("D. That's a good question...");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

  public static string Q8(){
    Console.WriteLine("How do you feel about your family?");
    Console.WriteLine("A. Not always can you have a good family");
    Console.WriteLine("B. ._. not the best");
    Console.WriteLine("C. Don't have many in mine");
    Console.WriteLine("D. Theyre a weird group to be honest");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

public static string Q9(){
    Console.WriteLine("Who do you dislike in Eva");
    Console.WriteLine("A. Gendo");
    Console.WriteLine("B. Asuka");
    Console.WriteLine("C. Shinji");
    Console.WriteLine("D. Misato");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

  public static string Q10(){
    Console.WriteLine("How bad do you think your results are?");
    Console.WriteLine("A. It's okay, I guess");
    Console.WriteLine("B. I'm scared about this");
    Console.WriteLine("C. Yikes");
    Console.WriteLine("D. I know what I'm going to get anyways");
    string returnValue = Console.ReadLine();
    return returnValue;
  }

  

}