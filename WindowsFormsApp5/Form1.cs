using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шифр_Цезаря
{
    public partial class Form1 : Form
    {
        Cesar Me = new Cesar();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Me.Codec(textBox1.Text, (int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Me.Codec(textBox2.Text, -(int)numericUpDown1.Value);
        }
    }
}
