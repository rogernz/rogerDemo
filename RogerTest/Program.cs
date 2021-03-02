using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RogerTest
{


    class Program
    {

        public static int FindMaxSum(List<int> list)
        {
            // return list.OrderByDescending(z => z).Take(2).Sum();

            int max1 = -1;
            int max2 = -1;
            foreach (int num in list)
            {
                if (num > max1) { max2 = max1; max1 = num; }
                else if (num > max2) { max2 = num; }
            }
            return max1+ max2;
        }

        //public static void Main(string[] args)
        //{
        //    List<int> list = new List<int> { 5, 9, 7, 11 };
        //    Console.WriteLine(FindMaxSum(list));
        //}



        public static List<string> ChangeDateFormat(List<string> dates)
        {
            CultureInfo enUS = new CultureInfo("en-US");

            List<string> output = new List<string>();
            string formattedData;
            foreach (string data in dates)
            {
                formattedData = GetFormattedData(data, enUS);
                if (formattedData != null) {
                    output.Add(formattedData);
                }
            }
            return output;
        }

        private static string GetFormattedData(string data, CultureInfo enUS) {
            var formatStrings = new string[] { "yyyy/MM/dd", "dd/MM/yyyy", "MM-dd-yyyy" };
            DateTime dateValue;
            try
            {
                if (DateTime.TryParseExact(data, formatStrings, enUS, DateTimeStyles.None, out dateValue))
                {
                    return dateValue.ToString("yyyyMMdd");
                }
            }
            catch
            {
                
            }

            return null;
        }

        public static void Main(string[] args)
        {
            var input = new List<string> { "2010/03/30", "15/12/2016", "11-15-2012", "20130720" };
            ChangeDateFormat(input).ForEach(Console.WriteLine);
        }
        public  class Counter
        {
            private int count = 0;
            private int increment;

            public Counter(int increment)
            {
                this.increment = increment;
            }

            public int GetAndIncrement()
            {
                this.count += this.increment;
                return this.count;
            }

           
        }

        public class DocumentNameCreator 
        {
            private string prefix;

            private Counter _counter;
            public DocumentNameCreator(string prefix, Counter counter) 
            {
                this.prefix = prefix;
                _counter = counter;
            }

            public string GetNewDocumentName()
            {
                return prefix + _counter.GetAndIncrement();
            }

           

        }

       


        static void Main222(string[] args)
        {
            /*
            createIphoneByClient cp;
            //create Iphone
            cp = new createIphoneByClient(brand.Iphone);
            cp.generatePhone();
            cp = new createIphoneByClient(brand.Nokia);
            cp.generatePhone();

            createEggs createEggs;
            createEggs = new createEggs(factoryName.MengNiu);
            createEggs.generateEgg();

            createEggs = new createEggs(factoryName.YiLi);
            createEggs.generateEgg();
            //create Nokia
            */

            //doucuments[] docs = new doucuments[2];

            //docs[0] = new Resume();
            //docs[1] = new report();

            int[] data = { 1, 2, 4, 5, 6, 10 };
            //find all even number from array  
            var eventotal = data.Where(fn => fn % 2 == 0).Sum(x=>(long)x);

            LoadBalance balance1 = LoadBalance.getInstance();
            LoadBalance balance2 = LoadBalance.getInstance();
            LoadBalance balance3 = LoadBalance.getInstance();
            LoadBalance balance4 = LoadBalance.getInstance();
            LoadBalance balance5 = LoadBalance.getInstance();
            if(balance1== balance2 && balance2 == balance3 && balance3 == balance4 && balance4 == balance5)
            {
                Console.WriteLine("Same instance\n");
            }
            LoadBalance balance = LoadBalance.getInstance();
            for (int i = 0; i < 15; i++)
            {

                Console.WriteLine("server name is" + balance.GetNextServer.name);

            }

        }
    }
}
