using System;
using Chinook.Logic.Model;
using Chinook.Contracts.Model;
using Chinook.Contracts.Report;
using Chinook.Logic;

namespace Chinook.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingReport marketingReport = new MarketingReport();
            var trackStatistic = marketingReport.GetTrackStatistic();

            Console.WriteLine(trackStatistic.Max.Name + " " + trackStatistic.Max.Milliseconds);
            Console.WriteLine(trackStatistic.Min.Name + " " + trackStatistic.Min.Milliseconds);
            Console.WriteLine(trackStatistic.Average);
        }
    }
}
