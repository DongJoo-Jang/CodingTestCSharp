using System;

namespace CSharpCodingTest
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string[] survey = { "AN", "CF", "MJ", "RT", "NA" };
        //    int[] choices = { 5, 3, 2, 7, 5 };

        //    Console.WriteLine(solution(survey,choices));
        //}



        public static string solution(string[] survey, int[] choices)
        {
            int[] score = { 0, 0, 0, 0 };
            int[] forward = { 3,2,1,0,-1,-2,-3};
            int[] reverse = { -3,-2,-1,0,1,2,3};

            string answer = "";

            for (int i = 0; i < survey.Length; i++)
            {
                char[] arr = survey[i].ToCharArray();
                if( arr[0] < arr[1])
                {
                    if (survey[i].Contains("R"))
                        score[0] += forward[choices[i]-1];
                    else if(survey[i].Contains("C"))
                        score[1] += forward[choices[i]-1];
                    else if (survey[i].Contains("J"))
                        score[2] += forward[choices[i]-1];
                    else if (survey[i].Contains("A"))
                        score[3] += forward[choices[i]-1];
                }
                else
                {
                    if (survey[i].Contains("R"))
                        score[0] += reverse[choices[i]-1];
                    else if (survey[i].Contains("C"))
                        score[1] += reverse[choices[i]-1];
                    else if (survey[i].Contains("J"))
                        score[2] += reverse[choices[i]-1];
                    else if (survey[i].Contains("A"))
                        score[3] += reverse[choices[i]-1];
                }
            }
            if(score[0] >= 0)
                answer += "R";
            else
                answer += "T";

            if (score[1] >= 0)
                answer += "C";
            else
                answer += "F";

            if (score[2] >= 0)
                answer += "J";
            else
                answer += "M";

            if (score[3] >= 0)
                answer += "A";
            else
                answer += "N";

            return answer;
        }
    }
}
