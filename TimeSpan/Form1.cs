using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpan
{
    public partial class TimeSpan : Form
    {
        public TimeSpan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time1 = DateTime.Parse(textBox1.Text);
            DateTime time2 = DateTime.Parse(textBox2.Text);

            label3.Text = (time2 - time1).ToString();
        }
    }
}
