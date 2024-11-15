Random r = new Random();
int rndNumber = r.Next(1,100);
int userGuessNumber;
List<Guess> guessList = new List<Guess>();

do{

  Console.WriteLine("Enter a Number");
  string value = Console.ReadLine();

  if(!int.TryParse(value, out userGuessNumber))
  {
    Console.WriteLine("Enter a number")
  }


}
while(userGuessNumber != rndNumber);
