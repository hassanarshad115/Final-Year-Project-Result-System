using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "2016-18" && springradioButton.Checked == true)
            {
                spring1618 s = new spring1618();
                s.Show();

            }
            if (maskedTextBox1.Text == "2016-18" && fallradioButton.Checked == true)
            {

                fall1618 f = new fall1618();
                f.Show();
            }
        }
    }
}
