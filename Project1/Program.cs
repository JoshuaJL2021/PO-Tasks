using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    class Program
    { /*
    Given a string text. Write a function that returns the character with the highest frequency. If more than 1 character has the same highest frequency, return all those characters as a comma separated string. If there is no repetition in characters, return "No Repetition".

Examples
MaxOccur("Computer Science") ➞ "e"

MaxOccur("Edabit") ➞ "No Repetition"

MaxOccur("system admin") ➞ "m, s"

MaxOccur("the quick brown fox jumps over the lazy dog") ➞ " "

Notes:
Characters are case sensitive, so, for example, "C" and "c" are counted separately
    */
        static void Main(string[] args)
        {
            var anInstanceofMyClass = new Program();
            Console.WriteLine("Enter Your string");
            string text = Console.ReadLine();
            string result="";
            result=anInstanceofMyClass.MaxOccur(text);
            if(result==" ") 
            {
                Console.WriteLine("Max Occurence => "+'"'+'"' );
            }
            else
            {
                 Console.WriteLine("Max Occurence => "+ result );
            }
           
           // Console.ReadLine();

        }
        public string MaxOccur(string param)
        {
            List<char> test = new List<char>();
            IEnumerable<char> final = test;
            int occur = 0;
            int total = 0;
            string result = "";
            char current = 'a';
            foreach (char x in param)
            {
                test.Add(x);
            }
            for (int i = 0; i < test.Count; i++)
            {
                current = test[i];
                foreach (char x in param)
                {
                    if (current == x)
                    {
                        occur++;
                    }

                }
                if (occur >= total)
                {
                    if (occur > total)
                    {
                        total = occur;
                        result = current.ToString();
                    }
                    if (occur == total)
                    {
                        result = result + current;
                    }


                }
                occur = 0;
                // Console.WriteLine(test[i]);


            }
            if (total == 1 || total == 0)
            {
                result="No Repetition";
                return result;

            }
            else
            {
                test.Clear();
                foreach (char x in result)
                {
                    test.Add(x);
                }
                final = test.Distinct();
                result = "";
                foreach (char x in final)
                {
                    if (result == "")
                    {
                        result = x.ToString();
                    }
                    else
                    {
                        result = result + "," + x;
                    }

                }
               return result;
              //  Console.WriteLine(total);

            }

            //Console.WriteLine(test.AsQueryable().Max());


            //return "";
        }


    }
}
