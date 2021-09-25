using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Simulate_Stopwatch_Program
{
    class MeasureTime
    {
        static void Main(string[] args)
        {
            var time = StopwatchHelper.MeasureRunTime(() =>
            {
                for (var x = 0; x < 2; x++)
                {
                    using (var task = Task.Delay(100))
                    {
                        task.Wait();
                    }
                }
            });
            Console.WriteLine(" Here is the elapsed time : " + time);
        }
        static class StopwatchHelper
        {
            public static TimeSpan MeasureRunTime(Action codeToRun)
            {
                var watch = Stopwatch.StartNew();
                codeToRun();
                watch.Stop();
                return watch.Elapsed;
            }
        }
    }
}
