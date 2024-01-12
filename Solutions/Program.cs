using System;
using System.Collections.Immutable;

namespace Solutions
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Solution1 solution1=new Solution1();
            String str = "101101";

            Dictionary<string, string> Dictionary = new Dictionary<string, string>(){{"00", "A"},
                                                                                  {"10", "B"},
                                                                                  {"01", "C"},
                                                                                  {"11", "D" } };

            String answer1=solution1.HuffmanDecoding(str, Dictionary);

            Console.WriteLine(answer1);
            */

            /*
            Solution2 solution2=new Solution2();
            String s = "abb";
            String t = "c";

            String answer2 = solution2.replaceString(s,t);

            Console.WriteLine(answer2);   
            
            */

            /*
            Solution3 solution3=new Solution3();

            int[] numbers = {11,11,49,7,11,11,7,7,11,49,11};

            int answer3=solution3.minChanges(numbers);


            Console.WriteLine("answer is : " + answer3);

            */

           
            Solution4 solution4=new Solution4();
            solution4.setInput();
            Console.WriteLine(solution4.decodedString());
            

            /*
            Solution5 solution5 = new Solution5();
            solution5.setInput();
            Console.WriteLine(solution5.FindMaxAvgDifference());
           

            Solution6 solution6=new Solution6();
            solution6.setInput();
            Console.WriteLine(solution6.scoreOfAll());
            

            Solution7 solution7 = new Solution7();
            solution7.setInput();
            Console.WriteLine(solution7.largestSubString());
           

            Solution8 solution8 = new Solution8();
            solution8.setInput();
            Console.WriteLine(solution8.beautyOfString());
            */



        }






    }

    
}
