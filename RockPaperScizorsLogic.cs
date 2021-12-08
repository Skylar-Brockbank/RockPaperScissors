namespace Rocky
{
  public class Scissors
  {
    public string Game(string userInput)
    {
      if (userInput == "paper")
      {
        return "You Lose";
      }
      else if (userInput == "rock")
      {
        return "You Win";
      }
      else if (userInput == "scissors")
      {
        return "It's a Tie";
      }
      else
      {
        return "Wrong entry, dingus";
      }
    }
  }
    public class Paper
    {
      public string Game(string userInput)
      {
        if (userInput == "paper")
        {
          return "It's a Tie";
        }
        else if (userInput == "rock")
        {
          return "You Lose";
        }
        else if (userInput == "scissors")
        {
          return "You Win";
        }
        else
        {
          return "Wrong entry, dingus";
        }
      }
    }
    public class Rock
    {
      public string Game(string userInput)
      {
        if (userInput == "paper")
        {
          return "You Win";
        }
        else if (userInput == "rock")
        {
          return "It's a Tie";
        }
        else if (userInput == "scissors")
        {
          return "You Lose";
        }
        else
        {
          return "Wrong entry, dingus";
        }
      }

    }
  }