using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            var anInstanceofMyClass = new Program();
            int[] test = new int[8];
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine("Can you answer this question?");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("How long did it take to answer this question");
                    test[i] = Convert.ToInt32(Console.ReadLine());

                }

            }
            foreach(int x in test)
            {
                Console.WriteLine(x);
            }
            string result = anInstanceofMyClass.InterviewResult(test, 101);
            //Console.Clear();

            Console.WriteLine(result);
        }

        public string InterviewResult(int[] answers, int total)
        {
            if (total > 120)
            {
                Console.WriteLine("over the time limit");
                return "disqualified";
            }
            else
            {
                if (answers[0] <= 5 && answers[1] <= 5 && answers[0] != 0 && answers[1] != 0 )
                {
                    if (answers[2] <= 10 && answers[3] <= 10 && answers[2] != 0 && answers[3] != 0)
                    {
                        if (answers[4] <= 15 && answers[5] <= 15 && answers[4] != 0 && answers[5] != 0)
                        {
                            if (answers[6] <= 20 && answers[7] <= 20 && answers[6] != 0 && answers[7] != 0)
                            {
                                return "qualified";
                            }
                            else
                            {
                                Console.WriteLine("over the time limit of 20 minutes or not answered");
                                return "disqualified";

                            }
                        }
                        else
                        {
                            Console.WriteLine("over the time limit of 15 minutes or not answered");
                            return "disqualified";
                        }
                    }
                    else
                    {
                        Console.WriteLine("over the time limit of 10 minutes or not answered");
                        return "disqualified";
                    }

                }
                else
                {
                    Console.WriteLine("over the time limit of 5 minutes or not answered");
                    return "disqualified";
                }


            }

        }
    }
}
