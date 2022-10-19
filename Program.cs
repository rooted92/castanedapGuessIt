//Pedro Castaneda
//10-18-2022
//Guess It Game
//Create a number guessing game with different levels of difficulty you can choose from.

bool run = true;
//bool runLevel = true;

while(run)
{
    Console.WriteLine("Welcome to Guess IT!");
    Console.WriteLine("***CHOOSE LEVEL***");
    Console.WriteLine("---enter number or name of level---");
    Console.WriteLine("1. Easy");
    Console.WriteLine("2. Medium");
    Console.WriteLine("3. Hard");
    Console.WriteLine("4. Custom");
    Console.WriteLine("5. Quit");
    string input = Console.ReadLine().ToLower();
    if(input == "1" || input == "easy")
    {
        Easy();
    }
    else if(input == "2" || input == "medium")
    {
        Medium();
    }
    else if(input == "3" || input == "hard")
    {
        Hard();
    }
    else if(input == "4" || input == "custom")
    {
        Custom();
    }
    else if(input == "5" || input == "quit")
    {
        run = false;
    }
    else
    {
        Console.WriteLine("Invalid entry");
    }
}

void Easy()
{
    bool runLevel = true;
    Random random = new Random();
    int guesses;
    int randomNum;
    while (runLevel)
    {
        int validNum = 0;
        guesses = 0;
        randomNum = random.Next(1, 11);
        Console.WriteLine("*************EASY***************");
        Console.WriteLine("Guess a number from 1 to 10");
        while (validNum != randomNum)
        {
            bool checkGuess = false;
            while(!checkGuess)
            {
                checkGuess = Int32.TryParse(Console.ReadLine(), out validNum);
                if(checkGuess == false)
                {
                    Console.WriteLine("Please enter a number!");
                }
                else
                {
                    checkGuess = true;
                }
            }
            Console.WriteLine($"Players guess: {validNum}");
            if (validNum > randomNum)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (validNum < randomNum)
            {
                Console.WriteLine("Your guess is too low!");
            }
            guesses++;
        }
        Console.WriteLine($"Congrats! You guessed the correct number: {randomNum}");
        Console.WriteLine($"Your guesses: {guesses}");
        bool replay = false;
        while(!replay)
        {
            Console.WriteLine("Play again? (yes or no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes" || userInput == "y")
            {
                replay = true;
                runLevel = true;
            }
            else if(userInput == "no" || userInput == "n")
            {
                replay = true;
                runLevel = false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no");
                replay = false;
            }
        }
    }
}

void Medium()
{
    bool runLevel = true;
    Random random = new Random();
    int guesses;
    int randomNum;
    while (runLevel)
    {
        int validNum = 0;
        guesses = 0;
        randomNum = random.Next(1, 51);
        Console.WriteLine("*************MEDIUM***************");
        Console.WriteLine("Guess a number from 1 to 50");
        while (validNum != randomNum)
        {
            bool checkNum = false;
            while(!checkNum)
            {
                checkNum = Int32.TryParse(Console.ReadLine(), out validNum);
                if(checkNum == false)
                {
                    Console.WriteLine("Please enter a number!");
                    checkNum = false;
                }
                else
                {
                    checkNum = true;
                }
            }
            Console.WriteLine($"Players guess: {validNum}");

            if (validNum > randomNum)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (validNum < randomNum)
            {
                Console.WriteLine("Your guess is too low!");
            }
            guesses++;
        }
        Console.WriteLine($"Congrats! You guessed the correct number: {randomNum}");
        Console.WriteLine($"Your guesses: {guesses}");
        bool replay = false;
        while(!replay)
        {
            Console.WriteLine("Play again? (yes or no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes" || userInput == "y")
            {
                replay = true;
                runLevel = true;
            }
            else if(userInput == "no" || userInput == "n")
            {
                replay = true;
                runLevel = false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no");
                replay = false;
            }
        }
    }
}

void Hard()
{
    bool runLevel = true;
    Random random = new Random();
    int guesses;
    int randomNum;

    while (runLevel)
    {
        int validNum = 0;
        guesses = 0;
        randomNum = random.Next(1, 101);
        Console.WriteLine("*************HARD***************");
        Console.WriteLine("Guess a number from 1 to 100");
        while (validNum != randomNum)
        {
            bool checkNum = false;
            while(!checkNum)
            {
                checkNum = Int32.TryParse(Console.ReadLine(), out validNum);
                if(checkNum == false)
                {
                    Console.WriteLine("Please enter a number!");
                    checkNum = false;
                }
                else
                {
                    checkNum = true;
                }
            }
            Console.WriteLine($"Players guess: {validNum}");
            if (validNum > randomNum)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (validNum < randomNum)
            {
                Console.WriteLine("Your guess is too low!");
            }
            guesses++;
        }
        Console.WriteLine($"Congrats! You guessed the correct number: {randomNum}");
        Console.WriteLine($"Your guesses: {guesses}");
        bool replay = false;
        while(!replay)
        {
            Console.WriteLine("Play again? (yes or no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes" || userInput == "y")
            {
                replay = true;
                runLevel = true;
            }
            else if(userInput == "no" || userInput == "n")
            {
                replay = true;
                runLevel = false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no");
                replay = false;
            }
        }
    }
}

void Custom()
{
    bool runLevel = true;
    Random random = new Random();
    int guesses = 0;
    int randomNum;
    while (runLevel)
    {
        int validNum = 0;
        int min = 0;
        int max = 0;
        bool checkMin = false;
        bool checkMax = false;
        bool checkValue = false;
        Console.WriteLine("**************CUSTOM MODE*********************");
        Console.WriteLine("Pick a minumum and maximum number you'd like to guess between");
        Console.WriteLine("Enter minimum number:");
        while(!checkMin)
        {
            checkMin = Int32.TryParse(Console.ReadLine(), out min);
            if(checkMin == false)
            {
                Console.WriteLine("Please enter a number!");
                checkMin = false;
            }
            else
            {
                checkMin = true;
            }
        }
        Console.WriteLine("Enter maximum number");
        while(!checkMax)
        {
            checkMax = Int32.TryParse(Console.ReadLine(), out max);
            if(checkMax == false)
            {
                Console.WriteLine("Please enter a number!");
                checkMax = false;
            }
            else
            {
                checkMax = true;
            }
        }
        while (min > max)
        {
            Console.WriteLine("Your minimum value cannot be greater than your maximum value!");
            Console.WriteLine("Enter a maximum value greater than the minimum value:");
            Console.WriteLine($"Current min value: {min}");
            checkMax = Int32.TryParse(Console.ReadLine(), out max);
            if (max > min)
            {
                break;
            }
            else if(max < min)
            {
                Console.WriteLine("Please make sure maximum number is greater than minimum number");
            }
        }
        randomNum = random.Next(min, max);
        Console.WriteLine($"Guess a number from {min} to {max}");
        while (validNum != randomNum)
        {
            bool checkNum = false;
            while(!checkNum)
            {
                checkNum = Int32.TryParse(Console.ReadLine(), out validNum);
                if(checkNum == false)
                {
                    Console.WriteLine("Please enter a number!");
                    checkNum = false;
                }
                else
                {
                    checkNum = true;
                }
            }
            if (validNum > randomNum)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (validNum < randomNum)
            {
                Console.WriteLine("Your guess is too low!");
            }
            guesses++;
        }
        Console.WriteLine($"Congrats! You guessed the correct number: {randomNum}");
        Console.WriteLine($"Your guesses: {guesses}");
        bool replay = false;
        while(!replay)
        {
            Console.WriteLine("Play again? (yes or no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes" || userInput == "y")
            {
                replay = true;
                runLevel = true;
            }
            else if(userInput == "no" || userInput == "n")
            {
                replay = true;
                runLevel = false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no");
                replay = false;
            }
        }
    }
}