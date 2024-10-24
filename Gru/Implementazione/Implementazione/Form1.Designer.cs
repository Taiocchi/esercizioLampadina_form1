namespace Implementazione
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
            Alza = new Button();
            Abbassa = new Button();
            RESET = new Button();
            label1 = new Label();
            label2 = new Label();
            Applica = new Button();
            Altezza_Minima = new TextBox();
            Altezza_Massima = new TextBox();
            Braccio = new PictureBox();
            Gancio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Braccio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gancio).BeginInit();
            SuspendLayout();
            // 
            // Alza
            // 
            Alza.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Alza.Location = new Point(48, 414);
            Alza.Name = "Alza";
            Alza.Size = new Size(131, 61);
            Alza.TabIndex = 0;
            Alza.Text = "Alza";
            Alza.UseVisualStyleBackColor = true;
            Alza.Click += Alza_Click;
            // 
            // Abbassa
            // 
            Abbassa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Abbassa.Location = new Point(48, 500);
            Abbassa.Name = "Abbassa";
            Abbassa.Size = new Size(131, 62);
            Abbassa.TabIndex = 1;
            Abbassa.Text = "Abbassa";
            Abbassa.UseVisualStyleBackColor = true;
            Abbassa.Click += Abbassa_Click;
            // 
            // RESET
            // 
            RESET.Location = new Point(204, 470);
            RESET.Name = "RESET";
            RESET.Size = new Size(75, 23);
            RESET.TabIndex = 2;
            RESET.Text = "RESET";
            RESET.UseVisualStyleBackColor = true;
            RESET.Click += RESET_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 43);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 3;
            label1.Text = "Altezza_Minima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 153);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 4;
            label2.Text = "Altezza_Massima";
            // 
            // Applica
            // 
            Applica.Location = new Point(242, 130);
            Applica.Name = "Applica";
            Applica.Size = new Size(75, 23);
            Applica.TabIndex = 5;
            Applica.Text = "APPLICA";
            Applica.UseVisualStyleBackColor = true;
            Applica.Click += Applica_Click;
            // 
            // Altezza_Minima
            // 
            Altezza_Minima.Location = new Point(48, 76);
            Altezza_Minima.Name = "Altezza_Minima";
            Altezza_Minima.Size = new Size(160, 23);
            Altezza_Minima.TabIndex = 6;
            // 
            // Altezza_Massima
            // 
            Altezza_Massima.Location = new Point(48, 186);
            Altezza_Massima.Name = "Altezza_Massima";
            Altezza_Massima.Size = new Size(172, 23);
            Altezza_Massima.TabIndex = 7;
            // 
            // Braccio
            // 
            Braccio.Image = Properties.Resources.images;
            Braccio.Location = new Point(711, 105);
            Braccio.Name = "Braccio";
            Braccio.Size = new Size(371, 388);
            Braccio.TabIndex = 8;
            Braccio.TabStop = false;
            // 
            // Gancio
            // 
            Gancio.Image = Properties.Resources.image_2;
            Gancio.Location = new Point(952, 170);
            Gancio.Name = "Gancio";
            Gancio.Size = new Size(100, 50);
            Gancio.TabIndex = 9;
            Gancio.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(Gancio);
            Controls.Add(Braccio);
            Controls.Add(Altezza_Massima);
            Controls.Add(Altezza_Minima);
            Controls.Add(Applica);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RESET);
            Controls.Add(Abbassa);
            Controls.Add(Alza);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Braccio).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gancio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Alza;
        private Button Abbassa;
        private Button RESET;
        private Label label1;
        private Label label2;
        private Button Applica;
        private TextBox Altezza_Minima;
        private TextBox Altezza_Massima;
        private PictureBox Braccio;
        private PictureBox Gancio;
    }
}
