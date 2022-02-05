using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_wants_to_be_a_millionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length >0)
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true;
                label4.BackColor=Color.Red;
            }
        }
    }
}
