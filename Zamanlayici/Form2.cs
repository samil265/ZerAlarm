using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Zamanlayici
{
    
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

     
       
        
        public void kur_Click(object sender, EventArgs e)
        {
            
            Form1 al = (Form1)Application.OpenForms["Form1"];
            if (al.chckalarm == 1)
            {
                al.kntrlx = 1;
            }else
            {
                al.kntrly = 1;
            }
            ((Form1)Application.OpenForms["Form1"]).alarmkur1();
            if (hatirlat.Checked==true) {
                al.hatirla.Add(hatirla.Text);
            }

            
            this.Close();
          
        }
           
        private void Form2_Load(object sender, EventArgs e)
        {
            saat.Value = DateTime.Now.Hour;
            dakika.Value = DateTime.Now.Minute;
            saniye.Value = DateTime.Now.Second;
          
        }
        Form1 kntrl = (Form1)Application.OpenForms["Form1"];
        Form3 mzkyol = new Form3();
        private void alarm_CheckedChanged(object sender, EventArgs e)
        {
           if (alarm.Checked)
            {
               
                mzkyol.lblislem.Text = "Müzik Dosya Yolu:";
                mzkyol.Show();

                kntrl.chckalarm = 1;
            }
            else
            {
                mzkyol.Hide();
                kntrl.chckalarm = 0;
            
            }
           
        }

        private void hatirla_TextChanged(object sender, EventArgs e)
        {
            hatirlat.Checked = true;
         

        }

        private void hatirlat_CheckedChanged(object sender, EventArgs e)
        {
            if (hatirlat.Checked)
            {
                kntrl.chckhatirlat = 1;
            }
            else
            {
                kntrl.chckhatirlat = 0;
            }
          
        }
        Form3 dsy_yol = new Form3();
        private void programac_CheckedChanged(object sender, EventArgs e)
        {
            if (programac.Checked)
            {
               
                dsy_yol.lblislem.Text = "Dosya Yolu:";
                dsy_yol.Show();
                kntrl.chcksec = 1;
            }
           else{
                dsy_yol.Hide();
                kntrl.chcksec = 0;
              
            }
        }

        private void bilgkapat_CheckedChanged(object sender, EventArgs e)
        {
            if (bilgkapat.Checked)
            {
                kntrl.chckbilgkapat = 1;
            }
            else
            {
                kntrl.chckbilgkapat = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
