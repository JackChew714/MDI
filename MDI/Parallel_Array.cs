using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Parallel_Array : Form
    {
        string[] peopleName = { "jack", "joker", "jaccy", "jimmy" };
        string[] phone = { "012-435533", "017-34545", "018-232233", "019-2333" };
        public Parallel_Array()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Parallel_Array_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index;
            for(index=0; index<= peopleName.GetUpperBound(0); index++)
            {
                if (textBox1.Text.Equals(peopleName[index]))
                {
                    break;
                }
            }
            label3.Text = phone[index];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date =monthCalendar1.SelectionRange.Start.ToShortDateString();
            label4.Text = date;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker3.Value.ToShortDateString().ToString();
            label5.Text = date;
           
        }
    }
}
