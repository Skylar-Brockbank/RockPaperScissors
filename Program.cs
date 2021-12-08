using Rocky;
using System;

namespace RockPaperScizors
{
  class Program
  {
    public static void Main()
    {
      Scissors ketchum = new Scissors();
      Paper misty = new Paper();
      Rock brock = new Rock();

      Random choice = new Random();
      int option = choice.Next(1,4);

      Console.WriteLine("Welcome to Geodude vs Kartana vs Scizors");
      Console.WriteLine("========================================");
      Console.WriteLine("Choose a Pokemon (rock/paper/scissors)");
      string pokemon = Console.ReadLine().ToLower();

      if(option == 1){
        Console.WriteLine("I chose scissors");
        Console.WriteLine(ketchum.Game(pokemon));
      }else if (option == 2){
        Console.WriteLine("I chose Paper");
        Console.WriteLine(misty.Game(pokemon));
      }else{
        Console.WriteLine("I chose rock");
        Console.WriteLine(brock.Game(pokemon));
      }
      
      Console.WriteLine("___________________________");
      Console.WriteLine("continue?");
      Console.WriteLine("press any key to play again");
      Console.ReadKey();
      Program.Main();
    }
  }
}