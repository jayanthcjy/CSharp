using NoOfSubstrings;
using System;


namespace MaxOf4Digits
{

    /// <summary>
    /// Taking input from user and sending it to Validations to check whethter the input is valid or not
    /// Then if valid send the input to the Maxproduct Class and return the maxproduct and adjacent digits.
    /// </summary>
    public class MainClass
    {
        static void Main()
        {
            string num = Console.ReadLine();

            
            Validations valObj = new Validations();
            bool validate=valObj.Validate(num);

            if(validate)
            {
                MaxProduct obj = new MaxProduct();
                string finalOutput = obj.MaxProductOf4Digits(num);
                Console.WriteLine(finalOutput);
            }
                        
                
            

        }

      
    }
}
