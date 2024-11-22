using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Media;

namespace TCC
{
    public partial class Tutorial : Form
    {
        //Declaração de variáveis 
        int contador = 1;
        int contador_2 = 1;
        int Velocidade = 5;
        string diretorio = Directory.GetCurrentDirectory();
        int escolha = 0;
        int Quadro= 0;
        int indice_arquivo_NinoPixel = 2;
        string tipo_de_escolha = "";
        string linha = "";
        DataBaseManager gerenciador;


        public Tutorial()
        {
            InitializeComponent();

            gerenciador = new DataBaseManager("Banco de Dados");

            string diretorio_Audio = $@"{diretorio}\Sons Do Jogo\Som Tutorial.wav";

            SoundPlayer som = new SoundPlayer(diretorio_Audio);

            som.Load();
            som.PlayLooping();

            InicializarConversa();
        }

        private void InicializarConversa()
        {
            DataTable tabela = gerenciador.ConsultarBanco($"SELECT * FROM Dialogo WHERE Quadro = {Quadro}");
            linha = tabela.Rows[0]["Falas"].ToString();

            Texto_Dialogo.Text = linha;

            Quadro++;
        }
                
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            //Parte de troca de png do personagem.
            if (indice_arquivo_NinoPixel < 9)
            {
                NPC_Nino.ImageLocation = $@"{diretorio}\Imagens\Nino pixels\{indice_arquivo_NinoPixel}.png";

                indice_arquivo_NinoPixel++;

            }
            else
            {
                indice_arquivo_NinoPixel = 1;

                NPC_Nino.ImageLocation = $@"{diretorio}\Imagens\Nino pixels\{indice_arquivo_NinoPixel}.png";

                indice_arquivo_NinoPixel++;
            }

            //Parte do programa de movimentação do personagem.
            if (contador % 2 != 0)
            {

                int x = NPC_Nino.Location.X + Velocidade;
                int y = NPC_Nino.Location.Y;

                NPC_Nino.Location = new Point(x, y);

                contador++;

            }
            else
            {
                int x = NPC_Nino.Location.X - Velocidade;
                int y = NPC_Nino.Location.Y;

                NPC_Nino.Location = new Point(x, y);

                contador++;
            }

        }


        private void Botao_Next_Click(object sender, EventArgs e)
        {

            DataTable tabela = gerenciador.ConsultarBanco($"SELECT * FROM Dialogo WHERE Quadro = {Quadro}");

            if(Quadro != 8 && Quadro != 9)
            { 

            linha = tabela.Rows[0]["Falas"].ToString();

            Texto_Dialogo.Text = linha;

            Texto_Dialogo.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);
            }

            if (Quadro == 2 )
            {
                Botao_Resposta_1.Visible = true;
                Botao_Resposta_2.Visible = true;
                Botao_Resposta_3.Visible = true;
                Botao_Resposta_4.Visible = true;
            }
            else if (Quadro == 6 )
            {
                Personagem_1.Visible = true;
                Personagem_2.Visible = true;
            }
            if(Quadro == 8)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\npc_fala.jpg";
                Texto_Dialogo.Text = linha = tabela.Rows[0]["Falas"].ToString();
                Nome_Falante.Text = "Samara";
            }
            if(Quadro == 9)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Jogador_fala.jpg";
                Texto_Dialogo.Text = linha = tabela.Rows[0]["Falas"].ToString();
                Nome_Falante.Text = "Radulf";
            }
            if (Quadro == 10)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\imagem_nino_fala.png";

                linha = tabela.Rows[0]["Falas"].ToString();

                // DataTable alternativas = gerenciador.ConsultarBanco($"SELECT * FROM Alternativa WHERE Id_Falas = {Quadro}");
                // linha = tabela.Rows[indice_inicial]["Falas"].ToString();

                Texto_Dialogo.Text = linha;

                Texto_Dialogo.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);

                Nome_Falante.Text = "Radulf";

                Botao_Resposta_1.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);
                Botao_Resposta_2.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);
                Botao_Resposta_3.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);
                Botao_Resposta_4.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);
            }

            Quadro++;
        }
        private void Botao_Escolha_1_Click(object sender, EventArgs e)
        {
            escolha = 1;
            tipo_de_escolha = "boa";
        }

        private void Botao_Escolha_2_Click(object sender, EventArgs e)
        {
            escolha = 2;
            tipo_de_escolha = "neutra";
        }

        private void Botao_Escolha_3_Click(object sender, EventArgs e)
        {
            escolha = 3;
            tipo_de_escolha = "ruim-1";
        }

        private void Botao_Escolha_4_Click(object sender, EventArgs e)
        {
            escolha = 4;
            tipo_de_escolha = "ruim-2";
        }

        private void Casa_Do_Cachorro_Click(object sender, EventArgs e)
        {

        }
    }
}
