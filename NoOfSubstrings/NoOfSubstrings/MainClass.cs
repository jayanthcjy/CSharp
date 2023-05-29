using System;
using System.Collections;
using System.Collections.Generic;


namespace NoOfSubstrings
{

    /// <summary>
    /// Taking two inputs from user and sending them to the Validations class 
    /// and finding whether those inputs are valid. If valid then sending those inputs to the 
    /// logic FindingNoOfSubstrings class and returning the indexs list fo substring
    /// </summary>

    public class MainClass
    {
        
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Validations valObj=new Validations();
            bool validate=valObj.Validate(str1, str2 );

            //if the inputs passes all the condition then pass the inputs to the logic FindingNoOfSubstrings
            if (validate)
            {
                FindingNoOfSubstrings obj = new FindingNoOfSubstrings();
                List<int> indexList=obj.IndexsOfSubstring(str1, str2);
                int listLen = 0;

                foreach (int i in indexList)
                {
                    listLen++;
                }
                Console.WriteLine("No of times occured = " + listLen);

                Console.Write("Index positions = ");

                foreach (int i in indexList)
                {
                    Console.Write(i + " ");
                }
            }

        }


    }
}
