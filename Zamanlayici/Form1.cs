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
       

        public SortedList dsyadi = new SortedList();
        public SortedList url = new SortedList();

        public List<string> prgmsec = new List<string>();
        public List<string> prgmurl = new List<string>();
  
        
        public List<string> hatirla = new List<string>();

        WMPLib.WindowsMediaPlayer cal = new WMPLib.WindowsMediaPlayer();
        
        void alarm(int x)
        {
           
           cal.controls.stop();
            cal.URL = url.GetByIndex(x).ToString();
            cal.controls.play();

            
        }
      
        void hatirlat(int y)
        {
           
            MessageBox.Show(hatirla[y]);
        }

        void calistir(int z)
        {

            System.Diagnostics.Process calistir = new System.Diagnostics.Process();
            calistir.StartInfo.FileName = prgmurl[z];
            calistir.Start();
        }
        void bilgkapat()
        {
            System.Diagnostics.Process.Start("shutdown", "-f -s");
            //kapanma iptali
            //System.Diagnostics.Process.Start("shutdown", " -a");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
                timer1.Start();
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();

            if (checkBox3.Checked)

            {
                for (int i = 0; i < sayi; i++)
                {
                   
                    if (dsyadi.Count>0)
                        {
                            for (int j = 0; j < url.Count; j++)
                            {
                          
                            if (alarmlar[i].Name == "chckalarm" + Convert.ToString(i + 1) && alrmlabeller[j].Text == DateTime.Now.ToLongTimeString())
                                {
                                
                                alarm(j);

                                }
                          }
                       
                         }

                        if (alarmlar[i].Name == "chckhtrl" + Convert.ToString(i + 1))
                        {
                            for (int k = 0; k < hatirla.Count; k++)
                            {

                                if (htrllabeller[k].Text == DateTime.Now.ToLongTimeString())
                                {


                                    hatirlat(k);

                                }
                            }
                        }


                        if (prgmsec.Count > 0)
                        {
                            for (int m = 0; m < prgmsec.Count; m++)
                            {

                                if (alarmlar[i].Name == "chckprgsay" + Convert.ToString(i) && prgmlabeller[m].Text == DateTime.Now.ToLongTimeString())
                                {
                                    calistir(m);
                                }
                            }
                        }

                    if (kptlabeller.Count > 0)
                    {
                        for (int n = 0; n < prgmsec.Count; n++)
                        {

                            if (alarmlar[i].Name == "kptchck" + Convert.ToString(i) && kptlabeller[n].Text == DateTime.Now.ToLongTimeString())
                            {
                                    bilgkapat();
                            }
                        }
                    }   
            }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
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
           checkBox1.Text = sayi.ToString();
            
            
    }
       
        public int tikla = 0;
        public int prgsay = 0;
        public int alarmsay = 0;
        public int htrlsay = 0;
        public int kptsay = 0;
       

        public List<GroupBox> denemeler = new List<GroupBox>();
        public List<Button> butonlar = new List<Button>();

        public List<Label> alrmlabeller = new List<Label>();
        public List<Label> prgmlabeller = new List<Label>();
        public List<Label> htrllabeller = new List<Label>();
        public List<Label> kptlabeller = new List<Label>();

        public List<CheckBox> htrlbox = new List<CheckBox>();
        public List<CheckBox> alarmlar = new List<CheckBox>();
        public List<CheckBox> programlar = new List<CheckBox>();
        public List<CheckBox> kptbox = new List<CheckBox>();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {

            Form2 oku = (Form2)Application.OpenForms["Form2"];

            //Groupbox ekleme
            GroupBox[] deneme = new GroupBox[tikla + 1];

            deneme[tikla] = new GroupBox();
            deneme[tikla].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            deneme[tikla].ForeColor = Color.Black;
            deneme[tikla].BackColor = Color.LightSteelBlue;
            deneme[tikla].Text = "Alarm " + sayi;
            deneme[tikla].Location = new Point(45, 194);
               
                if (sayi > 1)
            {
             deneme[tikla].Location = new Point(45, 200 + (115 * (sayi - 1)));
            }
            deneme[tikla].Size = new Size(385, 110);
            deneme[tikla].Name = "alarm" + Convert.ToString(sayi);
            denemeler.Add(deneme[tikla]);
            this.Controls.Add(denemeler[tikla]);

            //label ekleme
        /*   Label[] gir = new Label[tikla + 1];

            gir[tikla] = new Label();
            gir[tikla].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            gir[tikla].ForeColor = Color.Black;
                if (oku.alarm1.Value < 10 && oku.alarm2.Value < 10)
                {
                    gir[tikla].Text = "0" + oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                }
                else if (oku.alarm1.Value >= 10 && oku.alarm2.Value < 10)
                {
                    gir[tikla].Text = oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                }
                else if (oku.alarm1.Value < 10 && oku.alarm2.Value >= 10)
                {
                    gir[tikla].Text = "0" + oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                }
                else
                {
                    gir[tikla].Text = oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                }
                gir[tikla].Location = new Point(23, 45);
            gir[tikla].Size = new Size(100, 39);
            gir[tikla].Name = "lbl" + Convert.ToString(sayi);
               
                labeller.Add(gir[tikla]);
            deneme[tikla].Controls.Add(gir[tikla]);*/

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
            deneme[tikla].Controls.Add(yap[tikla]);
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
                    /*   CheckBox[] alarm = new CheckBox[alarmsay + 1];

                     alarm[alarmsay] = new CheckBox();
                     alarm[alarmsay].Font = new Font("Microsoft Sans Serif", 10);
                     alarm[alarmsay].ForeColor = Color.Black;
                     alarm[alarmsay].UseVisualStyleBackColor = true;
                     alarm[alarmsay].Text = dsyadi[alarmsay];
                     alarm[alarmsay].Location = new Point(23, 84);
                     alarm[alarmsay].Size = new Size(350, 21);
                     alarm[alarmsay].Name = "chckalarm" + Convert.ToString(sayi);*/
                    chckkntrl[tikla].Text = dsyadi[tikla].ToString();
                    chckkntrl[tikla].Name = "chckalarm" + Convert.ToString(sayi);

                    

               Label[] alrmlbl = new Label[alarmsay + 1];

                    alrmlbl[alarmsay] = new Label();
                    alrmlbl[alarmsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    alrmlbl[alarmsay].ForeColor = Color.Black;
                    if (oku.alarm1.Value < 10 && oku.alarm2.Value < 10)
                    {
                        alrmlbl[alarmsay].Text = "0" + oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value >= 10 && oku.alarm2.Value < 10)
                    {
                        alrmlbl[alarmsay].Text = oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value < 10 && oku.alarm2.Value >= 10)
                    {
                        alrmlbl[alarmsay].Text = "0" + oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else
                    {
                        alrmlbl[alarmsay].Text = oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    alrmlbl[alarmsay].Location = new Point(23, 45);
                    alrmlbl[alarmsay].Size = new Size(100, 39);
                    alrmlbl[alarmsay].Name = "alrmlbl" + Convert.ToString(sayi);

                    alrmlabeller.Add(alrmlbl[alarmsay]);
                    deneme[tikla].Controls.Add(alrmlabeller[alarmsay]);

                    alarmsay += 1;
                   
                  
                }
                else if (chckhatirlat == 1)
                {
                   chckhatirlat = 0;

                    /*  CheckBox[] htrchck = new CheckBox[htrlsay + 1];

                              htrchck[htrlsay] = new CheckBox();
                              htrchck[htrlsay].Font = new Font("Microsoft Sans Serif", 10);
                              htrchck[htrlsay].ForeColor = Color.Black;
                              htrchck[htrlsay].UseVisualStyleBackColor = true;
                              htrchck[htrlsay].Text = "Hatırlat";
                              htrchck[htrlsay].Location = new Point(23, 84);
                              htrchck[htrlsay].Size = new Size(350, 21);
                              htrchck[htrlsay].Name = "chckhtrl" + Convert.ToString(sayi);

                              htrlbox.Add(htrchck[htrlsay]);
                              deneme[tikla].Controls.Add(htrlbox[htrlsay]);*/
                    chckkntrl[tikla].Text = "Hatırlat";
                    chckkntrl[tikla].Name = "chckhtrl" + Convert.ToString(sayi);

                    Label[] htrlbl = new Label[htrlsay + 1];

                    htrlbl[htrlsay] = new Label();
                    htrlbl[htrlsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    htrlbl[htrlsay].ForeColor = Color.Black;
                    if (oku.alarm1.Value < 10 && oku.alarm2.Value < 10)
                    {
                        htrlbl[htrlsay].Text = "0" + oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value >= 10 && oku.alarm2.Value < 10)
                    {
                        htrlbl[htrlsay].Text = oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value < 10 && oku.alarm2.Value >= 10)
                    {
                        htrlbl[htrlsay].Text = "0" + oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else
                    {
                        htrlbl[htrlsay].Text = oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    htrlbl[htrlsay].Location = new Point(23, 45);
                    htrlbl[htrlsay].Size = new Size(100, 39);
                    htrlbl[htrlsay].Name = "htrlbl" + Convert.ToString(sayi);

                    htrllabeller.Add(htrlbl[htrlsay]);
                    deneme[tikla].Controls.Add(htrllabeller[htrlsay]);

                    htrlsay += 1;


                }
                else if (chcksec==1)
                {
                    chcksec = 0;

                    /*  CheckBox[] calistir = new CheckBox[prgsay + 1];

                       calistir[prgsay] = new CheckBox();
                       calistir[prgsay].Font = new Font("Microsoft Sans Serif", 10);
                       calistir[prgsay].ForeColor = Color.Black;
                       calistir[prgsay].UseVisualStyleBackColor = true;
                       calistir[prgsay].Text = prgmsec[prgsay];
                       calistir[prgsay].Location = new Point(23, 84);
                       calistir[prgsay].Size = new Size(350, 21);
                       calistir[prgsay].Name = "chckprgsay" + Convert.ToString(sayi);

                              programlar.Add(calistir[prgsay]);
                               deneme[tikla].Controls.Add(calistir[prgsay]);*/
                    chckkntrl[tikla].Text = prgmsec[prgsay];
                    chckkntrl[tikla].Name = "chckprgsay" + Convert.ToString(sayi);

                    Label[] prgmlbl = new Label[prgsay + 1];

                    prgmlbl[prgsay] = new Label();
                    prgmlbl[prgsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    prgmlbl[prgsay].ForeColor = Color.Black;
                    if (oku.alarm1.Value < 10 && oku.alarm2.Value < 10)
                    {
                        prgmlbl[prgsay].Text = "0" + oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value >= 10 && oku.alarm2.Value < 10)
                    {
                        prgmlbl[prgsay].Text = oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value < 10 && oku.alarm2.Value >= 10)
                    {
                        prgmlbl[prgsay].Text = "0" + oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else
                    {
                        prgmlbl[prgsay].Text = oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    prgmlbl[prgsay].Location = new Point(23, 45);
                    prgmlbl[prgsay].Size = new Size(100, 39);
                    prgmlbl[prgsay].Name = "prgmlbl" + Convert.ToString(sayi);

                    prgmlabeller.Add(prgmlbl[prgsay]);
                    deneme[tikla].Controls.Add(prgmlabeller[prgsay]);

                    prgsay += 1;
                }
                 else if (chckbilgkapat==1)
                 {
                    chckbilgkapat = 0;
                    /*  CheckBox[] kptchck = new CheckBox[kptsay + 1];

                              kptchck[kptsay] = new CheckBox();
                              kptchck[kptsay].Font = new Font("Microsoft Sans Serif", 10);
                              kptchck[kptsay].ForeColor = Color.Black;
                              kptchck[kptsay].UseVisualStyleBackColor = true;
                              kptchck[kptsay].Text = "Bilgisayarı Kapat";
                              kptchck[kptsay].Location = new Point(23, 84);
                              kptchck[kptsay].Size = new Size(350, 21);
                              kptchck[kptsay].Name = "kptchck" + Convert.ToString(sayi);

                              kptbox.Add(kptchck[kptsay]);
                              deneme[tikla].Controls.Add(kptbox[kptsay]);*/
                    chckkntrl[tikla].Text = "Bilgisayarı Kapat";
                    chckkntrl[tikla].Name = "kptchck" + Convert.ToString(sayi);

                    Label[] kptlbl = new Label[kptsay + 1];

                    kptlbl[kptsay] = new Label();
                    kptlbl[kptsay].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    kptlbl[kptsay].ForeColor = Color.Black;
                    if (oku.alarm1.Value < 10 && oku.alarm2.Value < 10)
                    {
                        kptlbl[kptsay].Text = "0" + oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value >= 10 && oku.alarm2.Value < 10)
                    {
                        kptlbl[kptsay].Text = oku.alarm1.Value.ToString() + ":0" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else if (oku.alarm1.Value < 10 && oku.alarm2.Value >= 10)
                    {
                        kptlbl[kptsay].Text = "0" + oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    else
                    {
                        kptlbl[kptsay].Text = oku.alarm1.Value.ToString() + ":" + oku.alarm2.Value.ToString() + ":00";
                    }
                    kptlbl[kptsay].Location = new Point(23, 45);
                    kptlbl[kptsay].Size = new Size(100, 39);
                    kptlbl[kptsay].Name = "kptlbl" + Convert.ToString(sayi);

                    kptlabeller.Add(kptlbl[kptsay]);
                    deneme[tikla].Controls.Add(kptlabeller[kptsay]);

                    kptsay += 1;

                }
                else
                {
                  /*  kutu[tikla] = new CheckBox();
                    kutu[tikla].Font = new Font("Microsoft Sans Serif", 10);
                    kutu[tikla].ForeColor = Color.Black;
                    kutu[tikla].UseVisualStyleBackColor = true;
                    kutu[tikla].Text = "Boş Alarm";
                    kutu[tikla].Location = new Point(23, 84);
                    kutu[tikla].Size = new Size(350, 21);
                    kutu[tikla].Name = "chck" + Convert.ToString(sayi);
                    kutular.Add(kutu[tikla]);
                    deneme[tikla].Controls.Add(kutu[tikla]);*/
                }


                alarmlar.Add(chckkntrl[tikla]);
                deneme[tikla].Controls.Add(alarmlar[tikla]);

                //Alarm Kuralım 



                tikla = tikla+1;


            }
            checkBox1.Checked = false;


        }
      
       
        public void yap_Click(object sender, EventArgs e)
        {

            Button tiklanan = (sender as Button);
            
            int index2 = butonlar.IndexOf(tiklanan);
            checkBox3.Text = index2.ToString();
           if (alarmlar[index2].Name== "chckalarm" + Convert.ToString(index2+1))
            {
               
              
                alarmlar[index2].Dispose();
                dsyadi.Remove(dsyadi.IndexOfKey(index2));
               

            }

            denemeler[index2].Dispose();
           // sayi = sayi - 1;
        
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          


        }
    }
}
