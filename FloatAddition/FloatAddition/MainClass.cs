using System;


namespace AdditionOfFloatNumbers
{   
    /// <summary>
    /// Takes two inputs from users and send to FloatAddition class
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            string floatInput1 = Console.ReadLine();
            string floatInput2 = Console.ReadLine();

            FloatAddition obj = new FloatAddition();
            Console.WriteLine(obj.Addition(floatInput1, floatInput2));
        }
    }
}
