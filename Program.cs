using System;
using System.Linq;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is :{0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is :{0}", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }
        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                int len = s.Length;
                if (len > 10000)//user defined exceptions
                {
                    Console.WriteLine("Lenght of input string should be less than " + len);
                }
                String final_string = "";
                for (int i = 0; i < s.Length; i++)//looking for characters which are equal
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        final_string = final_string + "";
                    }
                    else if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    {
                        final_string = final_string + "";
                    }
                    else
                        final_string = final_string + s[i];
                }


                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                string s1 = "";
                string s2 = "";
                for (int i = 0; i < bulls_string1.Length; i++)//adding values to strings
                {
                    s1 = s1 + bulls_string1[i];
                }
                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    s2 = s2 + bulls_string2[i];
                }
                if (s1 == s2)//if strings are equal
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int A = bull_bucks.Length;
                int[] x = bull_bucks;
                if (A > 100)//user defined exceptions
                {
                    Console.WriteLine("Lenght of input string should be less than " + A);
                }
                foreach (int i in bull_bucks)//user defined exceptions
                {
                    if (i > 100)
                    {
                        Console.WriteLine("Value of the input should not exceed 100, current value: " + i);
                    }
                }
                int sum = 0;
                int length = bull_bucks.Length;
                foreach (int w in bull_bucks)//overwriting the value of b
                {
                    int b = 0;
                    int i = 0;
                    while (i < length)
                    {
                        if (w == bull_bucks[i])
                        {
                            b = b + 1;
                        }
                        i++;
                    }
                    if (b == 1)// when the value of b is 1
                    {
                        sum = sum + w;
                    }
                }
                return sum;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int j = bulls_grid.Length;
                int r = Convert.ToInt32(Math.Sqrt(j));
                int diagsum = 0;
                int i = 0;
                do//the values of diagonal indexes are added
                {
                    diagsum = diagsum + bulls_grid[i, i] + bulls_grid[i, r - i - 1];
                    i++;
                } while (i < r);
                if (r % 2 != 0) //subtracting repeated value for odd matrix
                {
                    return diagsum - bulls_grid[(r - 1) / 2, (r - 1) / 2];
                }
                else
                {
                    return diagsum;
                }

            }
            catch (Exception g)
            {

                Console.WriteLine("An error occured: " + g.Message);
                throw;
            }

        }

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                int len = indices.Length;
                if (len > 100)//user defined exceptions
                {
                    Console.WriteLine("Lenght of input string should be less than " + len);
                }
                if (bulls_string.Length != indices.Length)//user defined exceptions
                {
                    Console.WriteLine("Indices length and bull_string length are not same");
                }
                if (bulls_string.Any(char.IsUpper))//user defined exceptions
                {
                    Console.WriteLine("Input string contains Upper case letter");
                }
                if (indices.Distinct().Count() != indices.Length)//user defined exceptions
                {
                    Console.WriteLine("All the values in indices array should be unique");
                }
                foreach (int i in indices)
                {
                    if (i > bulls_string.Length)
                    {
                        Console.WriteLine("Value in indices is exceeding the number of characters in the string");
                    }
                }
                string[] p = new string[bulls_string.Length];
                string f = "";
                int o = 0;
                do//comparing bulls_string with new indexes of p
                {
                    int j = indices[o];
                    p[j] = Convert.ToString(bulls_string[o]);
                    o++;
                } while (o < bulls_string.Length);
                o = 0;
                do
                {
                    f = f + p[o];
                    o++;
                } while (o < bulls_string.Length);
                return f;
            }
            catch (Exception l)
            {
                Console.WriteLine(l.Message);
                throw;
            }

        }

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int len = bulls_string6.Length;
                if (bulls_string6.Any(char.IsUpper))//user defined exceptions
                {
                    Console.WriteLine("Input string contains Upper case letter");
                }
                if (len > 250)//user defined exceptions
                {
                    Console.WriteLine("Lenght of input string should be less than " + len);
                }
                string[] h = new string[bulls_string6.Length];
                int e = 0;
                do
                {
                    if (bulls_string6[e] == ch)//at char ch splitting it
                    {
                        h = bulls_string6.Split(ch);
                    }
                    e++;
                } while (e < bulls_string6.Length);
                string y = "";
                int u = h[0].Length - 1;
                do//reversing the string while decrementing
                {
                    y = y + bulls_string6[u];
                    u--;
                } while (u >= 0);
                string prefix_string = ch + y + h[1];
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}