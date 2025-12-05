NicksCoolCalculator calculator = new(
    "Welcome to Diogo's Cool Calculator!");
calculator.Start();


public sealed class NicksCoolCalculator
{
    private string _greeting;


    public NicksCoolCalculator(string greeting)
    {
        _greeting = greeting;
    }


    public void Start() 
    {
        Console.WriteLine(_greeting);

        Dictionary<string, string> supportedOperators = new()
        {
            { "+", "Addition" },
            { "-", "Subtraction" }
            //{ "*", "Multiplication" },
            //{ "/", "Division" }
        };

        while (true)
        {
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators) 
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.WriteLine("Enter an Operator:");
            string operatorChoice = Console.ReadLine();

            if (!supportedOperators.TryGetValue(
                operatorChoice,
                out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid Operator choice.");
                continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine(
                $"Recall that integers are on the range " +
                $"{int.MinValue} to {int.MaxValue}!"
            );
            Console.WriteLine();


            Console.WriteLine("Enter the first integer:");
            string firstNumberInput = Console.ReadLine();

            if (!int.TryParse(firstNumberInput, out int firstNumber))
            {
                Console.WriteLine(
                    $"{firstNumberInput} could not be parsed as ArgumentNullException integer!");
                continue;
            }

            Console.WriteLine("Enter the second integer:");
            string secondNumberInput = Console.ReadLine();

            if (!int.TryParse(secondNumberInput, out int secondNumber))
            {
                Console.WriteLine($"{secondNumberInput} could not be parsed as a double.");
                continue;
            }

            int result;
            try
            {
                result = operatorChoice switch
                {
                    "+" => firstNumber + secondNumber,
                    "-" => firstNumber - secondNumber,
                    _ => throw new NotSupportedException(
                        $"Arithmetic is not currently supported " + 
                        $"for operator {operatorChoice}.")
                };
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"There was unhandled exception: {ex.Message}"
                );
                continue;
            }

            Console.WriteLine($"The result is: {result}");


        }
    }
}