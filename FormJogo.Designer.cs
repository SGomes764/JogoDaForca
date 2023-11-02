namespace JogoDaForca
{
    partial class FormJogo
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
            this.label_TEMA = new System.Windows.Forms.Label();
            this.button1_ADIVINHAR = new System.Windows.Forms.Button();
            this.txtAdivinhar = new System.Windows.Forms.TextBox();
            this.lblPalavraAdivinhada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TEMA
            // 
            this.label_TEMA.AutoSize = true;
            this.label_TEMA.BackColor = System.Drawing.Color.Transparent;
            this.label_TEMA.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TEMA.Location = new System.Drawing.Point(57, 38);
            this.label_TEMA.Name = "label_TEMA";
            this.label_TEMA.Size = new System.Drawing.Size(135, 51);
            this.label_TEMA.TabIndex = 0;
            this.label_TEMA.Text = "Tema:";
            this.label_TEMA.Click += new System.EventHandler(this.label_GOOD_LUCK_Click);
            // 
            // button1_ADIVINHAR
            // 
            this.button1_ADIVINHAR.AutoSize = true;
            this.button1_ADIVINHAR.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_ADIVINHAR.Location = new System.Drawing.Point(661, 347);
            this.button1_ADIVINHAR.Name = "button1_ADIVINHAR";
            this.button1_ADIVINHAR.Size = new System.Drawing.Size(157, 50);
            this.button1_ADIVINHAR.TabIndex = 1;
            this.button1_ADIVINHAR.Text = "Adivinhar";
            this.button1_ADIVINHAR.UseVisualStyleBackColor = true;
            this.button1_ADIVINHAR.Click += new System.EventHandler(this.button1_ADIVINHAR_Click);
            // 
            // txtAdivinhar
            // 
            this.txtAdivinhar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdivinhar.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdivinhar.Location = new System.Drawing.Point(475, 349);
            this.txtAdivinhar.Name = "txtAdivinhar";
            this.txtAdivinhar.Size = new System.Drawing.Size(180, 48);
            this.txtAdivinhar.TabIndex = 2;
            this.txtAdivinhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPalavraAdivinhada
            // 
            this.lblPalavraAdivinhada.AutoSize = true;
            this.lblPalavraAdivinhada.BackColor = System.Drawing.Color.Transparent;
            this.lblPalavraAdivinhada.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraAdivinhada.Location = new System.Drawing.Point(524, 261);
            this.lblPalavraAdivinhada.Name = "lblPalavraAdivinhada";
            this.lblPalavraAdivinhada.Size = new System.Drawing.Size(113, 45);
            this.lblPalavraAdivinhada.TabIndex = 3;
            this.lblPalavraAdivinhada.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 40;
            this.listBox1.Location = new System.Drawing.Point(790, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 244);
            this.listBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoDaForca.Properties.Resources.forca;
            this.pictureBox1.Location = new System.Drawing.Point(53, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaForca.Properties.Resources.papel_amassado;
            this.ClientSize = new System.Drawing.Size(1076, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPalavraAdivinhada);
            this.Controls.Add(this.txtAdivinhar);
            this.Controls.Add(this.button1_ADIVINHAR);
            this.Controls.Add(this.label_TEMA);
            this.Name = "FormJogo";
            this.Text = "Jogo da forca - Jogo";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TEMA;
        private System.Windows.Forms.Button button1_ADIVINHAR;
        private System.Windows.Forms.TextBox txtAdivinhar;
        private System.Windows.Forms.Label lblPalavraAdivinhada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}