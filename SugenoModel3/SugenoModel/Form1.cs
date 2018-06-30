using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugenoModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double temperature = 0;
        public double wind =0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temperature =Convert.ToDouble(textBox1.Text);
            wind = Convert.ToDouble(textBox2.Text);
            Sugeno f = new Sugeno();
            f.FuzzyA(temperature);
            f.FuzzyB(wind);
            f.Center(35, 55, 75);
            f.Rule1();
            f.Rule2();
            f.Rule3();
            f.CrispResult();
            textBox3.Text=f.DisplayResult();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
        }
    }
}
