using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace GeforyAPI
{
    public static class calculator
    {
        private static string answer;
        private static double value2inputs3;
        private static double value1inputs3;

        public static string compute(string input)
        {
            answer = new DataTable().Compute(input, "").ToString();
            return answer;

        }

        


       
        public static string compute3inputs(string input1, char op, string input2)
        {
            string convertinput1;
            string convertinput2;
            switch (input1)
            {
                case "pi":
                    convertinput1 = input1.Replace("pi" , "3.141592");
                    break;
                case "e":
                    convertinput1 = input1.Replace("e", "2.718281");
                    break;
                default:
                    convertinput1 = input1;
                    break;
            }
            switch (input2)
            {
                case "pi":
                    convertinput2 = input2.Replace("pi", "3.141592");
                    break;
                case "e":
                    convertinput2 = input2.Replace("e", "2.718281");
                    break;
                default:
                    convertinput2 = input2;
                    break;

            }
            
            try
            {
                value1inputs3 = Convert.ToInt32(convertinput1);
                value2inputs3 = Convert.ToInt32(convertinput2);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Falsche eingabe");
                answer = "error";
            }



            switch (op)
            {
                case '*':
                    answer = Convert.ToString(value1inputs3 * value2inputs3);
                    break;
                case '/':
                    answer = Convert.ToString(value1inputs3 / value2inputs3);
                    break;
                case '+':
                    answer = Convert.ToString(value1inputs3 + value2inputs3);
                    break;
                case '-':
                    answer = Convert.ToString(value1inputs3 - value2inputs3);
                    break;
                case '%':
                    answer = Convert.ToString(value1inputs3 % value2inputs3);
                    break;
                case '^':
                    answer = Convert.ToString(Math.Pow(value1inputs3, value2inputs3));
                    break;
                default:
                    answer = "error";
                    break;
            }
            return answer;
        }





    }


    
}
