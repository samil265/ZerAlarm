namespace Zamanlayici
{
    partial class Form3
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
            this.dosyayol = new System.Windows.Forms.TextBox();
            this.btnyol = new System.Windows.Forms.Button();
            this.lblislem = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dosyayol
            // 
            this.dosyayol.Location = new System.Drawing.Point(12, 44);
            this.dosyayol.Name = "dosyayol";
            this.dosyayol.Size = new System.Drawing.Size(221, 20);
            this.dosyayol.TabIndex = 0;
            // 
            // btnyol
            // 
            this.btnyol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyol.Location = new System.Drawing.Point(239, 42);
            this.btnyol.Name = "btnyol";
            this.btnyol.Size = new System.Drawing.Size(41, 23);
            this.btnyol.TabIndex = 1;
            this.btnyol.Text = "...";
            this.btnyol.UseVisualStyleBackColor = true;
            this.btnyol.Click += new System.EventHandler(this.btnyol_Click);
            // 
            // lblislem
            // 
            this.lblislem.AutoSize = true;
            this.lblislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblislem.Location = new System.Drawing.Point(12, 13);
            this.lblislem.Name = "lblislem";
            this.lblislem.Size = new System.Drawing.Size(124, 17);
            this.lblislem.TabIndex = 2;
            this.lblislem.Text = "Müzik Dosya Yolu:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(305, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 82);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblislem);
            this.Controls.Add(this.btnyol);
            this.Controls.Add(this.dosyayol);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnyol;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox dosyayol;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label lblislem;
    }
}