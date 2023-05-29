using System;


namespace NoOfSubstrings
{
    public class Validations
    {
        //This method defines that num is valide or not
        public bool Validate(string num)
        {
            int len=0;

            //Finding the length of the num
            foreach (char c in num)
            {
                len++;
            }

            
            if (len <4 || num==string.Empty)
            {
                throw new Exception("Input should be greater than or equal to 4 digits");


            }

            int condition = 0;
                foreach (int  i in num) 
                { 
                    if(i<48 || i > 57)
                    {
                    condition = 1;
                    }
                }
            if (condition == 1)
            {
                throw new Exception("Input should contain only positive integers");
            }
            

            return true;
        }
    }
}
