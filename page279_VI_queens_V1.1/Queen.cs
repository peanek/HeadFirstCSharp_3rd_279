using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page279_VI_queens_V1._1
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shiftNumer)
        {
            
            foreach (Worker work in workers)
            {
                if (work.DoThisJob(job,shiftNumer))
                {

                    return true;
                }
            }

            return false;

        }

        public string WorkTheNextShift()
        {
            string output = "";
            output+="Report for shift #"+shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                {
                    output += "Worker #" + (i+1) + " finished the job.\r\n";
                }
                if(string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    output += "Worker #" + (i + 1) + " is not working. \r\n";
                }
                if (!string.IsNullOrEmpty(workers[i].CurrentJob) && workers[i].ShiftsLeft > 1)
                {
                    output += "Worker #" + (i+1) + " is doing " + workers[i].CurrentJob + " for " +
                        workers[i].ShiftsLeft + " more shifts. \r\n";
                }
                if (!string.IsNullOrEmpty(workers[i].CurrentJob) && workers[i].ShiftsLeft == 1)
                {
                    output += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift.\r\n";
                }
                
            }

            shiftNumber++;
            return output;
 
        }



    }
}
