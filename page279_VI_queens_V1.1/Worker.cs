using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page279_VI_queens_V1._1
{
    class Worker
    {
        private string currentJob;
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        private int shiftsLeft;
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        private int shiftsToWork;
        private int shiftsWorked;

        //to do method
        public bool DoThisJob(string jobToDo, int shifts)
        {
            if (String.IsNullOrEmpty(currentJob) && jobsICanDo.Contains(jobToDo))
            {
                currentJob = jobToDo;
                shiftsToWork = shifts;
                return true;
            }

            else
            {
                return false;
            }

        }


        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;

            }

            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
            {
                shiftsWorked++;
                return false;
            }


            //if (!String.IsNullOrEmpty(currentJob) && shiftsLeft==1)
            //{
            //    currentJob = null;
            //    shiftsToWork = 0;
            //    shiftsWorked = 0;
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }



    }
}
