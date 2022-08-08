// See https://aka.ms/new-console-template for more information
using Calcualtor;

CalculatorOperation calcualtorOperation = new CalculatorOperation(15, 5);
var result = calcualtorOperation.Addition();

Console.WriteLine("The subtract operation is: " + result);