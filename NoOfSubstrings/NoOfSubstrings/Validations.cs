using System;



    /// <summary>
    /// Checking the inputs valid are not.
    /// </summary> 
    public class Validations
    {
        /// <summary>
        /// Checking whether the inputs are valid or not.
        /// If valid return true to Mainclass 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool Validate(string str1, string str2)
        {
            int strLen1 = 0,strLen2=0;
            foreach(char c in str1)
            {
                strLen1++;
            }
            foreach (char c in str2)
            {
                strLen2++;
            }
            if (strLen1 < strLen2)
            {
                throw new Exception("Substring length should be smaller  than String");
                
            }
            if (str1 == string.Empty)
            {
                throw new Exception("String should not be empty");
                
            }
            if (str2 == string.Empty)
            {
                throw new Exception("Substring should not be empty");
                
            }

           
            return true;

        }
    }
