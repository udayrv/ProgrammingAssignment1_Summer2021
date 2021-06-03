using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the Moves of Robot:");
            string moves = Console.ReadLine();
            bool pos = Question1.JudgeCircle(moves);
            if (pos)
            {
                Console.WriteLine("The Robot return’s to initial Position (0,0)");
            }
            else
            {
                Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
            }
            Console.WriteLine();

            // Question2
            Console.WriteLine(" Q2: Enter the string to check for pangram:");
            string str = Console.ReadLine();
            bool flag = Question2.CheckIfPangram(str);
            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            Console.WriteLine();

            //Question 3
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            int gp = Question3.NumIdenticalPairs(nums);
            Console.WriteLine("Q3:");
            Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);

            //Question 4
            int[] arr1 = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4:");
            int pivot = Question4.PivotIndex(arr1);
            if (pivot > 0)
            {
                Console.WriteLine("The Pivot index for the given array is {0}", pivot);
            }
            else
            {
                Console.WriteLine("The given array has no Pivot index");
            }
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Q5:");
            Console.WriteLine("Enter the First Word:");
            String word1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Word:");
            String word2 = Console.ReadLine();
            String merged = Question5.merge(word1, word2);
            Console.WriteLine("The Merged Sentence fromed by both words is {0}", merged);

            //Question 6
            Console.WriteLine("Q6: Enter the sentence to convert:");
            string sentence = Console.ReadLine();
            string goatLatin = Question6.ToGoatLatin(sentence);
            Console.WriteLine("Goat Latin for the Given Sentence is {0}", goatLatin);
            Console.WriteLine();    

        }
    }
    class Question1
        // Logic:
        // We need to increase x by +1 if it is R and -1 if it is L
        // We need to increase y by +1 if it is U and -1 if it is D
    {
        public static bool JudgeCircle(string moves)
        {
            try
            {
                int x = 0;
                int y = 0;

                char[] array = moves.ToCharArray();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 'R')
                        x++;
                    else if (array[i] == 'L')
                        x--;
                    else if (array[i] == 'U')
                        y++;
                    else if (array[i] == 'D')
                        y--;
                }
                return (x == 0 && y == 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
    // Self Reflection:
    //
    // Time complexity is O(N)
    // We have learnt the basic program to control the moments of a Robot in a 2D plane. 
    // 
    public class Question2
    //Logic:
    // We iterate all the alphabatical characters over the given string and count the instances
    // where the alphabatical character is equal to character in given string.
    // (we are checking all the alphabatical characters are present in the given string or not)
    // if count is equal to 26 return ture if not false.
    {
        public static bool CheckIfPangram(string str)
        {
            try
            {
                string alpha = "abcdefghijklmnopqrstuvwxyz"; 
                int count = 0;

                foreach (char c in alpha)
                {
                    foreach (char i in str.ToLower())
                    {
                        if (c == i)
                        {
                            count++;
                            break;
                        }
                    }
                }
                return (count == 26);
            }

            catch (Exception)
            {
                throw;
            }

        }
    }
    // Self Reflection:
    //
    // Time complexity is O(N2)
    // We have learnt the string processing and basics of string functions. 
    //  
    class Question3
        // Logic:
        // We doube iterate over the given array indices and check if there are any element matches for a pair of indices in array.
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            try
            {
                int finalCount = 0;

                for (var i = 0; i < nums.Length; i++)
                {
                    for (var j = 0; j < nums.Length; j++)

                        if (nums[i].Equals(nums[j]) && i < j)

                            finalCount++;
                }
                return finalCount;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    // Self Reflection:
    //
    // Time complexity is O(N2)
    // We have learnt how to work with arrays and bacis of doube looping and the working with index of an array. 
    //
    class Question4
    // Logic:
    // We first consider the leftsum = 0 and sum as total sum of elements in given array.
    // then, we remove the first element from the total sum and check the sum of the remaining elements is equal to the first element. 
    // If true we return the index of the element.
    // If not we repeat for remaining elements in the array by increasing the leftsum by next element value.
    {
        public static int PivotIndex(int[] nums)
        {
            try
            {
                if(nums == null || nums.Length == 0)
                return -1;

                int sum = nums.Sum();
                int leftsum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if ((sum = (sum - nums[i])) == leftsum)
                        return i;
                    else
                        leftsum += nums[i];
                }

                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;

            }
        }

    }
    // Self Reflection:
    //
    // Time complexity is O(N2)
    // We have learnt some advance techniques of working on array and it's indexes. 
    //
    class Question5
        // Logic:
        // We use the StringBuilder class for our solution.
        // We iterate over both the strings and append each character from the string 
        // alternatively to our StringBuilder. Finally we convert it to the string.
    {
        public static string merge(string word1, string word2)
        {
            try
            {
                var bldr = new StringBuilder();

                for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
                {
                    if (i < word1.Length) bldr.Append(word1[i]);
                    if (i < word2.Length) bldr.Append(word2[i]);
                }
                return bldr.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;

            }
        }
    }
    // Self Reflection:
    //
    // Time complexity is O(N)
    // We have learnt to work with StringBuilder class and how to work with strings accourding to their lengths.
    //
    class Question6
    // Logic:
    // first we split the given sentence into words and then filter accourding to the first letter of the word.
    // if it is an vowel we append 'ma' and 'a' to the end of the word as per it's index.
    // if it is a consonant we remove the first letter and append it to the end and add 'ma' to the end,
    // and add 'a' to the end of the word as per it's index.
    {
        public static string ToGoatLatin(string sentence)
        {
            try
            {
                var words = sentence.Split();
                var sb = new StringBuilder();
                for (int i = 0; i < words.Length; i++)
                {
                    var w = words[i];
                    if (i > 0)
                    {
                        sb.Append(' ');
                    }
                    if ("aeiouAEIOU".Contains(w[0]))
                    {
                        sb.Append(w);
                    }
                    else
                    {
                        sb.Append(w.Substring(1));
                        sb.Append(w[0]);
                    }
                    sb.Append("ma");
                    sb.Append('a', i);
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    // Self Reflection:
    //
    // Time complexity is O(N2)
    // We have learnt some moderate level of string manipulation on string arrays. 
    // We have seen cooncatination of strigs and filtering of words according to it's first letter.
    //

}





