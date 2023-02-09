
// Create a list of strings.
/*using System.Collections.Generic;
using System;

var iceCream = new List<string>();
iceCream.Add("butterscotch");
iceCream.Add("vanilla");
iceCream.Add("strawberry");
iceCream.Add("blackcurrent");

// Iterate through the list.
foreach (var ice in iceCream)
{
    Console.WriteLine(ice);
}
*/

/*object FirstNum = 1;
object SecondNum = 2;
object ThirdNum = 2;
object stringOne = "Hello";
object stringTwo = "Hello";
Console.WriteLine(object.Equals(FirstNum, SecondNum));
Console.WriteLine(object.Equals(SecondNum, ThirdNum));
Console.WriteLine(object.ReferenceEquals(SecondNum, ThirdNum));
Console.WriteLine(object.Equals(stringOne, stringTwo));
Console.WriteLine(object.ReferenceEquals(stringOne, stringTwo));
*/

try
{
    Console.WriteLine("csharp" + " " + 1 / Convert.ToInt32(0));
}
catch (ArithmeticException e)
{
    Console.WriteLine("Java");
}



