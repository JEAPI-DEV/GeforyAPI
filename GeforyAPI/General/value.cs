using System.Collections.Generic;

namespace GeforyAPI
{
    public static class value
    {

        static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] thousandsGroups = { "", "-Thousand", "-Million", "-Billion" };

        private static string DoubleToWrittenbeforedot(int n, string leftDigits, int thousands)
        {
            if (n == 0)
            {
                return leftDigits;
            }


            string friendlyInt = leftDigits;

            if (friendlyInt.Length > 0)
            {
                friendlyInt += "-";
            }

            if (n < 10)
            {
                friendlyInt += ones[n];
            }
            else if (n < 20)
            {
                friendlyInt += teens[n - 10];
            }
            else if (n < 100)
            {
                friendlyInt += DoubleToWrittenbeforedot(n % 10, tens[n / 10 - 2], 0);
            }
            else if (n < 1000)
            {
                friendlyInt += DoubleToWrittenbeforedot(n % 100, (ones[n / 100] + "-Hundred"), 0);
            }
            else
            {
                friendlyInt += DoubleToWrittenbeforedot(n % 1000, DoubleToWrittenbeforedot(n / 1000, "", thousands + 1), 0);
                if (n % 1000 == 0)
                {
                    return friendlyInt;
                }
            }

            return friendlyInt + thousandsGroups[thousands];
        }

        private static string DoubleToWrittenafterdot(int n)
        {
            List<int> listOfInts = new List<int>();
            string friendlyvalue = "";
            int i = 0;
            string numlenght = n.ToString();

            while (n > 0)
            {
                listOfInts.Add(n % 10);
                n = n / 10;
            }
            listOfInts.Reverse();
            int[] intarray = listOfInts.ToArray();

            while (i < numlenght.Length)
            {
                for (i = 0; i < numlenght.Length;)
                {
                    friendlyvalue += "-" + ones[intarray[i]];
                    i++;
                }
            }
            return friendlyvalue;
        }

        public static string ToWritten(double n)
        {
            string mainstring;

            if (n == 0)
            {
                return "Zero";
            }
            else if (n < 0)
            {
                return "Negative " + ToWritten(-n);
            }

            string s = n.ToString();
            string[] parts = s.Split('.');

            int intbeforedot = int.Parse(parts[0]);
            mainstring = DoubleToWrittenbeforedot(intbeforedot, "", 0);

            try
            {
                int intafterdot = int.Parse(parts[1]);
                mainstring += "-dot" + DoubleToWrittenafterdot(intafterdot);
            }
            catch
            {
                return mainstring;
            }

            return mainstring;


        }

        public static string ToWritten(double n, int maxnumber)
        {
            string mainstring;

            if (n > maxnumber)
            {
                return "number to big";
            }

            if (n == 0)
            {
                return "Zero";
            }
            else if (n < 0)
            {
                return "Negative " + ToWritten(-n);
            }

            string s = n.ToString();
            string[] parts = s.Split('.');

            int intbeforedot = int.Parse(parts[0]);
            mainstring = DoubleToWrittenbeforedot(intbeforedot, "", 0);

            try
            {
                int intafterdot = int.Parse(parts[1]);
                mainstring += "-dot" + DoubleToWrittenafterdot(intafterdot);
            }
            catch
            {
                return mainstring;
            }

            return mainstring;


        }

    }


}
