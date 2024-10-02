namespace Esercizio_form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Spegni = new Button();
            Accendi = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Alza = new Button();
            Abbassa = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Spegni
            // 
            Spegni.Font = new Font("Segoe UI", 15F);
            Spegni.Location = new Point(114, 222);
            Spegni.Name = "Spegni";
            Spegni.Size = new Size(120, 77);
            Spegni.TabIndex = 1;
            Spegni.Text = "SPEGNI";
            Spegni.UseVisualStyleBackColor = true;
            Spegni.Click += Spegni_Click;
            // 
            // Accendi
            // 
            Accendi.Font = new Font("Segoe UI", 15F);
            Accendi.Location = new Point(114, 95);
            Accendi.Name = "Accendi";
            Accendi.Size = new Size(120, 77);
            Accendi.TabIndex = 2;
            Accendi.Text = "ACCENDI";
            Accendi.UseVisualStyleBackColor = true;
            Accendi.Click += Accendi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.accesa;
            pictureBox1.Location = new Point(593, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 150);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.spenta1;
            pictureBox2.Location = new Point(593, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 150);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Alza
            // 
            Alza.Font = new Font("Segoe UI", 15F);
            Alza.Location = new Point(342, 95);
            Alza.Name = "Alza";
            Alza.Size = new Size(120, 77);
            Alza.TabIndex = 6;
            Alza.Text = "ALZA";
            Alza.UseVisualStyleBackColor = true;
            Alza.Click += Alza_Click;
            // 
            // Abbassa
            // 
            Abbassa.Font = new Font("Segoe UI", 15F);
            Abbassa.Location = new Point(342, 222);
            Abbassa.Name = "Abbassa";
            Abbassa.Size = new Size(120, 77);
            Abbassa.TabIndex = 7;
            Abbassa.Text = "ABBASSA";
            Abbassa.UseVisualStyleBackColor = true;
            Abbassa.Click += Abbassa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 461);
            Controls.Add(Abbassa);
            Controls.Add(Alza);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Accendi);
            Controls.Add(Spegni);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Spegni;
        private Button Accendi;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Alza;
        private Button Abbassa;
    }
}
