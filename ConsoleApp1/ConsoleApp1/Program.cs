
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*checked
            {
                byte number = 255;
                Console.WriteLine(number);
                number = (byte)(number + 1);
                Console.WriteLine(number);

            }*/


            /* try
             {
                 var num = "1237";
                 byte conv = Convert.ToByte(num);
                 Console.WriteLine(conv);

             }
             catch (Exception)
             {
                 Console.WriteLine("Number cannot be converted to byte");
             }*/

            var personOne = new Person();
            personOne.firstName = "Mohammed";
            personOne.lastName = "Ismail";
            personOne.introduce();




        }
    }
}
