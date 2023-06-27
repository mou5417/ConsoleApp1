# ConsoleApp1namespace ConsoleApp1
{
    internal class Program
    {
       public delegate int Del(int max, int min);
   
       public static int playerRndGuess(int max, int min)
        {

            Random rnd = new Random();
            int Inputnumber = rnd.Next(min, max);
            return Inputnumber;

        }
        public static int playerInputGuess(int max, int min)
        {

            int Inputnumber = Convert.ToInt32(Console.ReadLine());
            return Inputnumber;
        }
        public static int halfInputGuess(int max, int min)
        {
            int Inputnumber = (max + min) / 2;
            return Inputnumber;
        }
      
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////
            int bottom, top;
            bottom = 0;
            top = 99;
            Random rnd = new Random();
            int answer = rnd.Next(0, 100);
            Console.WriteLine(answer);
            bool isFinish = false;
            int oldGuessNumber = 0;
            Console.WriteLine("Please enter a number to choose mode:\n 1:random guess\n 2:Input guess\n 3:half auto guess mode");
            string mode = Convert.ToString(Console.ReadLine());
            bool nextStep = false;

            Del d = playerRndGuess;
            switch (mode)
            {
                case "1":
                    d = playerRndGuess;
                    Func<int, int, int> f = playerRndGuess;
                    nextStep = true;
                    break;
                case "2":
                    d = playerInputGuess;
                    nextStep = true;
                    break;
                case "3":
                    d = halfInputGuess;
                    nextStep = true;
                    break;
                default:
                    break;

            }
            if (nextStep)
            {
                while (!isFinish)
                {
                    Console.WriteLine("guess a number between " + "(" + bottom + "," + top + "): ");
                   
                    int guessNumber = Convert.ToInt32(d(top, bottom));
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
                        Console.WriteLine("You Win! Game ended");
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
