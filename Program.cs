
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68);
        CheckForPositiveNegativeZero(-45);
        FindMinimum(1,2,3);
        FindMaximum(3,1,2);
        IsDivisibleBy5(90);
        CheckEvenOrOdd(4);
        CheckVowelOrConsonant('a');
        DisplayDayOfWeek(5);
         // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
     public static void CheckForPositiveNegativeZero(int number)
    {
        if(number >= 1)
        {
            Console.WriteLine("Your number is positive.");
        }
        else if(number == 0)
        {
            Console.WriteLine("Your number is zero.");
        }
        else if(number <= 1) 
        {
            Console.WriteLine("Your number is negative.");
        }
        

    }
    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 == Math.Min(num1, Math.Min(num2, num3))) 
        {
            Console.WriteLine("The minimum value is " + num1 + ".");
        }
        else if (num2 == Math.Min(num1, Math.Min(num2, num3)))
        {
            Console.WriteLine("The minimum value is " + num2 + "."); 
        }
        else 
        {
             Console.WriteLine("The minimum value is " + num3 + ".");
        }
        
       
    }
    public static void FindMaximum(int num1, int num2, int num3)
    {
       if (num1 == Math.Max(num1, Math.Max(num2, num3))) 
        {
            Console.WriteLine("The maximum value is " + num1 + ".");
        }
        else if (num2 == Math.Max(num1, Math.Max(num2, num3))) 
        {
            Console.WriteLine("The maximum value is " + num2 + ".");
        }
        else 
        {
            Console.WriteLine("The maximum value is " + num3 + ".");
        }
    }
    public static void IsDivisibleBy5(int number)
    {
        if(number % 5 == 0)
        {
            Console.WriteLine(number + " is divisible by 5.");
        }
        else
        {
            Console.WriteLine(number + " is not divisible by 5.");
        }
    }
    public static void CheckEvenOrOdd(int number)
    {
        if(number % 2 == 0) 
        { 
           Console.WriteLine(number + " is an even number."); 
        }
        else 
        { 
            Console.WriteLine(number + " is an odd number.");
        }
    }
    public static void CheckVowelOrConsonant(char letter)
    {
       switch(letter) 
       {
        case 'a':
        Console.WriteLine(letter + " is a vowel.");
        break;
        case 'e':
        Console.WriteLine(letter + " is a vowel.");
        break;
        case 'i':
        Console.WriteLine(letter + " is a vowel.");
        break;
        case 'o':
        Console.WriteLine(letter + " is a vowel.");
        break;
        case 'u':
        Console.WriteLine(letter + " is a vowel.");
        break;
        case 'y':
        Console.WriteLine(letter + " is a vowel.");
        break;
        default: 
        Console.WriteLine(letter + " is a consonant.");
        break;
       }
       
    }
    public static void DisplayDayOfWeek(int dayCode)
    {
        switch(dayCode)
        {
            case 0:
            Console.WriteLine("Sunday");
            break;
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wenesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
        }
    }
}


