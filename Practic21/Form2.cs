using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true)
                {
                    main.Razdel1.Items.Add(this.textBox1.Text);
                }
                else main.Razdel2.Items.Add(this.textBox1.Text);
                this.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
