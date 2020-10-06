using System;

namespace DelgatesFuncT
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ProcessData();
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
           // data.Process(2, 3, multiplyDel);
            
            Func<int, int, int> funcAddDel = (x, y) => x + y;

            Func<int, int, int> funcMutiplyDel = (x, y) => x * y;

            data.ProcessFunc(3, 2,funcAddDel);

            var worker = new Worker();
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Worked : " + e.Hours + "hours doing: " + e.WorkType);
                Console.WriteLine("Some Other value");
            };
            worker.WorkCompleted += (s, e) => Console.WriteLine("Work is done");


            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

        //static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours worked : " + e.Hours + " " + e.WorkType);
        //}
        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is done");

        //}

    }
}

