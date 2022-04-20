using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop4
{
    public partial class Form2 : Form
    {
        Form1 f;
        delegate void myType();
        event myType myEvent1;

        delegate void Type();
        event myType myEvent2;
        public Form2(Form1 form1)
        {
            f = form1;
            InitializeComponent();
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);

            myEvent2 += form1.myFunction5;
            myEvent1 += myFunction4;
        }
        public void myFunction1(int numi)
        {
            string str = "Кнопка натиснута:"
            +Convert.ToString(numi)
            + " раз ";
            label1.Text = str;
        }
        public void myFunction2(int nump)
        {
            progressBar1.Value = nump % 100;
        }
        public void myFunction4()
        {
            int hj = Convert.ToInt32(progressBar1.Value);
            if (hj % 10 == 0)
            {
                f.button1.Left += 15;
            }
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
