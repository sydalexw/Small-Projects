using System;

class MainClass {
  public static void Main (string[] args) {
    NumberofRoots(3, -2, 8);
    NumberofRoots(1, 2, 1);
    NumberofRoots(11, -15, 4);
  }

  public static void NumberofRoots(double a, double b, double c){

   double determinant = b*b - 4*a*c;
   if(determinant > 0)
   Console.WriteLine(" Your polynomial of " + a + "squared + " + b + "x" + "+" + c + " means you have two Roots");

   else if(determinant == 0)
   Console.WriteLine(" Your polynomial of " + a + "squared + " + b + "x" + "+" + c + " means you have 1 Root");

   else
   Console.WriteLine(" Your polynomial of " + a + "squared + " + b + "x" + "+" + c + " means you have Zero Roots");

  }
}