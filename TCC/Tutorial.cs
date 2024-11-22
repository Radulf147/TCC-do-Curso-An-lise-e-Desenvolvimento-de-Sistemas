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
        public int contador = 1;
        public int contador_2 = 1;
        public int Velocidade = 5;
        public string Texto = "";
        public string diretorio = Directory.GetCurrentDirectory();
        public int escolha = 0;
        public int Quadro = 0;
        public int indice_arquivo_NinoPixel = 2;
        public int tempo = 20;
        public string consulta = "";
        public string tipo_de_escolha_selecionada = "";
        public string linha = "";
        public string Nome_Usuario = "Raul";
        public string Nome_NPC = "Samara";
        DataBaseManager gerenciador;
        public  string[] tipos_de_escolha = new string[4] { "ruim-1", "ruim-2", "boa", "neutra" };
        public  int numero = 0;
        DataTable tabela;
        string diretorio_Audio;
        SoundPlayer som1;
        SoundPlayer som2;
        Random random = new Random();

        public Tutorial()
        {
            InitializeComponent();

            gerenciador = new DataBaseManager("Banco de Dados");

            som1 = new SoundPlayer($@"{diretorio}\Sons Do Jogo\Som Tutorial.wav");
            som1.LoadAsync();

            som2 = new SoundPlayer($@"{diretorio}\Sons Do Jogo\Som-latido.wav");
            som2.LoadAsync();

            InicializarConversa();
        }
        public void Visible_Cachorro(int dog)
        {
            if(dog == 1)
            { 
            label_cachorro1.Visible = true;
            label_cachorro2.Visible = true;
            label_cachorro3.Visible = true;
            pictureBox_Cachorro1.Visible = true;
            pictureBox_Cachorro2.Visible = true;
            pictureBox_Cachorro3.Visible = true;
            }
            else
            {
                label_cachorro1.Visible = false;
                label_cachorro2.Visible = false;
                label_cachorro3.Visible = false;
                pictureBox_Cachorro1.Visible = false;
                pictureBox_Cachorro2.Visible = false;
                pictureBox_Cachorro3.Visible = false;
            }
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            som1.PlayLooping();
        }


        public void BotaoBloquear(int i)
        {
            if(i == 0)
            { 
                Botao_Resposta_0.Enabled = true;
                Botao_Resposta_1.Enabled = true;
                Botao_Resposta_2.Enabled = true;
                Botao_Resposta_3.Enabled = true;
            }
            else
            {
                Botao_Resposta_0.Enabled = false;
                Botao_Resposta_1.Enabled = false;
                Botao_Resposta_2.Enabled = false;
                Botao_Resposta_3.Enabled = false;
            }
        }
        private void Proximo_Quadro()
        {
            if (Quadro == 23)
            {
                Tela_Principal.Tutorial = 1;
                this.Close();
                som1.Stop();
                
            }
            tabela = gerenciador.ConsultarBanco($"SELECT * FROM Dialogo WHERE Quadro = {Quadro} AND Capitulos = 'tutorial'");

            linha = tabela.Rows[0]["Falas"].ToString();

            Texto_Dialogo.Text = linha;

            Texto_Dialogo.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);

            Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\imagem_nino_fala.png";

            Nome_Falante.Text = "Nino";
            
            if(Quadro == 1)
            {
                som2.Play();
                som1.PlayLooping();
            }

            if (Quadro == 3)
            {
                Botao_Resposta_0.Visible = true;
                Botao_Resposta_1.Visible = true;
                Botao_Resposta_2.Visible = true;
                Botao_Resposta_3.Visible = true;

            }
            if (Quadro == 6)
            {
                Botao_Resposta_0.Visible = false;
                Botao_Resposta_1.Visible = false;
                Botao_Resposta_2.Visible = false;
                Botao_Resposta_3.Visible = false;
            }
            if (Quadro == 7)
            {
                Personagem_1.Visible = true;
                Personagem_2.Visible = true;
            }
            if (Quadro == 9)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\npc_fala.jpg";
                linha = tabela.Rows[0]["Falas"].ToString();
                Texto_Dialogo.Text = linha;
                Nome_Falante.Text = Nome_NPC;
            }
            if (Quadro == 10)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Jogador_fala.jpg";
                linha = tabela.Rows[0]["Falas"].ToString();
                Texto_Dialogo.Text = linha;
                Nome_Falante.Text = Nome_Usuario;
            }
            if (Quadro == 11)
            {
                Botao_Resposta_0.Visible = true;
                Botao_Resposta_1.Visible = true;
                Botao_Resposta_2.Visible = true;
                Botao_Resposta_3.Visible = true;

                linha = tabela.Rows[0]["Falas"].ToString();

                Texto_Dialogo.Text = linha;

                tabela = gerenciador.ConsultarBanco($"SELECT * FROM Alternativa WHERE Quadro_Alternativa = 11 AND Capitulo = 'tutorial' ");

                for (int i = 0; i < 4; i++)
                {
                    linha = tabela.Rows[i]["Texto"].ToString();

                    if (i == 0)
                    {
                        Botao_Resposta_0.Text = linha;
                    }
                    else if (i == 1)
                    {
                        Botao_Resposta_1.Text = linha;
                    }
                    else if (i == 2)
                    {
                        Botao_Resposta_2.Text = linha;
                    }
                    else
                    {
                        Botao_Resposta_3.Text = linha;
                    }
                }
                Relogio_Tempo_Resposta.Visible = true;
                Tempo_Resposta.Enabled = true;

            }
            if (Quadro == 12)
            {
                if (tipo_de_escolha_selecionada == "")
                {
                    
                    tipo_de_escolha_selecionada = tipos_de_escolha[random.Next(0,4)];
                }
                Botao_Resposta_0.Visible = false;
                Botao_Resposta_1.Visible = false;
                Botao_Resposta_2.Visible = false;
                Botao_Resposta_3.Visible = false;

                MudarImagemTipoEscolha(tipo_de_escolha_selecionada);

                Relogio_Tempo_Resposta.Visible = false;

                Tempo_Resposta.Enabled = false;


            }
            if (Quadro == 13)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Jogador_fala.jpg";

                Nome_Falante.Text = Nome_Usuario;

                tabela = gerenciador.ConsultarBanco($@"SELECT Texto FROM Alternativa WHERE Quadro_Alternativa = 11 AND Qualidade_Alternativa = '{tipo_de_escolha_selecionada}' AND Capitulo = 'tutorial'");

                linha = tabela.Rows[0]["Texto"].ToString();

                Texto_Dialogo.Text = linha;
            }
            if (Quadro == 14)
            {
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\npc_fala.jpg";

                Nome_Falante.Text = Nome_NPC;

                tabela = gerenciador.ConsultarBanco($@"SELECT Falas FROM Resposta_Alternativa WHERE Quadro_Resposta = 14 AND Qualidade_Resposta = '{tipo_de_escolha_selecionada}' AND Capitulo = 'tutorial'");

                linha = tabela.Rows[0]["Texto_Resposta"].ToString();

                Texto_Dialogo.Text = linha;

            }
            if (Quadro == 15)
            {
                tabela = gerenciador.ConsultarBanco($@"SELECT Falas FROM Resposta_Alternativa WHERE Quadro_Resposta = 15 AND Qualidade_Resposta = '{tipo_de_escolha_selecionada}' AND Capitulo = 'tutorial'");

                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\imagem_nino_fala.png";

                Nome_Falante.Text = "Nino";

                linha = tabela.Rows[0]["Texto_Resposta"].ToString();

                Texto_Dialogo.Text = linha;
            }
            if (Quadro == 16)
            {
                tabela = gerenciador.ConsultarBanco($@"SELECT Falas FROM Resposta_Alternativa WHERE Quadro_Resposta = 16 AND Qualidade_Resposta = '{tipo_de_escolha_selecionada}' AND Capitulo = 'tutorial'");

                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\imagem_nino_fala.png";

                Nome_Falante.Text = "Nino";

                linha = tabela.Rows[0]["Texto_Resposta"].ToString();

                Texto_Dialogo.Text = linha;
            }
            if(Quadro == 21)
            {
                Visible_Cachorro(1);
            }
            if(Quadro == 22)
            {
                Visible_Cachorro(0);
            }
            

            Quadro++;
        }
        private void BotaoSelecionado(int numb_botao)
        {
            Botao_Resposta_0.FlatAppearance.BorderSize = 0;
            Botao_Resposta_1.FlatAppearance.BorderSize = 0;
            Botao_Resposta_2.FlatAppearance.BorderSize = 0;
            Botao_Resposta_3.FlatAppearance.BorderSize = 0;

            if(numb_botao == 0)
            {
                Botao_Resposta_0.FlatAppearance.BorderSize = 2;
            }
            if (numb_botao == 1)
            {
                Botao_Resposta_1.FlatAppearance.BorderSize = 2;
            }
            if (numb_botao == 2)
            {
                Botao_Resposta_2.FlatAppearance.BorderSize = 2;
            }
            if (numb_botao == 3)
            {
                Botao_Resposta_3.FlatAppearance.BorderSize = 2;
            }
        }
        private void MudarImagemTipoEscolha(string tipo_escolha1)
        {
            if (tipo_escolha1 == "boa")
            {
                PictureBox_Qualidade_Resposta.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Decisão-boa.png";
            }
            if (tipo_escolha1 == "ruim-2" || tipo_escolha1 == "ruim-1")
            {
                PictureBox_Qualidade_Resposta.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Decisão-ruim.png";
            }
            if(tipo_escolha1 == "neu")
            {
                PictureBox_Qualidade_Resposta.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Decisão-neutra.png";
            }
        }
        private void InicializarConversa()
        {
            tabela = gerenciador.ConsultarBanco($"SELECT * FROM Dialogo WHERE Quadro = {Quadro} AND Capitulos = 'tutorial'");

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

            Proximo_Quadro();
        }
        
        private void Casa_Do_Cachorro_Click(object sender, EventArgs e)
        {

        }

        private void Botao_Resposta_0_Click(object sender, EventArgs e)
        {
            Texto = Botao_Resposta_0.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[2]; ;

            consulta = $@"INSERT INTO Alternativa_Escolhida(ID_Resposta, Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES (1,{Texto}, {Nome_Usuario}, {tipo_de_escolha_selecionada}, 'tutorial', {Quadro} )";

            DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

            atualizar.AtualizarBanco(consulta);

            BotaoSelecionado(0);
        }

        private void Botao_Resposta_1_Click(object sender, EventArgs e)
        {
            Texto = Botao_Resposta_1.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[0]; ;

            consulta = $@"INSERT INTO Alternativa_Escolhida(ID_Resposta, Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES (1,{Texto}, {Nome_Usuario}, {tipo_de_escolha_selecionada}, 'tutorial', {Quadro} )";

            DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

            atualizar.AtualizarBanco(consulta);

            BotaoSelecionado(1);
        }


        private void Botao_Resposta_2_Click(object sender, EventArgs e)
        {
            Texto = Botao_Resposta_2.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[1];

            consulta = $@"INSERT INTO Alternativa_Escolhida(ID_Resposta, Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES (1,{Texto}, {Nome_Usuario}, {tipo_de_escolha_selecionada}, 'tutorial', {Quadro} )";

            DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

            atualizar.AtualizarBanco(consulta);

            BotaoSelecionado(2);
        }


        private void Botao_Resposta_3_Click(object sender, EventArgs e)
        {
            Texto = Botao_Resposta_3.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[3];

            consulta = $@"INSERT INTO Alternativa_Escolhida(ID_Resposta, Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES (1,{Texto}, {Nome_Usuario}, {tipo_de_escolha_selecionada}, 'tutorial', {Quadro} )";

            DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

            atualizar.AtualizarBanco(consulta);

            BotaoSelecionado(3);
        }

        private void Tempo_Resposta_Tick(object sender, EventArgs e)
        {

            tempo--;

            Relogio_Tempo_Resposta.Text = Convert.ToString(tempo);



            if (tempo == 0)
            {
                BotaoBloquear(1);
                Tempo_Resposta.Enabled = false;
            }
        }


    }
}
