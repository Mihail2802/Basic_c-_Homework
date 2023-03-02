
Console.WriteLine("Please enter a number");
int userInput1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a second number");
int userInput2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter operation sign");
double result = 0;

string userInput3 = Console.ReadLine();
if (userInput3 == "+")
{
    result = userInput1 + userInput2;
}
else if (userInput3 == "-")
{
    result = userInput1 - userInput2;
}
else if (userInput3 == "*")
{
    result = userInput1 * userInput2;
}
else if (userInput3 == "/")
{
    result = userInput1 / userInput2;
}
else {
    Console.WriteLine("you have entered an invalid input ...");
}
Console.WriteLine("The Result is :" + result);

