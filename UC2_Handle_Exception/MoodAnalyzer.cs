using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Handle_Exception
{
    internal class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {

                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                    Console.WriteLine("i am in happy mood");
                }
                else
                {
                    return "sad";
                    Console.WriteLine("i am in sad mood");
                }
            }
            catch (NullReferenceException)
            {
                return "happy";

            }
        }
    }
}

    

