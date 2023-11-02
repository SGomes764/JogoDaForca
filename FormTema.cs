using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class FormTema : Form
    {
        public FormTema()
        {
            InitializeComponent();
        }

        private void button_TEMA_SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_INICIAR_JOGO_Click(object sender, EventArgs e)
        {
            string temaEscolhido = comboBox_TEMAS.SelectedItem.ToString();
            FormJogo formJogo = new FormJogo(temaEscolhido);
            this.Hide();
            formJogo.ShowDialog();
            this.Close();
        }
    }
}
