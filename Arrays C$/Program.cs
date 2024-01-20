namespace Arrays_C_
{
    internal class Program
    {
        static int intCheckerPass;
        static int optionChecker;
        static bool inputBool;
        static void Main(string[] args)
        {
            Validator();
        }

        public static void Validator() 
        {
            Console.WriteLine("Please enter a value NB: You can enter  any value");
            string? userInput = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");
            var validate = Console.ReadLine();
            int.TryParse(validate, out optionChecker);

            switch (optionChecker) 
            {
                case 1:
                    if (userInput.Length == 1)
                    {
                        Console.WriteLine("You enterd " + userInput + " It is a Character and not a Valid String");
                    }
                    else 
                    {
                        bool intChecker = int.TryParse(userInput, out intCheckerPass);
                        if (intChecker)
                        {
                            Console.WriteLine("You enterd " + userInput + " It is an Integer instead of a String");
                        }
                        else 
                        {
                            foreach (char c in userInput) 
                            {
                                if (char.IsDigit(c)) 
                                {
                                    Console.WriteLine("You enterd " + userInput + " It is an Invalid String");
                                    Console.WriteLine("Please Remove Digit {0}", c );
                                    break;
                                }
                            }
                            Console.WriteLine("You enterd " + userInput + " It is a VALID String");

                        }
                    }
                    break;

                case 2: 
                    bool integerChecker = int.TryParse (userInput, out intCheckerPass);
                    if (!integerChecker) 
                    {
                        Console.WriteLine("You enterd " + userInput + " It is an Invalid Integer");
                    }
                    else 
                    {
                        Console.WriteLine("You enterd " + userInput + " It is a VALID Integer");
                    }
                   
                    break;

                case 3:
                    try
                    {
                        bool isBool = Boolean.TryParse(userInput, out inputBool);
                        if (isBool)
                        {
                            Console.WriteLine("You enterd " + userInput + " It is a VALID Boolean");
                        }
                        else
                        {
                            Console.WriteLine("You enterd " + userInput + " It is a INVALID Boolean");
                        }
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("You enterd " + userInput + " It is NOT A VALID Boolean");
                    }                  
                    break;

                default:
                    Console.WriteLine("INVALID FIGURES" +
                        "");
                    break;


            }

        }
    }
}
