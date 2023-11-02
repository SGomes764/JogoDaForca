namespace JogoDaForca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_TITULO = new System.Windows.Forms.Label();
            this.button_JOGAR = new System.Windows.Forms.Button();
            this.button_SAIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_TITULO
            // 
            this.label1_TITULO.AutoSize = true;
            this.label1_TITULO.BackColor = System.Drawing.Color.Transparent;
            this.label1_TITULO.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_TITULO.Location = new System.Drawing.Point(307, 25);
            this.label1_TITULO.Name = "label1_TITULO";
            this.label1_TITULO.Size = new System.Drawing.Size(480, 90);
            this.label1_TITULO.TabIndex = 0;
            this.label1_TITULO.Text = "Jogo da forca";
            this.label1_TITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_JOGAR
            // 
            this.button_JOGAR.AutoSize = true;
            this.button_JOGAR.BackColor = System.Drawing.Color.Transparent;
            this.button_JOGAR.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_JOGAR.Location = new System.Drawing.Point(860, 116);
            this.button_JOGAR.Name = "button_JOGAR";
            this.button_JOGAR.Size = new System.Drawing.Size(171, 77);
            this.button_JOGAR.TabIndex = 1;
            this.button_JOGAR.Text = "Jogar";
            this.button_JOGAR.UseVisualStyleBackColor = false;
            this.button_JOGAR.Click += new System.EventHandler(this.button_JOGAR_Click);
            // 
            // button_SAIR
            // 
            this.button_SAIR.AutoSize = true;
            this.button_SAIR.BackColor = System.Drawing.Color.Transparent;
            this.button_SAIR.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SAIR.Location = new System.Drawing.Point(860, 243);
            this.button_SAIR.Name = "button_SAIR";
            this.button_SAIR.Size = new System.Drawing.Size(171, 77);
            this.button_SAIR.TabIndex = 2;
            this.button_SAIR.Text = "Sair";
            this.button_SAIR.UseVisualStyleBackColor = false;
            this.button_SAIR.Click += new System.EventHandler(this.button_SAIR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JogoDaForca.Properties.Resources.homem_enforcado;
            this.pictureBox1.Location = new System.Drawing.Point(194, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaForca.Properties.Resources.papel_amassado;
            this.ClientSize = new System.Drawing.Size(1076, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SAIR);
            this.Controls.Add(this.button_JOGAR);
            this.Controls.Add(this.label1_TITULO);
            this.Name = "Form1";
            this.Text = "Jogo da forca - Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_TITULO;
        private System.Windows.Forms.Button button_JOGAR;
        private System.Windows.Forms.Button button_SAIR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

