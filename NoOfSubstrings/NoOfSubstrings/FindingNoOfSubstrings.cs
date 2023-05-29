using System.Collections.Generic;


    /// <summary>
    /// Finding the idexes of substrings
    /// </summary>
    public class FindingNoOfSubstrings
    {


        /// <summary>
        /// Finding the no of substring of the string and storing there indexes in list and 
        /// returning te list to the MainClass 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public List<int> IndexsOfSubstring(string str1, string str2)
        {

            int str1Len = 0;
            List<int> indexList = new List<int>();
            foreach (char c in str1)
            {
                str1Len++;

            }
            int str2Len = 0;
            foreach (char c in str2)
            {
                str2Len++;

            }
            int count;

            //Finding the substring in string and adding their indexes to the list
            for (int i = 0; i <= str1Len - str2Len; i++)
            {
                int k = i;
                 count = 0;
                for (int j = 0; j < str2Len ; j++)
                {

                    if (str1[k] == str2[j])
                    {
                        count++;
                        k++;

                    }
                    
                    
                }
                    if (count == str2Len)
                    {
                        indexList.Add(i);
                    }
                

            }
           

            return indexList;
        }


    }
