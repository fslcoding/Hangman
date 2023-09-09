using System;
using System.IO;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
  {
  string path = "proverbs.csv";

  string[] lines = File.ReadAllLines(path);
  
  //Picks a random number to use to select a proverbs

  Random randNo = new Random();
  int randomNumber = randNo.Next(1,lines.Length);

  string proverb = lines[randomNumber-1];

  Console.WriteLine("Let's play hangman");
  
  bool gameOver = false;
  char letter;
  int numberOfLetters  = 0;

  foreach (char c in proverb)
  {
    numberOfLetters++;
  }

  while(!gameOver)
  {
      Console.WriteLine("Enter a letter");
      letter = Convert.ToChar(Console.ReadLine().ToLower());
      if(proverb.Contains(letter))
      {
        Console.WriteLine("The letter " + letter + " appears in the proverb");
        List<int> positions = new List<int>();
        Console.WriteLine("The letter: " + letter + " can be found in position: " );
        int counter = 0;
        int indexOfLetter = 0;
        foreach(char c in proverb)
        { 
          if(Char.IsLetter(c))
          {
            proverb.
          }
          positionTracker++;
        }

        foreach(int num in positions)
        {
          Console.Write(num);
        }

      }
  }
  }
}
