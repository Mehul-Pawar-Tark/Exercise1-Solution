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

            /*
            Solution4 solution4=new Solution4();
            String str="misip";

            int[] position = { 2, 3, 1, 7 };
            int[] lengths = { 1, 1, 2, 2 };

            
            String str = "TC206";
            int[] position = { 1,2,5};
            int[] lengths = { 1,1,1};


            String answer4 = solution4.decodedString(str,position,lengths);

            Console.WriteLine(answer4);
            */

            /*
            Solution5 solution5 = new Solution5();

            int n = 3;
            double[] numbers = { 6, 2.5, 3.5 };
            Console.WriteLine(solution5.FindMaxAvgDifference(n, numbers));

            */
            /*
            Solution6 solution6=new Solution6();

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();

            list1.Add("mouse"); list1.Add("dog");list1.Add("pig"); list1.Add("cat");
            list2.Add("pig"); list2.Add("dog");
            list3.Add("dog"); list3.Add("cat");

            Console.WriteLine(solution6.scoreOfAll(list1,list2,list3));
            */

            /*
            Solution7 solution7 = new Solution7();
            solution7.setInput();
            Console.WriteLine(solution7.largestSubString());
            */
            


            Solution8 solution8 = new Solution8();
            solution8.setInput();
            Console.WriteLine(solution8.beautyOfString());
            


        }
        
        
        

        

    }

    
}
