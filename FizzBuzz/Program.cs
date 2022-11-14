bool o;
do
{
    double userInput;
    o = double.TryParse(Console.ReadLine(), out userInput);
    if (o)
    {
        void FizzBuzz(double i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                var a = "Fizzbuzz";
                Console.WriteLine(a);
            }
            else if (i % 5 == 0)
            {
                var b = "Buzz";
                Console.WriteLine(b);
            }
            else if (i % 3 == 0)
            {
                var c = "Fizz";
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("try again");
            }
        }



        FizzBuzz(userInput);
        
    }

    if (!o)
    {
        Console.WriteLine("try again");
    }
} while (!o);