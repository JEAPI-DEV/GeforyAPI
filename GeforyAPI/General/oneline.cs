using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeforyAPI
{
    public static class oneline
    {
        public static void calc(string welcomemsg,string taskmsg, string errormsg, int timetowait, string byemsg)
        {
            string input;
            string output = "error";



            Console.WriteLine(welcomemsg);
            Console.WriteLine("");
            Console.WriteLine(taskmsg);
            input = Console.ReadLine();

            try
            {
                output = new DataTable().Compute(input, "").ToString();
            }
            catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine(errormsg);
                Thread.Sleep(timetowait /* 3sec */ );
                calc(welcomemsg, taskmsg, errormsg, timetowait, byemsg);
            }
            

            Console.Clear();
            Console.WriteLine(output);
            Console.WriteLine(byemsg);
            Console.ReadKey();
            
        }





    }
}
