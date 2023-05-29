using System;
using System.Collections.Generic;


namespace AdditionOfFloatNumbers
{
    public class Utilities
    {
        //Int to binary conversion of numeric part
        public string IntToBinary(int integralPart)
        {
            string binary = "";
            while (integralPart != 0)
            {
                binary = integralPart % 2 + binary;
                integralPart /= 2;
            }
            return binary;
        }

        //Int to binary conversion of decimal part
        public string DeciamlPartToBinary(float decimalPart)
        {

            string tempnum = Convert.ToString(decimalPart);
            string binary = "";

            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add(tempnum.Substring(tempnum.IndexOf('.')));
            int w = 1;
            string i;
            while (w != 0)
            {
                float f = float.Parse(tempnum);
                tempnum = Convert.ToString(f * 2);
                //Console.WriteLine(tempnum);
                i = tempnum.Substring(tempnum.IndexOf('.') + 1);
                if (hashSet.Contains(i) == true)
                {
                    break;
                }

                hashSet.Add(i);
                if (tempnum[0] == '1')
                {
                    tempnum = tempnum.Substring(1);
                    tempnum = '0' + tempnum;
                    binary = binary + '1';
                }
                else
                {
                    binary = binary + '0';

                }

            }

            return binary;
        }

        //adding two Binary decimal parts
        public string AddingDecimal(string decimal1Binary, string decimal2Binary, out int carry)
        {
            carry = 0;
            string binary = "";
            int i;
            for (i = decimal1Binary.Length - 1; i >= 0; i--)
            {
                if (carry == 0 && (decimal1Binary[i] == '0' && decimal2Binary[i] == '0'))
                {
                    binary = "0" + binary;
                }
                else if (carry == 1 && (decimal1Binary[i] == '0' && decimal2Binary[i] == '0'))
                {
                    binary = "1" + binary;
                    carry = 0;
                }
                else if (carry == 1 && ((decimal1Binary[i] == '1' && decimal2Binary[i] == '0') || (decimal1Binary[i] == '0' && decimal2Binary[i] == '1')))
                {
                    binary = "0" + binary;
                    carry = 1;

                }
                else if (carry == 0 && ((decimal1Binary[i] == '1' && decimal2Binary[i] == '0') || (decimal1Binary[i] == '0' && decimal2Binary[i] == '1')))
                {
                    binary = "1" + binary;
                    carry = 0;
                }

                else if (carry == 0 && ((decimal1Binary[i] == '1' && decimal2Binary[i] == '1')))
                {
                    binary = "0" + binary;
                    carry = 1;
                }
                else if (carry == 1 && ((decimal1Binary[i] == '1' && decimal2Binary[i] == '1')))
                {
                    binary = "1" + binary;
                    carry = 1;
                }

            }
            return binary;
        }

        //Adding two Binary Integral parts
        public string AddingIntegers(string integer1Binary, string integer2Binary, int carry)
        {
            string binary = "";
            int len = integer1Binary.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                if (carry == 0 && (integer1Binary[i] == '0' && integer2Binary[i] == '0'))
                {
                    binary = "0" + binary;
                }
                else if (carry == 1 && (integer1Binary[i] == '0' && integer2Binary[i] == '0'))
                {
                    binary = "1" + binary;
                    carry = 0;
                }
                else if (carry == 1 && ((integer1Binary[i] == '1' && integer2Binary[i] == '0') || (integer1Binary[i] == '0' && integer2Binary[i] == '1')))
                {
                    binary = "0" + binary;
                    carry = 1;
                }
                else if (carry == 0 && ((integer1Binary[i] == '1' && integer2Binary[i] == '0') || (integer1Binary[i] == '0' && integer2Binary[i] == '1')))
                {
                    binary = "1" + binary;
                    carry = 0;
                }

                else if (carry == 0 && ((integer1Binary[i] == '1' && integer2Binary[i] == '1')))
                {
                    binary = "0" + binary;
                    carry = 1;
                }
                else if (carry == 1 && ((integer1Binary[i] == '1' && integer2Binary[i] == '1')))
                {
                    binary = "1" + binary;
                    carry = 1;
                }

            }
            return binary;

        }

    }
}

