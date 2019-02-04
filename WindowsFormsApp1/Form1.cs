using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MyClass mc;
        public Form1()
        {
            InitializeComponent();
            mc  = new MyClass();
            mc.ItsSnowing += new ItsSnowingEventHandler(this.Mc_ItsSnowing);
        }

        private void Mc_ItsSnowing(string s, int cm)
        {
            this.textBox2.Text = "Snow in " + s + " : " + cm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.comboBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mc.Snow();
        }
    }
}
