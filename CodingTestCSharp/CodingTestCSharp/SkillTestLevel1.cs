using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestCSharp
{
    class SkillTestLevel1
    {
        static void Main(string[] args)
        {
            int price = 3;
            int money = 20;
            int count = 4;
               

            long result = solution2(3, 20,4);
            Console.WriteLine(result);
        }

        public static int solution1(int[] d, int budget)
        {
            int answer = 0;
            Array.Sort(d);
            foreach (int item in d)
            {
                if (budget - item >= 0)
                {
                    budget -= item;
                    answer++;
                }
                else
                    break;   
            }
            return answer;
       
        }
        public static long solution2(int price, int money, int count)
        {
            int useCount = 0;
            int priceSum = 0;
            long result = 0;
            while (useCount < count)
            {
                useCount++;

                priceSum += price * useCount;
            }
           result= priceSum - money;

            if (result <=0)
                return 0;
            else
                return result;

        }

    }
}
