using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Aggregator
{
    static class Program
    {
        public static Schedule schedule;
        public static Results results;
        public static Standings standings;
        public static Teams teams;
        public static ExtendedResults extendedResults;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            schedule = new Schedule();
            results = new Results();
            standings = new Standings();
            teams = new Teams();
            extendedResults = new ExtendedResults();

            Application.Run(schedule);
        }
    }
}
