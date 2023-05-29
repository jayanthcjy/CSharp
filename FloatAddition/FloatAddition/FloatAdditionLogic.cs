using System;


/// <summary>
/// This class contains FloatAddition class which  adds both float numbers
/// </summary>

public class FloatAddition
{
    /// <summary>
    /// This method convert two float inputs numbers to binary and then add both binary numbers and then
    /// convert to flaot number and return to main class
    /// </summary>
    public double Addition(string str1, string str2)
    {
        string[] s1 = str1.Split('.');
        string[] s2 = str2.Split('.');

        int integral1 = Convert.ToInt32(s1[0]);
        int integral2 = Convert.ToInt32(s2[0]);
        string tempDecimal1 = "0." + s1[1];
        string tempDecimal2 = "0." + s2[1];
        float decimal1 = float.Parse(tempDecimal1);
        float decimal2 = float.Parse(tempDecimal2);




        Utilities utilityObj = new Utilities();

        //Concerting integer part to binary
        string int1Binary = utilityObj.IntToBinary(integral1);
        string int2Binary = utilityObj.IntToBinary(integral2);


        //Converting decimal part to binary
        string decimal1Binary = utilityObj.DeciamlPartToBinary(decimal1);
        string decimal2Binary = utilityObj.DeciamlPartToBinary(decimal2);


        int b1len = int1Binary.Length;
        int b2len = int2Binary.Length;
        int b3len = decimal1Binary.Length;
        int b4len = decimal2Binary.Length;
        //eaqualing the lengths of b1 and b2
        if (b1len >= b2len)
        {
            int j = b1len - b2len;
            while (j != 0)
            {
                int2Binary = 0 + int2Binary;
                j--;
            }
            int1Binary = 0 + int1Binary;
            int2Binary = 0 + int2Binary;
        }
        else
        {
            int j = b2len - b1len;
            while (j != 0)
            {
                int1Binary = 0 + int1Binary;
                j--;
            }
            int1Binary = 0 + int1Binary;
            int2Binary = 0 + int2Binary;
        }

        //equaling the lengths of b3 and b4
        if (b3len >= b4len)
        {
            int j = b3len - b4len;
            while (j != 0)
            {
                decimal2Binary = decimal2Binary + 0;
                j--;
            }
        }
        else
        {
            int j = b4len - b3len;
            while (j != 0)
            {
                decimal1Binary = decimal1Binary + 0;
                j--;
            }

        }

        //Adding both Binary decimal parts
        int carry = 0;
        string decimalBinaryPart = utilityObj.AddingDecimal(decimal1Binary, decimal2Binary, out carry);


        //adding both Binary integral parts
        string integralBinaryPart = utilityObj.AddingIntegers(int1Binary, int2Binary, carry);

        //converting resultant binary integral part integer
        double finalIntegralNumber = 0;
        int ind = 0;
        for (int d = integralBinaryPart.Length - 1; d >= 0; d--)
        {
            if (integralBinaryPart[d] == '1')
            {
                finalIntegralNumber += Math.Pow(2, ind);
            }
            ind++;
        }

        //converting resultant binary decimal part decimal
        double finalDecimalNumber = 0;

        ind = -1;
        int q;
        q = decimalBinaryPart.Length - 1;
        int p = 0;
        while (p <= q)
        {
            if (decimalBinaryPart[p] == '1')
            {
                finalDecimalNumber += Math.Pow(2, ind);
            }
            p++;
            ind--;

        }


        double final = finalIntegralNumber + finalDecimalNumber;

        return final;

    }
}


