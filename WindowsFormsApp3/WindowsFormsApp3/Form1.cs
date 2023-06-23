using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            random = new Random();
        }
        int score = 0;
        bool click = false;
        bool click1 = false;
        bool click2 = false;
        bool click3 = false;
       
      

        private Random random;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            score++;
            lblPoint.Text = score.ToString();
           click = true;
            pictureBox2.Visible = false;
            pictureBox2.Visible = true;
            int x = random.Next(0, ClientSize.Width - pictureBox2.Width);
            int y = random.Next(0, ClientSize.Height - pictureBox2.Height);
            pictureBox2.Location = new Point(x, y);
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPoint.Text = score.ToString();
            timer1.Start();
            timer2.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time10 = 0;
            time10++;
            
           
            if(click == false)
            {
              
                pictureBox2.Visible=false;
                score--;
                lblPoint.Text = score.ToString();
                int x = random.Next(0, ClientSize.Width - pictureBox2.Width);
                int y = random.Next(0, ClientSize.Height - pictureBox2.Height);
                pictureBox2.Location = new Point(x, y);
                pictureBox2.Visible = true;
               
            }
            if (click1 == false)
            {

                pictureBox3.Visible = false;
                score--;
                lblPoint.Text = score.ToString();
                int v = random.Next(0, ClientSize.Width - pictureBox3.Width);
                int d = random.Next(0, ClientSize.Height - pictureBox3.Height);
                pictureBox3.Location = new Point(v, d);
                pictureBox3.Visible = true;
            }
            if (click2 == false)
            {

                pictureBox4.Visible = false;
                score--;
                lblPoint.Text = score.ToString();
                int x = random.Next(0, ClientSize.Width - pictureBox4.Width);
                int y = random.Next(0, ClientSize.Height - pictureBox4.Height);
                pictureBox4.Location = new Point(x, y);
                pictureBox4.Visible = true;
            }
            if (click3 == false)
            {

                pictureBox5.Visible = false;
                score--;
                lblPoint.Text = score.ToString();
                int x = random.Next(0, ClientSize.Width - pictureBox5.Width);
                int y = random.Next(0, ClientSize.Height - pictureBox5.Height);
                pictureBox5.Location = new Point(x, y);
                pictureBox5.Visible = true;
            }
            click = false;
            click1= false;
            click2= false;
            click3= false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            score++;
            lblPoint.Text = score.ToString();
            click1 = true;
            pictureBox3.Visible = false;
            pictureBox3.Visible = true;
            int v = random.Next(0, ClientSize.Width - pictureBox3.Width);
            int d = random.Next(0, ClientSize.Height - pictureBox3.Height);
            pictureBox3.Location = new Point(v, d);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            score++;
            lblPoint.Text = score.ToString();
            click2 = true;
            pictureBox4.Visible = false;
            pictureBox4.Visible = true;
            int x = random.Next(0, ClientSize.Width - pictureBox4.Width);
            int y = random.Next(0, ClientSize.Height - pictureBox4.Height);
            pictureBox4.Location = new Point(x, y);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            score++;
            lblPoint.Text = score.ToString();
            click3 = true;
            pictureBox5.Visible = false;
            pictureBox5.Visible = true;
            int x = random.Next(0, ClientSize.Width - pictureBox5.Width);
            int y = random.Next(0, ClientSize.Height - pictureBox5.Height);
            pictureBox5.Location = new Point(x, y);
        }
    }
   }

