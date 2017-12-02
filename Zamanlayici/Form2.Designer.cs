namespace Zamanlayici
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hatirla = new System.Windows.Forms.TextBox();
            this.alarm = new System.Windows.Forms.CheckBox();
            this.hatirlat = new System.Windows.Forms.CheckBox();
            this.programac = new System.Windows.Forms.CheckBox();
            this.bilgkapat = new System.Windows.Forms.CheckBox();
            this.kur = new System.Windows.Forms.Button();
            this.alarm1 = new System.Windows.Forms.NumericUpDown();
            this.alarm2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.kur);
            this.groupBox1.Controls.Add(this.alarm1);
            this.groupBox1.Controls.Add(this.alarm2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 385);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm Kur";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.hatirla);
            this.groupBox2.Controls.Add(this.alarm);
            this.groupBox2.Controls.Add(this.hatirlat);
            this.groupBox2.Controls.Add(this.programac);
            this.groupBox2.Controls.Add(this.bilgkapat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(20, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçenekler";
            // 
            // hatirla
            // 
            this.hatirla.Location = new System.Drawing.Point(133, 73);
            this.hatirla.Name = "hatirla";
            this.hatirla.Size = new System.Drawing.Size(336, 30);
            this.hatirla.TabIndex = 10;
            this.hatirla.TextChanged += new System.EventHandler(this.hatirla_TextChanged);
            // 
            // alarm
            // 
            this.alarm.AutoSize = true;
            this.alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarm.Location = new System.Drawing.Point(6, 34);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(94, 33);
            this.alarm.TabIndex = 9;
            this.alarm.Text = "Alarm";
            this.alarm.UseVisualStyleBackColor = true;
            this.alarm.CheckedChanged += new System.EventHandler(this.alarm_CheckedChanged);
            // 
            // hatirlat
            // 
            this.hatirlat.AutoSize = true;
            this.hatirlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatirlat.Location = new System.Drawing.Point(6, 71);
            this.hatirlat.Name = "hatirlat";
            this.hatirlat.Size = new System.Drawing.Size(107, 33);
            this.hatirlat.TabIndex = 8;
            this.hatirlat.Text = "Hatırlat";
            this.hatirlat.UseVisualStyleBackColor = true;
            this.hatirlat.CheckedChanged += new System.EventHandler(this.hatirlat_CheckedChanged);
            // 
            // programac
            // 
            this.programac.AutoSize = true;
            this.programac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programac.Location = new System.Drawing.Point(6, 110);
            this.programac.Name = "programac";
            this.programac.Size = new System.Drawing.Size(230, 33);
            this.programac.TabIndex = 7;
            this.programac.Text = "Seçili Programı Aç";
            this.programac.UseVisualStyleBackColor = true;
            this.programac.CheckedChanged += new System.EventHandler(this.programac_CheckedChanged);
            // 
            // bilgkapat
            // 
            this.bilgkapat.AutoSize = true;
            this.bilgkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgkapat.Location = new System.Drawing.Point(6, 149);
            this.bilgkapat.Name = "bilgkapat";
            this.bilgkapat.Size = new System.Drawing.Size(211, 33);
            this.bilgkapat.TabIndex = 6;
            this.bilgkapat.Text = "Bilgisayarı Kapat";
            this.bilgkapat.UseVisualStyleBackColor = true;
            this.bilgkapat.CheckedChanged += new System.EventHandler(this.bilgkapat_CheckedChanged);
            // 
            // kur
            // 
            this.kur.Location = new System.Drawing.Point(73, 316);
            this.kur.Name = "kur";
            this.kur.Size = new System.Drawing.Size(97, 37);
            this.kur.TabIndex = 7;
            this.kur.Text = "Kur";
            this.kur.UseVisualStyleBackColor = true;
            this.kur.Click += new System.EventHandler(this.kur_Click);
            // 
            // alarm1
            // 
            this.alarm1.BackColor = System.Drawing.Color.BurlyWood;
            this.alarm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarm1.ForeColor = System.Drawing.Color.Black;
            this.alarm1.Location = new System.Drawing.Point(86, 38);
            this.alarm1.Name = "alarm1";
            this.alarm1.Size = new System.Drawing.Size(88, 45);
            this.alarm1.TabIndex = 0;
            this.alarm1.TabStop = false;
            this.alarm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarm2
            // 
            this.alarm2.BackColor = System.Drawing.Color.BurlyWood;
            this.alarm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarm2.ForeColor = System.Drawing.Color.Black;
            this.alarm2.Location = new System.Drawing.Point(194, 38);
            this.alarm2.Name = "alarm2";
            this.alarm2.Size = new System.Drawing.Size(88, 45);
            this.alarm2.TabIndex = 3;
            this.alarm2.TabStop = false;
            this.alarm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.NumericUpDown alarm1;
        public System.Windows.Forms.NumericUpDown alarm2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox bilgkapat;
        public System.Windows.Forms.Button kur;
        public System.Windows.Forms.CheckBox alarm;
        public System.Windows.Forms.CheckBox hatirlat;
        public System.Windows.Forms.CheckBox programac;
        public System.Windows.Forms.TextBox hatirla;
    }
}