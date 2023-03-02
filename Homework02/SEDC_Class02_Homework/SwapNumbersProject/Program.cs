Console.WriteLine("please enter numbers you want to swap");
int number5 = Convert.ToInt32(Console.ReadLine());
int number6 = Convert.ToInt32(Console.ReadLine());
int number7;

number7 = number5;
number5 = number6;
number6 = number7;

Console.WriteLine("swapped numbers are : ");
Console.WriteLine(number5);
Console.WriteLine(number6);