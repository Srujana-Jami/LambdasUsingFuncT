using System;
using System.Collections.Generic;
using System.Text;

namespace DelgatesFuncT
{
    public class ProcessData
    {
        public void Process(int x, int y, BizRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }

        public void ProcessFunc(int x, int y, Func<int, int,int> del)
        {
            var result = del (x, y);
            Console.WriteLine(result);
        }
    }
}
