// See https://aka.ms/new-console-template for more information
using FindMaximum_Generics;
Console.WriteLine("Welcome to Find Max NUmber Using Generics program");

int output = FindMaxNumber.MaximumIntegerNumber(10, 20, 30);
Console.WriteLine(output);

Console.WriteLine();

Console.WriteLine("Maximum Float Value");
double doubleoutput = FindFloatMaxNumber.MaximumFloatNumber(10.10, 100.10, 30.30);
Console.WriteLine(doubleoutput);

Console.WriteLine();

Console.WriteLine("Maximum String Value");
string stringoutput = FindStringMaxNumber.MaximumString("piyu", "kajal", "chetna");
Console.WriteLine(stringoutput);
Console.WriteLine();


Console.WriteLine();

int[] intArray = { 1001, 2001, 1994, 2551 };
FindMaxUsingGeneric<int> generic = new FindMaxUsingGeneric<int>(intArray);
generic.PrintMaxValue();

double[] doubleArray = { 10.58, 52.52, 65.35, 89.52 };
FindMaxUsingGeneric<double> genericDouble = new FindMaxUsingGeneric<double>(doubleArray);
genericDouble.PrintMaxValue();

string[] stringArray = { "piyu", "kajal", "chetna", "sona" };
FindMaxUsingGeneric<string> genericString = new FindMaxUsingGeneric<string>(stringArray);
genericString.PrintMaxValue();
