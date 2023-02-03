Random RNG = new Random();
bool tryAgain = true;
int min = 1;
int max = 1000;
int number;
int guess;
int guesses;
string response;
while (tryAgain==true)
{
    guess = 0;
    guesses = 0;
    number = RNG.Next(1, 1000 + 1);
    while (guess != number)
    {
        Console.WriteLine("Guess a number between " + min + "-" + max + ":");
        guess = int.Parse(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);
        if (guess > number)
        {
            Console.WriteLine(guess + " is too high");
        }
        else if (number > guess)
        {
            Console.WriteLine(guess + " is too low");
        }
        guesses++;
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("You win! Congratulations!");
    Console.WriteLine("Guesses: "+guesses);

    Console.WriteLine("Would you like to try again? [Y/N]");
    response = Console.ReadLine();
    response = response.ToUpper();
    if (response == "Y")
    {
        tryAgain = true;
    }
    else if (response == "N")
    {
        tryAgain = false;
    }

}
Console.WriteLine("Thank you for playing!");
Console.ReadKey();