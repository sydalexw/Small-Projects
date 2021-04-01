using System;

class MainClass {
  public static void Main (string[] args) {
    double a=0, b=0, c=0, angleA=0, angleB=0, angleC=0, p=0;
    string response = "";
    Console.WriteLine("Enter a, 0 if unknown: ");
    response = Console.ReadLine();
    a = double.Parse(response);
    Console.WriteLine("Enter b, 0 if unknown: ");
    response = Console.ReadLine();
    b = double.Parse(response);
    Console.WriteLine("Enter c, 0 if unknown: ");
    response = Console.ReadLine();
    c = double.Parse(response);
    Console.WriteLine("Enter A, 0 if unknown: ");
    response = Console.ReadLine();
    angleA = double.Parse(response);
    Console.WriteLine("Enter B, 0 if unknown: ");
    response = Console.ReadLine();
    angleB = double.Parse(response);
    Console.WriteLine("Enter C, 0 if unknown: ");
    response = Console.ReadLine();
    angleC = double.Parse(response);
    Console.WriteLine("Enter perimeter, 0 if unknown: ");
    response = Console.ReadLine();
    p = double.Parse(response);


    if(angleA==0 && angleB!=0 && angleC!=0)
    angleA = TriangleSum(angleB, angleC);
    if(angleA!=0 && angleB==0 && angleC!=0)
    angleB = TriangleSum(angleA, angleC);
    if(angleA!=0 && angleB!=0 && angleC==0)
    angleC = TriangleSum(angleA, angleB);

    if(a!=0 && b!=0 && c==0 && angleC==90)
    c = PythagoreanTheorem(a, b, c);
    if(a!=0 && b!=0 && c==0 && angleB==90)
    c = PythagoreanTheorem(a, c, b);
    if(a!=0 && b!=0 && c==0 && angleA==90)
    c = PythagoreanTheorem(c, b, a);

    if(a!=0 && b!=0 && c==0 && angleC==90)
    b = PythagoreanTheorem(a, b, c);
    if(a!=0 && b!=0 && c==0 && angleB==90)
    b = PythagoreanTheorem(a, c, b);
    if(a!=0 && b!=0 && c==0 && angleA==90)
    b = PythagoreanTheorem(c, b, a);

    if(a!=0 && b!=0 && c==0 && angleC==90)
    a = PythagoreanTheorem(a, b, c);
    if(a!=0 && b!=0 && c==0 && angleB==90)
    a = PythagoreanTheorem(a, c, b);
    if(a!=0 && b!=0 && c==0 && angleA==90)
    a = PythagoreanTheorem(c, b, a);

    if(a!=0 && b!=0 && c!=0 && p==0)
    p = Perimeter(a, b, c, p);
    if(a==0 && b==0 && c!=0 && p!=0)
    a = Perimeter(a, b, c, p);
    if(a!=0 && b!=0 && c==0 && p!=0)
    b = Perimeter(a, b, c, p);
    if(a!=0 && b!=0 && c==0 && p!=0)
    c = Perimeter(a, b, c, p);

    Console.WriteLine("a: \t\t\t" + a);
    Console.WriteLine("b: \t\t\t" + b);
    Console.WriteLine("c: \t\t\t" + c);
    Console.WriteLine("A: \t\t\t" + angleA);
    Console.WriteLine("B: \t\t\t" + angleB);
    Console.WriteLine("C: \t\t\t" + angleC);
    Console.WriteLine("Perimeter: \t\t\t" + p);


  }
}