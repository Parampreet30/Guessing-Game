Random r = new Random();
int rndNumber = r.Next(1,100);
int userGuessNumber;
List<Guess> guessList = new List<Guess>();

do{

  Console.WriteLine("Enter a Number");
  string value = Console.ReadLine();

  if(!int.TryParse(value, out userGuessNumber))
  {
    Console.WriteLine("Enter a number");
  }

  if (userGuessNumber > rndNumber)
  {
    Console.WriteLine("Number is higher");
  }
    else{
        Console.WriteLine("Number is lower");
    }


    int previousguess = guessList.FindIndex(p => p.UserGuess == userGuessNumber);
    if (previousguess != -1)
    {
        int turnsAgo = guessList.Count - previousguess;
        Console.WriteLine($"You guessed this number {turnsAgo} turns ago!");
    }

}
while(userGuessNumber != rndNumber);

Console.WriteLine($"You Won! The answer was {userGuessNumber}.")
