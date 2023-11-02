namespace JogoDaForca
{
    partial class FormTema
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TEMAS = new System.Windows.Forms.ComboBox();
            this.button_INICIAR_JOGO = new System.Windows.Forms.Button();
            this.button_TEMA_SAIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o tema da rodada:";
            // 
            // comboBox_TEMAS
            // 
            this.comboBox_TEMAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TEMAS.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TEMAS.FormattingEnabled = true;
            this.comboBox_TEMAS.Items.AddRange(new object[] {
            "Animais",
            "Cores",
            "Frutas"});
            this.comboBox_TEMAS.Location = new System.Drawing.Point(675, 42);
            this.comboBox_TEMAS.Name = "comboBox_TEMAS";
            this.comboBox_TEMAS.Size = new System.Drawing.Size(297, 48);
            this.comboBox_TEMAS.Sorted = true;
            this.comboBox_TEMAS.TabIndex = 1;
            // 
            // button_INICIAR_JOGO
            // 
            this.button_INICIAR_JOGO.AutoSize = true;
            this.button_INICIAR_JOGO.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_INICIAR_JOGO.Location = new System.Drawing.Point(251, 244);
            this.button_INICIAR_JOGO.Name = "button_INICIAR_JOGO";
            this.button_INICIAR_JOGO.Size = new System.Drawing.Size(209, 55);
            this.button_INICIAR_JOGO.TabIndex = 2;
            this.button_INICIAR_JOGO.Text = "Iniciar jogo";
            this.button_INICIAR_JOGO.UseVisualStyleBackColor = true;
            this.button_INICIAR_JOGO.Click += new System.EventHandler(this.button_INICIAR_JOGO_Click);
            // 
            // button_TEMA_SAIR
            // 
            this.button_TEMA_SAIR.AutoSize = true;
            this.button_TEMA_SAIR.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TEMA_SAIR.Location = new System.Drawing.Point(541, 244);
            this.button_TEMA_SAIR.Name = "button_TEMA_SAIR";
            this.button_TEMA_SAIR.Size = new System.Drawing.Size(209, 55);
            this.button_TEMA_SAIR.TabIndex = 3;
            this.button_TEMA_SAIR.Text = "Sair";
            this.button_TEMA_SAIR.UseVisualStyleBackColor = true;
            this.button_TEMA_SAIR.Click += new System.EventHandler(this.button_TEMA_SAIR_Click);
            // 
            // FormTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaForca.Properties.Resources.papel_amassado;
            this.ClientSize = new System.Drawing.Size(1076, 506);
            this.Controls.Add(this.button_TEMA_SAIR);
            this.Controls.Add(this.button_INICIAR_JOGO);
            this.Controls.Add(this.comboBox_TEMAS);
            this.Controls.Add(this.label1);
            this.Name = "FormTema";
            this.Text = "Jogo da forca - Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TEMAS;
        private System.Windows.Forms.Button button_INICIAR_JOGO;
        private System.Windows.Forms.Button button_TEMA_SAIR;
    }
}