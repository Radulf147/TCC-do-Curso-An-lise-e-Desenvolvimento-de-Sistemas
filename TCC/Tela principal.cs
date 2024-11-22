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
    public partial class Tela_Principal : Form
    {
        public string diretorio = Directory.GetCurrentDirectory();

        public static int logado = 0;

        public static int Tutorial = 0;
        public static Jogador jogador = new Jogador();
        DataBaseManager gerenciador;
        public static int criar_personagem = 0;
        public static DataTable tabela;
        SoundPlayer som;

        public Tela_Principal()
        {
            
            InitializeComponent();
            gerenciador = new DataBaseManager("Banco de Dados");
            som = new SoundPlayer($@"{diretorio}\Sons Do Jogo\som-da-tela-inicial.wav");
            som.PlayLooping();

        }        
        
        private void Botao_Jogar_Click_1(object sender, EventArgs e)
        {            
            if(Tutorial != 0 && criar_personagem > 0)
            {
                Jogo jogo = new Jogo();
                this.Hide();
                som.Stop();
                jogo.ShowDialog();
                this.Show();
                som.PlayLooping();
                pictureBox_Redirecionamento.Visible = false;
                Botao_Sim.Visible = false;
                Botao_Nao.Visible = false;
                Botao_Sim.Enabled = false;
                Botao_Nao.Enabled = false;
                
            }
            else
            {
                Botao_Sim.Visible = true;
                Botao_Nao.Visible = true;
                Botao_Sim.Enabled = true;
                Botao_Nao.Enabled = true;
                pictureBox_Redirecionamento.Visible = true;
            }
        }

        private void Botao_Login_Click(object sender, EventArgs e)
        {
            if(logado == 0)
            { 
                Tela_De_Login login = new Tela_De_Login();
                this.Hide();
                login.ShowDialog();
                if (logado == 1)
                {
                    tabela = gerenciador.ConsultarBanco($@"SELECT Nome, Cabelo, Idade, Blusa, Calca, Pele, Sexo FROM Personagem WHERE CPF_Usuario = '{jogador.CPF}'");
                    if (tabela.Rows.Count > 0)
                    {
                        jogador.personagem.nome = tabela.Rows[0]["Nome"].ToString();
                        jogador.personagem.cabelo = tabela.Rows[0]["Cabelo"].ToString();
                        jogador.personagem.idade = tabela.Rows[0]["Idade"].ToString();
                        jogador.personagem.blusa = tabela.Rows[0]["Blusa"].ToString();
                        jogador.personagem.calca = tabela.Rows[0]["Calca"].ToString();
                        jogador.personagem.pele = tabela.Rows[0]["Pele"].ToString();
                        jogador.personagem.sexo = tabela.Rows[0]["Sexo"].ToString();
                        criar_personagem = 1;
                    }
                    Botao_Login.Text = "Desconectar";
                }                
                this.Show();
                
            }
            else 
            {
                Botao_Login.Text = "Login";
                jogador.Nome = "";
                jogador.CPF = "";
                logado = 0;
                jogador = new Jogador();
                Tutorial = 0;
                criar_personagem = 0;
            }
        }

        private void Botao_Sim_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            this.Hide();
            som.Stop();
            tutorial.ShowDialog();
            this.Show();
            som.PlayLooping();
            pictureBox_Redirecionamento.Visible = false;
            Botao_Sim.Visible = false;
            Botao_Nao.Visible = false;
            Botao_Sim.Enabled = false;
            Botao_Nao.Enabled = false;

        }

        private void Botao_Nao_Click(object sender, EventArgs e)
        {
            
            if (criar_personagem == 0)
            {
                Criar_Personagem personagem = new Criar_Personagem();
                this.Hide();
                som.Stop();
                personagem.ShowDialog();
                this.Show();
                pictureBox_Redirecionamento.Visible = false;
                Botao_Sim.Visible = false;
                Botao_Nao.Visible = false;
                Botao_Sim.Enabled = false;
                Botao_Nao.Enabled = false;
            }
            if(criar_personagem > 0)
            {
                this.Hide();
                Jogo jogo = new Jogo();
                jogo.ShowDialog();
                this.Show();
                som.PlayLooping();
                pictureBox_Redirecionamento.Visible = false;
                Botao_Sim.Visible = false;
                Botao_Nao.Visible = false;
                Botao_Sim.Enabled = false;
                Botao_Nao.Enabled = false;
            }

        }

        
    }
}
