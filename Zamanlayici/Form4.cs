using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamanlayici
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int saniye = 59;
        Form1 kontrol = (Form1)Application.OpenForms["Form1"];

        private void Form4_Load(object sender, EventArgs e)
        {
            if (kontrol.bilgkpt != 1)
            {
                
                timer1.Start();
                alrmlbl.Text = "Alarm Devrede";
            }
            else
            {
                
                timer2.Start();
                alrmlbl.Text = "Bilgisayar Kapatılıyor";
                saniye = 10;
            }
            kontrol.bilgkpt = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                
                pictureBox1.Visible = true;
                btndurdur.Text = "Durdur" + "(" + saniye.ToString() + ")";
                if (saniye != 0)
                {
                    saniye -= 1;
                }
                else
                {
                    kontrol.cal.controls.stop();
                    timer1.Stop();
                    this.Hide();
                }
            
         

        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
           if (pictureBox1.Visible==true)
            {
                kontrol.cal.controls.stop();
                timer1.Stop();
                this.Hide();
            }
            else
            {
                kontrol.bilgkpt = 0;
                System.Diagnostics.Process.Start("shutdown", " -a");
                timer2.Stop();
                this.Hide();
           }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            pictureBox2.Visible = true;
         
            btndurdur.Text = "Durdur" + "(" + saniye.ToString() + ")";
            if (saniye != 0)
            {
                saniye -= 1;
            }
            else
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s");
                timer2.Stop();
                this.Hide();
            }
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                kontrol.cal.controls.stop();
                timer1.Stop();
                this.Hide();
            }
            else
            {
                kontrol.bilgkpt = 0;
                System.Diagnostics.Process.Start("shutdown", " -a");
                timer2.Stop();
                this.Hide();
            }

        }
    }
}
