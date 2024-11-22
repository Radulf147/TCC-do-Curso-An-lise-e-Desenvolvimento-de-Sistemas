using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace TCC
{
    public partial class Jogo : Form
    {
        public string diretorio = Directory.GetCurrentDirectory();
        public int velocidadeX = 26;
        public int velocidadeY = -22;
        public int g = 2;
        SoundPlayer som4;
        Random random = new Random();
        SoundPlayer som5;
        DataBaseManager gerenciador;
        DataTable tabela;
        string caminho_personagem_img = "";
        public string linha = "";
        public int Quadro = 0;
        public int x = 0;
        public int y = 0;
        public int contador = 1;
        public int contador2 = 0;
        public int contador3 = 0;
        public int Velocidade = 5;
        public int resposta = 4;
        public double forca = 0;
        public double angulo = 0;
        public string Texto = "";
        public string tipo_de_escolha_selecionada = "";
        public string consulta = "";
        public string[] tipos_de_escolha = new string[4] { "ruim-1", "ruim-2", "boa", "neutra" };
        public Jogo()
        {
            InitializeComponent();
            Nome_Falante.Text = Tela_Principal.jogador.personagem.nome;
            Nome_Falante.ForeColor = Color.White;
            som4 = new SoundPlayer($@"{diretorio}\Sons Do Jogo\Som-ronco.wav");
            som4.PlayLooping();
            gerenciador = new DataBaseManager("Banco de Dados");
            InicializarConversa();

        }
        public void Botaobloquear(int i)
        {        
            if (i == 1)
            {
                Botao_Resposta_0.Visible = true;
                Botao_Resposta_1.Visible = true;
                Botao_Resposta_2.Visible = true;
                Botao_Resposta_3.Visible = true;
            }
            if (i == 0)
            {
                Botao_Resposta_0.Visible = false;
                Botao_Resposta_1.Visible = false;
                Botao_Resposta_2.Visible = false;
                Botao_Resposta_3.Visible = false;
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
            if (tipo_escolha1 == "neu")
            {
                PictureBox_Qualidade_Resposta.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Decisão-neutra.png";
            }
        }
        private void Proximo_Quadro()
        {

            tabela = gerenciador.ConsultarBanco($"SELECT * FROM Dialogo WHERE Quadro = {Quadro} AND Capitulos = '1'");

            linha = tabela.Rows[0]["Falas"].ToString();

            Texto_Dialogo.Text = linha;

            Texto_Dialogo.Font = new Font("Windows Command Prompt", Texto_Dialogo.Font.Size);

            Nome_Falante.Text = Tela_Principal.jogador.personagem.nome;

            Nome_Falante.ForeColor = Color.Snow;

            Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\Personagem_Principal_fala.png";

            if (Quadro == 1)
            {
                som4.Stop();
                Barulho_pictureBox.Visible = true;
                Barulho2_pictureBox.Visible = true;
                ZzzZZZ_pictureBox.Visible = false;

                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Telefone_fala.png";
                som5 = new SoundPlayer($@"{diretorio}\Sons Do Jogo\Som_telefone.wav");
                som5.PlayLooping();
                Nome_Falante.Text = "Celular";

            }
            if (Quadro == 2)
            {
                Telefone_pictureBox.Location = new Point(907, 389);
                Barulho_pictureBox.Visible = false;
                Barulho2_pictureBox.Visible = false;
                som5.Stop();
                Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\tipos_aparencia\branco\castanho_branco_vermelho_azul\frente.png";

            }
            if (Quadro == 3)
            {
                Nome_Falante.Text = "Celular";
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Telefone_fala.png";
            }
            if (Quadro == 4)
            {
                Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\tipos_aparencia\branco\castanho_branco_vermelho_azul\frente.png";
            }
            if (Quadro == 5)
            {
                Nome_Falante.Text = "Celular";
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Telefone_fala.png";
            }
            if (Quadro == 6)
            {
                Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\tipos_aparencia\branco\castanho_branco_vermelho_azul\frente.png";
            }
            if (Quadro == 7)
            {
                Nome_Falante.Text = "Celular";
                Imagem_Falante.ImageLocation = $@"{diretorio}\Imagens\Background-photos\Telefone_fala.png";
            }
            if (Quadro == 8)
            {
                Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\tipos_aparencia\branco\castanho_branco_vermelho_azul\frente.png";
            }
            if (Quadro == 9)
            {
                Telefone_pictureBox.Visible = false;

                TimerMovimento.Start();
                TimerAnimacao.Start();
                som4.Stop();

                Imagem_Falante.Visible = false;
                PictureBox_Texto_Dialogo.Visible = false;
                Nome_Falante.Visible = false;
                Texto_Dialogo.Visible = false;
                Botao_Next.Visible = false;
            }
            if (Quadro == 10)
            {
                Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\De_Lado_2.png";
                Imagem_Falante.Visible = true;
                PictureBox_Texto_Dialogo.Visible = true;
                Nome_Falante.Visible = true;
                Texto_Dialogo.Visible = true;
                
            }
            if (Quadro == 11)
            {
                tabela = gerenciador.ConsultarBanco($"SELECT * FROM Alternativa WHERE Quadro = {Quadro} AND Capitulo = '1'");
                Botao_Resposta_0.Text = tabela.Rows[0]["Texto"].ToString();
                Botao_Resposta_1.Text = tabela.Rows[1]["Texto"].ToString();
                Botao_Resposta_2.Text = tabela.Rows[2]["Texto"].ToString();
                Botao_Resposta_3.Text = tabela.Rows[3]["Texto"].ToString();
                Botaobloquear(1);

            }
            if(Quadro == 12)
            {
                if (tipo_de_escolha_selecionada == "")
                {

                    tipo_de_escolha_selecionada = tipos_de_escolha[random.Next(0, 4)];
                }
                MudarImagemTipoEscolha(tipo_de_escolha_selecionada);
                timerMovimentoBola.Start();
            }
            if (Quadro == 13)
            {
                tabela = gerenciador.ConsultarBanco($"SELECT * FROM Resposta_Alternativa WHERE Quadro = {Quadro} AND Capitulos = '1' AND Qualidade_Alternativa = '{tipo_de_escolha_selecionada}'");

                linha = tabela.Rows[0]["Falas"].ToString();

                Texto_Dialogo.Text = linha;
            }

            Quadro++;
    }
    private void InicializarConversa()
        {
            //Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\tipos-aparencia\branco\{Tela_Principal.jogador.personagem.cabelo}_{Tela_Principal.jogador.personagem.pele}_{Tela_Principal.jogador.personagem.blusa}_{Tela_Principal.jogador.personagem.calca}\dormindo.png";

            Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\tipos_aparencia\branco\castanho_branco_vermelho_azul\dormindo.png";

            tabela = gerenciador.ConsultarBanco($"SELECT * FROM Dialogo WHERE Quadro = {Quadro} AND Capitulos = '1'");

            linha = tabela.Rows[0]["Falas"].ToString();

            Texto_Dialogo.Text = linha;

            x = Personagem_pictureBox.Location.X;

            y = Personagem_pictureBox.Location.Y;

            Quadro++;

            
        }

        private void timerMovimentoBola_Tick(object sender, EventArgs e)
        {
            int x_atual = Bola_PictureBox.Location.X;
            int y_atual = Bola_PictureBox.Location.Y;

            Bola_PictureBox.Location = new Point(x_atual + velocidadeX, y_atual + velocidadeY);

            velocidadeY += g;



            if (Bola_PictureBox.Location.X > this.Width || Bola_PictureBox.Location.Y > 288)
            {
                if (Bola_PictureBox.Location.X > 830 && Bola_PictureBox.Location.X < 900 && Bola_PictureBox.Location.Y > 239)
                {
                    Bola_PictureBox.Visible = false;
                    timerMovimentoBola.Stop();
                }
                    timerMovimentoBola.Stop();
            }
        }
        private void BotaoSelecionado(int numb_botao)
        {
            Botao_Resposta_0.FlatAppearance.BorderSize = 0;
            Botao_Resposta_1.FlatAppearance.BorderSize = 0;
            Botao_Resposta_2.FlatAppearance.BorderSize = 0;
            Botao_Resposta_3.FlatAppearance.BorderSize = 0;

            if (numb_botao == 0)
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
        private void TimerMovimento_Tick(object sender, EventArgs e)
        {       
            if(y>104)
            { 
                if(x > 62)
                { 
                    x = Personagem_pictureBox.Location.X - Velocidade;
                    y = Personagem_pictureBox.Location.Y;
                    Personagem_pictureBox.Location = new Point(x, y);
                }
                else
                {
                    x = Personagem_pictureBox.Location.X ;
                    y = Personagem_pictureBox.Location.Y - Velocidade;
                    Personagem_pictureBox.Location = new Point(x, y);
                }
            }
            else
            {
                TimerMovimento.Stop(); Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\costas.png";
                Botao_Next.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerMovimentoBola.Start();
        }

        private void TimerAnimacao_Tick(object sender, EventArgs e)
        {
            if(y >104)
            { 
                if(x > 62)
                { 
                    if (contador % 2 != 0)
                    {

                        Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\Correndo_De_Lado2.png";
                    }
                    else
                    {
                        Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\Correndo_De_Lado1.png";
                    }
                    contador++;
                }
                else
                {
                    if (contador % 2 != 0)
                    {

                        Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\correndo_costas1.png";
                    }
                    else
                    {
                        Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\correndo_costas2.png";
                    }
                    contador++;
                }
            }
            else
            {
                if(contador2 == 3)
                {
                    
                    TimerAnimacao.Stop();                   
                }
                contador2++;
            }
        }

        private void TimerAnimacao2_Tick(object sender, EventArgs e)
        {
            Personagem_pictureBox.ImageLocation = $@"{diretorio}\Imagens\Personagens\personagem_principal\De_Lado_2.png";
        }

        private void Bola_PictureBox_Click(object sender, EventArgs e)
        {
            
            
            timerMovimentoBola.Start();
           
            

        }

        private void Botao_Next_Click(object sender, EventArgs e)
        {
            Proximo_Quadro();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {

        }

        private void Botao_Resposta_0_Click(object sender, EventArgs e)
        {
            resposta = 0;
            velocidadeX = 26;

            Texto = Botao_Resposta_0.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[2];
            if (Tela_Principal.logado == 1)
            { 
            consulta = $@"INSERT INTO Alternativa_Escolhida(Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES ('{Texto}', '{Tela_Principal.jogador.Nome}', '{tipo_de_escolha_selecionada}', '1', {Quadro} )";

            DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

            atualizar.AtualizarBanco(consulta);
            }
            BotaoSelecionado(0);


        }

        private void Botao_Resposta_1_Click(object sender, EventArgs e)
        {
            resposta = 1;
            velocidadeX = 15;
            Texto = Botao_Resposta_0.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[0];
            if (Tela_Principal.logado == 1)
            {
                consulta = $@"INSERT INTO Alternativa_Escolhida(Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES ('{Texto}', '{Tela_Principal.jogador.Nome}', '{tipo_de_escolha_selecionada}', '1', {Quadro} )";

                DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

                atualizar.AtualizarBanco(consulta);
            }
            BotaoSelecionado(0);
        }

        private void Botao_Resposta_2_Click(object sender, EventArgs e)
        {
            resposta = 2;
            velocidadeX = 8;
            Texto = Botao_Resposta_0.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[1];
            if (Tela_Principal.logado == 1)
            {
                consulta = $@"INSERT INTO Alternativa_Escolhida(Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES ('{Texto}', '{Tela_Principal.jogador.Nome}', '{tipo_de_escolha_selecionada}', '1', {Quadro} )";

                DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

                atualizar.AtualizarBanco(consulta);
            }
            BotaoSelecionado(0);
        }

        private void Botao_Resposta_3_Click(object sender, EventArgs e)
        {
            resposta = 3;
            velocidadeX = 30;
            Texto = Botao_Resposta_0.Text;

            tipo_de_escolha_selecionada = tipos_de_escolha[3];
            if (Tela_Principal.logado == 1)
            {
                consulta = $@"INSERT INTO Alternativa_Escolhida(Resposta_Escolhida_Texto, Nomes, Qualidade_Resposta, Capitulo, Quadro) VALUES ('{Texto}', '{Tela_Principal.jogador.Nome}', '{tipo_de_escolha_selecionada}', '1', {Quadro} )";

                DataBaseManager atualizar = new DataBaseManager("Banco De Dados");

                atualizar.AtualizarBanco(consulta);
            }
            BotaoSelecionado(0);
        }
    }
}
