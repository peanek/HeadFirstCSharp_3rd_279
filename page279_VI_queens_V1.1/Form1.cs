using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page279_VI_queens_V1._1
{
    public partial class Form1 : Form
    {
        Worker[] workers;
        Queen queen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" ,
            "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
            comboBox1_jobSelect.SelectedIndex = 0;

        }

        private void button1_assignBee_Click(object sender, EventArgs e)
        {
            if (numericUpDown1_shiftNumber.Value < 1)
            {
                MessageBox.Show("Shift number cannot be 0");
            }
            else
            {
                if (queen.AssignWork(comboBox1_jobSelect.Text, (int)numericUpDown1_shiftNumber.Value))
                {
                    MessageBox.Show("The job '"+comboBox1_jobSelect.Text+"' will be done in "+numericUpDown1_shiftNumber.Value+" shifts.");
                }
                else
                {
                    MessageBox.Show("Not possible to assing any job !!!");
                }
            }
        }

        private void button1_workShift_Click(object sender, EventArgs e)
        {
            textBox1_reportBox.Text = queen.WorkTheNextShift();
        }
    }
}

/* Nectar collector
Honey manufacturing
Egg care
Baby bee tutoring
Hive maintenance
Sting patrol
*/