using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadingForms;

namespace F1Aggregator
{
    internal abstract class AppState
    {
        public Panel Context { get; set; }
        public abstract void loadPage();
    }

    internal class ResultsState : AppState
    {
        public ResultsState(Panel context) 
        {
            Context = context;
        }
        public override void loadPage()
        {
            LoadForm.AddForms(Context, new Results());
        }
    }

    internal class ScheduleState : AppState
    {
        public ScheduleState(Panel context)
        {
            Context = context;
        }

        public override void loadPage()
        {
            LoadForm.AddForms(Context, new Schedule());
        }
    }

    internal class StandingsState : AppState
    {
        public StandingsState(Panel context)
        {
            Context = context;
        }
        public override void loadPage()
        {
            LoadForm.AddForms(Context, new Standings());
        }
    }

    internal class TeamsState : AppState
    {
        public TeamsState(Panel context)
        {
            Context = context;
        }
        public override void loadPage()
        {
            LoadForm.AddForms(Context, new Teams());
        }
    }

    internal class HomeState : AppState
    {
        public HomeState()
        {
            Context = null;
        }
        public HomeState(Panel context)
        {
            Context = context;
        }
        public override void loadPage()
        {
            LoadForm.AddForms(Context, new MainForm());
        }
    }
}
