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
using System.Collections;


namespace Zamanlayici
{
    
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        public int chckalarm ;
        public int chckhatirlat;
        public int chcksec ;
        public int chckbilgkapat;

        public string mesaj;
        

        public int sayi;
        public int bilgkpt = 0;
       

        public SortedList dsyadi = new SortedList();
        public SortedList url = new SortedList();

        public SortedList prgmsec = new SortedList();
        public SortedList prgmurl = new SortedList();
  
        
        public List<string> hatirla = new List<string>();

       public WMPLib.WindowsMediaPlayer cal = new WMPLib.WindowsMediaPlayer();
       
        void alarm(int x)
        {
           
           cal.controls.stop();
            cal.URL = url.GetByIndex(x).ToString();
            cal.controls.play();
            Form4 calan = new Form4();
            calan.Show();

            
        }
      
        void hatirlat(int y)
        {

            cal.URL = Application.StartupPath + "\\Bildirim_sesi.mp3";//"C:\\C#\\kendi çalışmam\\Zamanlayici\\Zamanlayici\\bin\\Debug\\Bildirim sesi.mp3";
            cal.controls.play();
            MessageBox.Show(hatirla[y]);
        }

        void calistir(int z)
        {

            System.Diagnostics.Process calistir = new System.Diagnostics.Process();
            calistir.StartInfo.FileName = prgmurl.GetByIndex(z).ToString();
            calistir.Start();
        }
        void bilgkapat()
        {
            Form4 bilgkapat = new Form4();
            bilgkapat.Show();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
          
        }


        public int kntrlx;
        public int kntrly;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
           
            if (alarmgrp.Count > 0)

            {
                for (int i = 0; i < alarmgrp.Count; i++)
                {
                   
                    if (kntrlx==1 )
                        {
                            for (int j = 0; j < dsyadi.Count; j++)
                            {
                          
                            if (alarmlar[i].Name == "chckalarm" + Convert.ToString(i+1) && alrmlabeller[j].Text == DateTime.Now.ToLongTimeString())
                            { 
                                kntrlx = 0;
                                alarm(j);
                               
                            }
                          }
                       
                         }

                        if (htrllabeller.Count > 0)
                        {
                            for (int k = 0; k < hatirla.Count; k++)
                            {

                                if (alarmlar[i].Name == "chckhtrl" + Convert.ToString(i + 1) && htrllabeller[k].Text == DateTime.Now.ToLongTimeString())
                                {
                                
                                    hatirlat(k);

                                }
                            }
                        }


                        if (kntrly==1)
                        {
                            for (int m = 0; m < prgmsec.Count; m++)
                            {

                                if (alarmlar[i].Name == "chckprgsay" + Convert.ToString(i+1) && prgmlabeller[m].Text == DateTime.Now.ToLongTimeString())
                                {
                                kntrly = 0;
                                    calistir(m);
                                }
                            }
                        }

                    if (kptlabeller.Count > 0)
                    {
                        for (int n = 0; n < kptlabeller.Count; n++)
                        {
                           
                            if (alarmlar[i].Name == "kptchck" + Convert.ToString(i+1) && kptlabeller[n].Text == DateTime.Now.ToLongTimeString())
                            {
                                bilgkpt = 1;
                                bilgkapat();
                            }
                        }
                    }   
            }
          }
          
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            kntrlx = 0;
            kntrly = 0;
            sayi = 0;
            Form2 alarmkur = new Form2();
            alarmkur.Show();
            foreach (Control item in this.Controls)

            {
                if (item is GroupBox)
                {
                    
                        sayi++;  
                }
                
            }
          
            
            
    }
       
        public int tikla = 0;
        public int prgsay = 0;
        public int alarmsay = 0;
        public int htrlsay = 0;
        public int kptsay = 0;

        string yenisaatdeger;
        string yenidakikadeger;
        string yenisaniyedeger;

        public List<GroupBox> alarmgrp = new List<GroupBox>();
        public List<Button> butonlar = new List<Button>();

        public List<Label> alrmlabeller = new List<Label>();
        public List<Label> prgmlabeller = new List<Label>();
        public List<Label> htrllabeller = new List<Label>();
        public List<Label> kptlabeller = new List<Label>();

        public List<CheckBox> htrlbox = new List<CheckBox>();
        public List<CheckBox> alarmlar = new List<CheckBox>();
        public List<CheckBox> programlar = new List<CheckBox>();
        public List<CheckBox> kptbox = new List<CheckBox>();
        public void alarmkur1()
        {
            /* if (checkBox1.Checked==true)
             {*/
          
            Form2 oku = (Form2)Application.OpenForms["Form2"];

            //Groupbox ekleme
            GroupBox[] alarmgrp1 = new GroupBox[tikla + 1];

                alarmgrp1[tikla] = new GroupBox();
                alarmgrp1[tikla].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                alarmgrp1[tikla].ForeColor = Color.Black;
                alarmgrp1[tikla].BackColor = Color.LightSteelBlue;
                alarmgrp1[tikla].Text = "Alarm " + sayi;
                alarmgrp1[tikla].Location = new Point(45, 194);
               
                if (sayi > 1)
            {
                    alarmgrp1[tikla].Location = new Point(45, 200 + (115 * (sayi - 1)));
            }
                alarmgrp1[tikla].Size = new Size(385, 110);
                alarmgrp1[tikla].Name = "alarm" + Convert.ToString(sayi);
             alarmgrp.Add(alarmgrp1[tikla]);
            this.Controls.Add(alarmgrp[tikla]);
                

            //buton oluşturma
          Button[] yap = new Button[tikla + 1];

            yap[tikla] = new Button();
            yap[tikla].Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            yap[tikla].ForeColor = Color.Black;
            yap[tikla].UseVisualStyleBackColor = true;
            yap[tikla].Text = "İptal Et";
            yap[tikla].Location = new Point(280, 40);
            yap[tikla].Size = new Size(87, 41);
            yap[tikla].Name = "btn" + Convert.ToString(sayi);
                alarmgrp1[tikla].Controls.Add(yap[tikla]);
            yap[tikla].Click += new EventHandler(yap_Click);

            butonlar.Add(yap[tikla]);

               
                //checkbox oluşturma
                CheckBox[] chckkntrl = new CheckBox[tikla + 1];

                chckkntrl[tikla] = new CheckBox();
                chckkntrl[tikla].Font = new Font("Microsoft Sans Serif", 10);
                chckkntrl[tikla].ForeColor = Color.Black;
                chckkntrl[tikla].UseVisualStyleBackColor = true;
               
                chckkntrl[tikla].Location = new Point(23, 84);
                chckkntrl[tikla].Size = new Size(350, 21);

                if (chckalarm==1)
                {
                    chckalarm = 0;
                  
                    chckkntrl[tikla].Text = dsyadi[tikla].ToString();
                    chckkntrl[tikla].Name = "chckalarm" + Convert.ToString(sayi);

                    
               Label[] alrmlbl = new Label[alarmsay + 1];

                    alrmlbl[alarmsay] = new Label();
                    alrmlbl[alarmsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    alrmlbl[alarmsay].ForeColor = Color.Black;
                   
                    if (oku.saat.Value < 10)
                    {
                        yenisaatdeger = "0" + oku.saat.Value.ToString();
                    }

                    else
                    {
                        yenisaatdeger = oku.saat.Value.ToString();
                    }
                    
                    if (oku.dakika.Value < 10)
                    {
                        yenidakikadeger = "0" + oku.dakika.Value.ToString();
                    }
                    else
                    {
                        yenidakikadeger = oku.dakika.Value.ToString();
                    }

                    
                    if (oku.saniye.Value < 10)
                    {
                        yenisaniyedeger = "0" + oku.saniye.Value.ToString();
                    }

                    else
                    {
                        yenisaniyedeger = oku.saniye.Value.ToString();
                    }

                    alrmlbl[alarmsay].Text = yenisaatdeger + ":" + yenidakikadeger + ":" + yenisaniyedeger;
                    alrmlbl[alarmsay].Location = new Point(23, 45);
                    alrmlbl[alarmsay].Size = new Size(100, 39);
                    alrmlbl[alarmsay].Name = "alrmlbl" + Convert.ToString(sayi);

                    alrmlabeller.Add(alrmlbl[alarmsay]);
                    alarmgrp1[tikla].Controls.Add(alrmlabeller[alarmsay]);

                    alarmsay += 1;
                   
                  
                }
                else if (chckhatirlat == 1)
                {
                   chckhatirlat = 0;
                    
                    chckkntrl[tikla].Text = "Hatırlat";
                    chckkntrl[tikla].Name = "chckhtrl" + Convert.ToString(sayi);

                    Label[] htrlbl = new Label[htrlsay + 1];

                    htrlbl[htrlsay] = new Label();
                    htrlbl[htrlsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    htrlbl[htrlsay].ForeColor = Color.Black;
                    
                    if (oku.saat.Value < 10)
                    {
                        yenisaatdeger = "0" + oku.saat.Value.ToString();
                    }

                    else
                    {
                        yenisaatdeger = oku.saat.Value.ToString();
                    }

                 
                    if (oku.dakika.Value < 10)
                    {
                        yenidakikadeger = "0" + oku.dakika.Value.ToString();
                    }
                    else
                    {
                        yenidakikadeger = oku.dakika.Value.ToString();
                    }

                    
                    if (oku.saniye.Value < 10)
                    {
                        yenisaniyedeger = "0" + oku.saniye.Value.ToString();
                    }

                    else
                    {
                        yenisaniyedeger = oku.saniye.Value.ToString();
                    }

                    htrlbl[htrlsay].Text = yenisaatdeger + ":" + yenidakikadeger + ":" + yenisaniyedeger;
                    htrlbl[htrlsay].Location = new Point(23, 45);
                    htrlbl[htrlsay].Size = new Size(100, 39);
                    htrlbl[htrlsay].Name = "htrlbl" + Convert.ToString(sayi);

                    htrllabeller.Add(htrlbl[htrlsay]);
                    alarmgrp1[tikla].Controls.Add(htrllabeller[htrlsay]);

                    htrlsay += 1;


                }
                else if (chcksec==1)
                {
                    chcksec = 0;

                    chckkntrl[tikla].Text = prgmsec[tikla].ToString();
                    chckkntrl[tikla].Name = "chckprgsay" + Convert.ToString(sayi);

                    Label[] prgmlbl = new Label[prgsay + 1];

                    prgmlbl[prgsay] = new Label();
                    prgmlbl[prgsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    prgmlbl[prgsay].ForeColor = Color.Black;
                    
                    if (oku.saat.Value < 10)
                    {
                        yenisaatdeger = "0" + oku.saat.Value.ToString();
                    }

                    else
                    {
                        yenisaatdeger = oku.saat.Value.ToString();
                    }
                    
                    if (oku.dakika.Value < 10)
                    {
                        yenidakikadeger = "0" + oku.dakika.Value.ToString();
                    }
                    else
                    {
                        yenidakikadeger = oku.dakika.Value.ToString();
                    }
                    
                    if (oku.saniye.Value < 10)
                    {
                        yenisaniyedeger = "0" + oku.saniye.Value.ToString();
                    }

                    else
                    {
                        yenisaniyedeger = oku.saniye.Value.ToString();
                    }

                    prgmlbl[prgsay].Text = yenisaatdeger + ":" + yenidakikadeger + ":" + yenisaniyedeger;
                    prgmlbl[prgsay].Location = new Point(23, 45);
                    prgmlbl[prgsay].Size = new Size(100, 39);
                    prgmlbl[prgsay].Name = "prgmlbl" + Convert.ToString(sayi);

                    prgmlabeller.Add(prgmlbl[prgsay]);
                    alarmgrp1[tikla].Controls.Add(prgmlabeller[prgsay]);

                    prgsay += 1;
                }
                 else if (chckbilgkapat==1)
                 {
                    chckbilgkapat = 0;
                 
                    chckkntrl[tikla].Text = "Bilgisayarı Kapat";
                    chckkntrl[tikla].Name = "kptchck" + Convert.ToString(sayi);

                    Label[] kptlbl = new Label[kptsay + 1];

                    kptlbl[kptsay] = new Label();
                    kptlbl[kptsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    kptlbl[kptsay].ForeColor = Color.Black;
                    
                    if (oku.saat.Value < 10)
                    {
                        yenisaatdeger = "0" + oku.saat.Value.ToString();
                    }

                    else
                    {
                        yenisaatdeger = oku.saat.Value.ToString();
                    }

                    

                    if (oku.dakika.Value < 10)
                    {
                        yenidakikadeger = "0" + oku.dakika.Value.ToString();
                    }
                    else
                    {
                        yenidakikadeger = oku.dakika.Value.ToString();
                    }

                   
                    if (oku.saniye.Value < 10)
                    {
                        yenisaniyedeger = "0" + oku.saniye.Value.ToString();
                    }

                    else
                    {
                        yenisaniyedeger = oku.saniye.Value.ToString();
                    }

                    kptlbl[kptsay].Text = yenisaatdeger + ":" + yenidakikadeger + ":" + yenisaniyedeger;
                    kptlbl[kptsay].Location = new Point(23, 45);
                    kptlbl[kptsay].Size = new Size(100, 39);
                    kptlbl[kptsay].Name = "kptlbl" + Convert.ToString(sayi);

                    kptlabeller.Add(kptlbl[kptsay]);
                    alarmgrp1[tikla].Controls.Add(kptlabeller[kptsay]);

                    kptsay += 1;

                }
               else
                {

                    chckkntrl[tikla].Text = "Boş Alarm";
                    chckkntrl[tikla].Name = "chckbos" + Convert.ToString(sayi);
                   
                }


                if (chckkntrl[tikla].Name == "chckbos" + Convert.ToString(sayi))
                {
                    
                    MessageBox.Show("Hiç bir işlem seçilmedi!!!");
                }

                alarmlar.Add(chckkntrl[tikla]);
                alarmgrp1[tikla].Controls.Add(alarmlar[tikla]);




                tikla = tikla+1;


            }
          /*  checkBox1.Checked = false;


        }*/
      
       
        public void yap_Click(object sender, EventArgs e)
        {

            Button tiklanan = (sender as Button);
            
            int index2 = butonlar.IndexOf(tiklanan);
            
           if (alarmlar[index2].Name== "chckalarm" + Convert.ToString(index2+1))
            {
               
                alarmlar[index2].Dispose();
                dsyadi.Remove(dsyadi.IndexOfKey(index2));
                url.Remove(dsyadi.IndexOfKey(index2));
               
            }else if(alarmlar[index2].Name == "chckprgsay" + Convert.ToString(index2 + 1))
            {
                alarmlar[index2].Dispose();
                prgmsec.Remove(prgmsec.IndexOfKey(index2));
                prgmurl.Remove(prgmsec.IndexOfKey(index2));

            } else if(alarmlar[index2].Name == "chckhtrl" + Convert.ToString(index2 + 1))
            {
                alarmlar[index2].Dispose();
            }
            else if (alarmlar[index2].Name == "kptchck" + Convert.ToString(index2 + 1))
            {
                alarmlar[index2].Dispose();
            }
            else
            {
                alarmlar[index2].Dispose();
            }

            alarmgrp[index2].Dispose();
            if (index2!= alarmgrp.Count-1)
            {
                for (int i = 0; i < alarmgrp.Count - 1; i++)
                {
                    if (alarmgrp[i + 1] != null)
                    {
                        alarmgrp[i + 1].Location = new Point(45, 200 + (115 * (i-index2)));

                    }
                }
                    
              
          }
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                DialogResult dr = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                Application.Exit();
               
                }
                else if (dr == DialogResult.No)
                { e.Cancel = true; }
          
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dr2 == DialogResult.Yes)
            {
                Application.Exit();

            }
            else 
            { this.Hide(); }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Alarm Bildirimi", "Kurulu alarmlar arka planda çalışmaktadır.", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
