using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class FormJogo : Form
    {
        private string palavraEscolhida;
        private string palavraAdivinhada;
        private int tentativasRestantes;

        public FormJogo(string tema)
        {
            InitializeComponent();
            int numeroLetras = IniciarJogo(tema);
            InicializarInterface(numeroLetras);
        }
        private int IniciarJogo(string tema)
        {
            // lista de palavras dos temas
            Dictionary<string, List<string>> temas = new Dictionary<string, List<string>>
            {
                { "Frutas", new List<string> { "banana", "tangerina", "laranja", "uva" } },
                { "Animais", new List<string> { "gato", "lagarto", "elefante", "caracol" } },
                { "Cores", new List<string> { "vermelho", "azul", "amarelo", "verde" } }
            };

            // escolher uma palavra aleatoria do tema escolhido
            if (temas.ContainsKey(tema))
            {
                List<string> palavrasDoTema = temas[tema];
                Random random = new Random();
                int indicePalavra = random.Next(palavrasDoTema.Count);
                palavraEscolhida = palavrasDoTema[indicePalavra];

                label_TEMA.Text = "";
                label_TEMA.Text = "Tema: " + tema;
                label1.Text = "Tentativas: 6";
                int numeroLetras = palavraEscolhida.Length;
                return numeroLetras;
            }
            else
            {
                // caso o tema não seja encontrado
                MessageBox.Show("Tema não encontrado. Escolha um tema válido.");
                this.Close(); // fecha o formulário do jogo
                return 0;
            }
        }
        private void InicializarInterface(int numeroLetras)
        {
            // inicializa a palavra adivinhada com traços
            palavraAdivinhada = new string('-', palavraEscolhida.Length);
            lblPalavraAdivinhada.Text = new string('-', palavraEscolhida.Length);
            tentativasRestantes = 6; // define o numero desejado de tentativas
            AtualizarInterface();

        }
        private void AdivinharLetra(char letra)
        {
            //gica para adivinhar a letra, atualizar palavraAdivinhada e verificar o resultado.

            AtualizarInterface();
            VerificarFimDoJogo();
        }
        private void AtualizarInterface()
        {
            // atualiza a interface para mostrar a palavra a ser adivinhada, letras adivinhadas, imagem da forca, etc.
        }
        private void VerificarFimDoJogo()
        {
            //verificar se o jogo terminou
            if (palavraAdivinhada == palavraEscolhida)
            {
                //vitoria
                MessageBox.Show("Parabéns, conseguistes escapar da forca! A palavra era: " + palavraEscolhida);
                Application.Exit();
            }
            else if (tentativasRestantes == 0)
            {
                //derrota
                MessageBox.Show("Morreste enforcado! A palavra era: " + palavraEscolhida);
                Application.Exit();
            }
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

        }

        private void button1_ADIVINHAR_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdivinhar.Text) && txtAdivinhar.Text.Length == 1)
            {
                char letra = txtAdivinhar.Text[0];

                if (palavraEscolhida.Contains(letra))
                {
                    palavraAdivinhada = AtualizarPalavraAdivinhada(palavraEscolhida, palavraAdivinhada, letra);
                    lblPalavraAdivinhada.Text = palavraAdivinhada;
                }
                else
                {
                    listBox1.Items.Add(letra);
                    tentativasRestantes--;//reduz o numero de tentativas
                    //atualiza o texto da Label com o numero de tentativas restantes
                    label1.Text = "Tentativas: " + tentativasRestantes;
                    

                    //mete o pictureBox visivel
                    PictureBoxTentativas();
                }
                
                txtAdivinhar.Clear();
                AtualizarInterface();//atualiza a interface, como imagem da forca, letras restantes, etc.
                VerificarFimDoJogo();
            }
        }
        private void PictureBoxTentativas()
        {
            // Suponha que o PictureBox se chame pictureBoxTentativas.
            // Você pode criar um nome de arquivo de imagem com base no número de tentativas restantes.
            int numeroTentativas = tentativasRestantes; // Obtém o número atual de tentativas.
            string imagens = $"tentativas_{numeroTentativas}.png";

            // Verifique se o arquivo de imagem existe antes de atribuí-lo ao PictureBox.
            if (File.Exists(imagens))
            {
                pictureBox1.Image = Image.FromFile(imagens);
            }
            else
            {
                // Se a imagem não existir, você pode carregar uma imagem padrão ou exibir uma mensagem de erro.
                pictureBox1.Image = Image.FromFile("forca.png");
            }
        }

        private string AtualizarPalavraAdivinhada(string palavra, string palavraAdivinhada, char letra)
        {
            char[] palavraAdivinhadaArray = palavraAdivinhada.ToCharArray();

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    palavraAdivinhadaArray[i] = letra;
                }
            }

            return new string(palavraAdivinhadaArray);
        }


        private void label_GOOD_LUCK_Click(object sender, EventArgs e)
        {

        }

        private void txtAdivinhar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTema_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}