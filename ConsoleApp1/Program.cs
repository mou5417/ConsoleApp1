namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int playerRndGuess(int max, int min)
            {
            
                    Random rnd = new Random();
                    int Inputnumber = rnd.Next(min, max);
                    return Inputnumber;
              
            }
            static int playerInputGuess(int max, int min)
            {
               
                int Inputnumber = Convert.ToInt32(Console.ReadLine());
                return Inputnumber;
            }
            static int halfInputGuess(int max, int min)
            {
                int Inputnumber = (max + min) / 2;
                return Inputnumber;
            }

            ////////////////////////////////////////////////////
            int bottom, top;
            bottom = 0;
            top = 99;
            Random rnd = new Random();
            int answer = rnd.Next(0, 100);
            Console.WriteLine(answer);
            bool isFinish = false;
            int oldGuessNumber = 0;
            Console.WriteLine("Please enter a number to choose mode: 1:random guess\n 2:Input guess\n 3:half auto guess mode");
            string mode=Convert.ToString( Console.ReadLine());
            bool nextStep = false;
            string funNum;
            switch (mode)
            {
                case"1":
                    funNum = "playerRndGuess";
                    break;
                default:
                    break;

            }
            if (nextStep)
            {
                while (!isFinish)
                {
                    Console.WriteLine("guess a number between " + "(" + bottom + "," + top + "): ");
                    int guessNumber = Convert.ToInt32(funNum(top, bottom));
                    Console.WriteLine("player guess " + guessNumber);
                    if (guessNumber > top || guessNumber < bottom)
                    {
                        Console.WriteLine("out of range");

                    }
                    else if (oldGuessNumber == guessNumber)
                    {
                        Console.WriteLine("Please try another number");
                    }
                    else if (guessNumber == answer)
                    {
                        Console.WriteLine("You Win Game ended");
                        isFinish = true;
                    }
                    else if (guessNumber > answer)
                    {
                        top = guessNumber;

                        if (top - 2 == bottom)
                        {
                            Console.WriteLine("Game ended");
                            isFinish = true;
                        }

                    }
                    else
                    {
                        bottom = guessNumber;
                        if (top - 2 == bottom)
                        {
                            Console.WriteLine("Game ended");
                            isFinish = (true);
                        }
                    }
                    oldGuessNumber = guessNumber;
                }
            }
        }
    }

}