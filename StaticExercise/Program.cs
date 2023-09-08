namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            


            int  userChoice;
            
            double userTemp;
            double convertedToCelsius = 0;
            double convertedToFahrenheit = 0;

            bool validChoice;
            bool validTemp;

            Console.WriteLine("Good day! Would you want know your temperature in Fahrenheit or Celsius?");
            Console.WriteLine("Please enter one of these three numbers.");
            Console.WriteLine("");

            Console.WriteLine("1. Fahrenheit");
            Console.WriteLine("2. Celsius");
            Console.WriteLine("Any other number. Quit");

           validChoice = Int32.TryParse(Console.ReadLine(), out userChoice);

            while (!validChoice)
            {
                Console.WriteLine("Please input a valid number.");
                Console.WriteLine("");
                validChoice = Int32.TryParse(Console.ReadLine(), out userChoice);

;           }

            if (userChoice == 1)
            {
                Console.WriteLine("Please enter your temperature in Celsius.");
                validTemp = Double.TryParse(Console.ReadLine(), out userTemp);

                while (!validTemp)
                {
                    Console.WriteLine("Please input a valid tempature in Celsius.");
                    Console.WriteLine("");
                    validTemp = Double.TryParse(Console.ReadLine(), out userTemp);
                }

                convertedToFahrenheit = TempConverter.CelsiusToFahrenheit(userTemp);

                if (convertedToFahrenheit <= 40)
                {
                    Console.WriteLine($"Your temperture in Fahrenheit is {TempConverter.CelsiusToFahrenheit(userTemp)} F. You should probably grab a jacket in case it gets more chilly.");
                    Console.ReadLine();
                }
                else if (convertedToFahrenheit > 40 && convertedToFahrenheit < 80)
                {
                    Console.WriteLine($"Your temperture in Fahrenheit is {TempConverter.CelsiusToFahrenheit(userTemp)} F. The weather seems decent today. You can either grab a jacket or something cool to drink.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your temperture in Fahrenheit is {TempConverter.CelsiusToFahrenheit(userTemp)} F. Turn on the air conditioner and grab a couple of water bottles.");
                    Console.ReadLine();
                }
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("Please enter your temperature in Fahrenheit.");
                validTemp = Double.TryParse(Console.ReadLine(), out userTemp);

                while (!validTemp)
                {
                    Console.WriteLine("Please input a valid tempature in Fahrenheit.");
                    Console.WriteLine("");
                    validTemp = Double.TryParse(Console.ReadLine(), out userTemp);
                }

                convertedToCelsius = TempConverter.FahrenheitToCelsius(userTemp);

                if (convertedToCelsius <= 0)
                {
                    Console.WriteLine($"Your temperture in Celsius is {TempConverter.FahrenheitToCelsius(userTemp)} C. You should probably grab a jacket in case it gets more chilly.");
                    Console.ReadLine();
                }
                else if (convertedToCelsius > 40 && convertedToCelsius < 80)
                {
                    Console.WriteLine($"Your temperture in Celsius is {TempConverter.FahrenheitToCelsius(userTemp)} C. The weather seems decent today. You can either grab a jacket or something cool to drink.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your temperture in Celsius is {TempConverter.FahrenheitToCelsius(userTemp)} C. Turn on the air conditioner and grab a couple of water bottles.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Have a good day.");
                Console.ReadLine();
            }
            
        }
    }
}
