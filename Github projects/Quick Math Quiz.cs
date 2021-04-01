using System;
 
class MainClass {
 public static void Main (string[] args) {
   int num1, num2, score1, answer;
   string response = "";
score1 = 0;


   // VARIABLE DECLARATION:
   // 1. Declare 2 variables to hold the 2 numbers to add. Call them num1, num2.
  
   // 2. Declare the 2 variables we need to allow the user to enter a number.
   // Call them response and answer.
 
   // 3. Declare a variable to keep track of a score, initialized to 0.
 
   // 4. Declare a random number generator.
 Random rng = new Random();
 
   // FIRST QUESTION:
   // 5. Assign new random values to num1, num2.
   // The values should be from 10-99.
 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
   // 6. Display the question to the user.
   // Ex: "33 + 42: "
 Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}

 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);

Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}Console.WriteLine(num1 + "+" + num2);

 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}Console.WriteLine(num1 + "+" + num2);

 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}

 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}
 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}
 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}
 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}
 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}
 num1 = rng.Next(10,99);
 num2 = rng.Next(10,99);
Console.WriteLine(num1 + "+" + num2);
   // 7. Get the answer from the user as an int.
response = Console.ReadLine();
answer = int.Parse(response);
   // 8. Create an if statement that checks if the answer is correct.
if (answer == num1 + num2){
score1 = score1 +1;
Console.WriteLine("Correct");
}
if (answer != num1 + num2){
Console.WriteLine("Incorrect");
}
   // 18. Display the score.
 Console.WriteLine("Here's your score: " + score1);
 
 }
}
 
