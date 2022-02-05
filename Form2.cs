using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Who_wants_to_be_a_millionaire
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void aktivlik()
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
        }

        SqlConnection baglan = new SqlConnection("Data Source =.; Initial Catalog = sorularim; Integrated Security = True");
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled=false;
            label1.Visible=false;
            pictureBox6.Visible=false;
            groupBox1.Visible= false;
            btna.BackColor = Color.FromArgb(0, 0, 58);
            btnb.BackColor = Color.FromArgb(0, 0, 58);
            btnc.BackColor = Color.FromArgb(0, 0, 58);
            btnd.BackColor = Color.FromArgb(0, 0, 58);
            button1.Enabled= false;
            button1.Text = "Sonraki";
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            sayac++;



            if (sayac == 1)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture1.png";
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text=oku["dogru"].ToString();
                }
                baglan.Close();
            }


            if (sayac == 2)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture2.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text=oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 3)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture3.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 4)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture4.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 5)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture5.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 6)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture6.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 7)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture7.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 8)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture8.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 9)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture9.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 10)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture10.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru10 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 11)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture11.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru11 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 12)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture12.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru12 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 13)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture13.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru13 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 14)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture14.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru14 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }

            if (sayac == 15)
            {
                pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Who wants to be a millionaire\\picture15.png";
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru15 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    labeldogru.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if(sayac == 16)
            {
                button1.Enabled = false;
                aktivlik();
                MessageBox.Show("Oyun bitdi.Milyonersinizzzz!");
            }




        }

        private void btna_Click(object sender, EventArgs e)
        {
            if(btna.Text == labeldogru.Text)
            {
                btna.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else 
            {
                btna.BackColor=Color.Red;
                button1.Enabled = false;
            }
            aktivlik();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            if (btnb.Text == labeldogru.Text)
            {
                btnb.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                btnb.BackColor = Color.Red;
                button1.Enabled = false;
            }
            aktivlik();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            if (btnc.Text == labeldogru.Text)
            {
                btnc.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                btnc.BackColor = Color.Red;
                button1.Enabled = false;
            }
            aktivlik();
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            if (btnd.Text == labeldogru.Text)
            {
                btnd.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                btnd.BackColor = Color.Red;
                button1.Enabled = false;
            }
            aktivlik();
        }

        // 50/50 jokeri
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(btna.Text != labeldogru.Text && btnb.Text!=labeldogru.Text)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
            }
            else if(btnb.Text != labeldogru.Text && btnc.Text != labeldogru.Text)
            {
                btnb.Enabled = false;
                btnc.Enabled = false;
            }
            else if (btnc.Text != labeldogru.Text && btna.Text!=labeldogru.Text)
            {
                btna.Enabled=false;
                btnc.Enabled = false;
            }
            else if (btnd.Text != labeldogru.Text && btna.Text!=labeldogru.Text)
            {
                btna.Enabled = false;
                btnd.Enabled = false;
            }
            else if (btnd.Text != labeldogru.Text && btnb.Text != labeldogru.Text)
            {
                btnb.Enabled = false;
                btnd.Enabled = false;
            }
            else if (btnd.Text != labeldogru.Text && btnc.Text != labeldogru.Text)
            {
                btnc.Enabled = false;
                btnd.Enabled = false;
            }
            pictureBox5.Enabled = false;
            pictureBox5.Visible= false;
        }
        // Seyirci jokeri
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            if (btna.Text == labeldogru.Text)
            {
                progressBar1.Value = 71;
                progressBar2.Value = 13;
                progressBar3.Value = 4;
                progressBar4.Value = 11;
                label6.Text = "71%";
                label7.Text = "13%";
                label8.Text = "4%";
                label9.Text = "11%";
            }
            else if (btnb.Text == labeldogru.Text)
            {
                progressBar1.Value = 13;
                progressBar2.Value = 71;
                progressBar3.Value = 4;
                progressBar4.Value = 11;
                label6.Text = "13%";
                label7.Text = "71%";
                label8.Text = "4%";
                label9.Text = "11%";
            }
            else if (btnc.Text == labeldogru.Text)
            {
                progressBar1.Value = 4;
                progressBar2.Value = 13;
                progressBar3.Value = 71;
                progressBar4.Value = 11;
                label6.Text = "4%";
                label7.Text = "13%";
                label8.Text = "71%";
                label9.Text = "11%";
            }
            else if (btnd.Text == labeldogru.Text)
            {
                progressBar1.Value = 11;
                progressBar2.Value = 13;
                progressBar3.Value = 4;
                progressBar4.Value = 71;
                label6.Text = "11%";
                label7.Text = "13%";
                label8.Text = "4%";
                label9.Text = "71%";
            }
            pictureBox3.Enabled = false;
            pictureBox3.Visible = false;
        }

        //cift cevab jokeri
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            label1.Visible = true;
            label1.Text = ("Cevab-->"+labeldogru.Text);
            pictureBox4.Visible = false;
        }
        }
    }

