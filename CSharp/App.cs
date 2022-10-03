// See https://aka.ms/new-console-template for more information


public class App
{
    // PRIMITIVE DATATYPES (already provided - predifined by C#) 
    // Explicitly (explicit the type of variable)
    float price = 3.99f; // floating numbers, must have an f at the end
    string name = "Jane";
    char letter = 'a'; // char variable with single ''
    bool toggle = true;
    int number = 123123; // whole numbers, any integer negatives included
    double num2 = 123.42; // double could be integer or floating


    static void Main(string[] args) // method // void does not return anything
    {
        // Implicity (using var, any datatype , the compiler will decide wich one)
        var a = 5;
        var b = 20;

        Console.WriteLine("b is equal to {0}", b); // {0} is replaced by the first argument after the ,


        // TRY AND CATCH
        Console.WriteLine("Please enter the first number");
        // string input = Console.ReadLine();

        try
        {
            // int num = int.Parse(input);
            
        }
        catch (FormatException) // to handle specific exceptions
        {
            Console.WriteLine("Please enter only numbers");
        }
        catch (Exception) // to handle general exceptions
        {
            Console.WriteLine("General exception");
        }
        finally
        {
            Console.WriteLine("This is called anyways!");
        }

        string temperature = Console.ReadLine();
        int num = int.Parse(temperature);


        if (num < 10)
        {
            Console.WriteLine("take the coat");
        }
        
    }


    public static int Add (int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // METHOD STRUCTURE -  access modifier (static) return type method name (parameters)
    public static void WriteSomething(string myText)
    {
        Console.WriteLine(myText);
    }

    public static int Calculate()
    {
        Console.WriteLine("Please enter the first number");
        string numberInput = Console.ReadLine();
        Console.WriteLine("Please enter the second number");
        string numberInput2 = Console.ReadLine();

        int num1 = int.Parse(numberInput); // parsear strings a integers
        int num2 = int.Parse(numberInput2);

        return num1 + num2;
    }



}



