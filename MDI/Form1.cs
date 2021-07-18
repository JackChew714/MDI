using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MDI
{
    public partial class Form1 : Form
    {
        int number = 0;
       
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        Form2 f2;
        private void fORM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                //f2.FormClosed +=new FormClosedEventHandler(F2_FormClosed);
                f2.FormClosed += F2_FormClosed1;
                f2.Show();
            }
            else
            {       
                f2.Activate();
            }
           

        }

        private void F2_FormClosed1(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }

       

        private void fORM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult reply;
            reply= MessageBox.Show("are you sure to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(reply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach(Control ctl in this.Controls)
            {
                if(ctl is MdiClient)
                {
                    ctl.BackColor = System.Drawing.Color.Beige;
                }
            }
        }

        private void page1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(number % 2 != 0)
            {
                panel1.Visible = true;
                number++;
            }
            else
            {
                panel1.Visible = false;
                number++;
            }
         
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = ++x;
            MessageBox.Show(y.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] gpa = { 1, 2, 3, 4, 5 };
            for(int x =0; x<gpa.GetUpperBound(0); x++)
            {
                listBox1.Items.Add(gpa[x]);
            }
            MessageBox.Show(gpa.GetUpperBound(0).ToString());
        }
    }
}
