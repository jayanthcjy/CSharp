
/// <summary>
/// Finding the max product
/// </summary>
    public class MaxProduct
    {
        /// <summary>
        /// Taking the num input from MainClass then finding the max product for 4 adjacent 
        /// digits and return max product, 4 digits as string to MainClass
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string MaxProductOf4Digits(string num)
        {
            //Declaring the variables
            int len = 0, maxProduct = -1;
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0;
            int tempNum1, tempNum2, tempNum3, tempNum4, product;

            //Finding the length of the num
            foreach (char i in num)
            {
                len++;
            }

            //Finding product of every four digits and updating the maxproduct with prod, storing the digits
            for (int i = 0; i < len - 3; i++)
            {
                tempNum1 = num[i] - 48;
                tempNum2 = num[i + 1] - 48;
                tempNum3 = num[i + 2] - 48;
                tempNum4 = num[i + 3] - 48;

                product = tempNum1 * tempNum2 * tempNum3 * tempNum4;
                if (product > maxProduct)
                {
                    num1 = tempNum1;
                    num2 = tempNum2;
                    num3 = tempNum3;
                    num4 = tempNum4;
                    maxProduct = product;
                }
            }
            
                 
                return num1 + "*" + num2 + "*" + num3 + "*" + num4 + "=" + maxProduct; 
            }


        }
    