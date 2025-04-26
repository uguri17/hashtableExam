using System;
using System.Collections;
using static System.Console;

namespace hashtableExam
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 회사 : Microsoft
            // URL : www.ms.com

            // <Hashtable init 1>
            /*Hashtable ht = new Hashtable();
            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";*/

            // <Hashtable init 2>
            Hashtable ht = new Hashtable()
            {
                { "회사", "Microsoft" },
                { "URL", "www.microsoft.com"}
            };

            foreach (DictionaryEntry entry in ht)
            {
                WriteLine($"{entry.Key} : {entry.Value}");
            }
                
        }
    }
}
