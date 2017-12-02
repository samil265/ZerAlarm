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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       
        Form1 cek = (Form1)Application.OpenForms["Form1"];
     

        private void btnyol_Click(object sender, EventArgs e)
        {
            if (cek.chckalarm==1)
            {
               
                openFileDialog1.Filter = "Müzik Dosyası(*.wav,*.mp3)|*.wav;*.mp3;";
                openFileDialog1.InitialDirectory = Application.StartupPath;
                openFileDialog1.Title = "Dosya Seç";
                openFileDialog1.ShowDialog();
                dosyayol.Text = openFileDialog1.FileName;
                cek.url.Add(cek.tikla,openFileDialog1.FileName);
                cek.dsyadi.Add(cek.tikla,"Alarm" + "(" + openFileDialog1.SafeFileName + ")");



             }
             if (cek.chcksec==1)
             {
                 openFileDialog1.Filter = "Uygulama Dosyası(*.exe)|*.exe;";
                 openFileDialog1.InitialDirectory = Application.StartupPath;
                 openFileDialog1.Title = "Dosya Seç";
                 openFileDialog1.ShowDialog();
                 dosyayol.Text = openFileDialog1.FileName;
                 cek.prgmsec.Add("Çalıştır" + "(" + openFileDialog1.SafeFileName + ")");
                 cek.prgmurl.Add(openFileDialog1.FileName);
             }
             


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
            
        }
    }
}
