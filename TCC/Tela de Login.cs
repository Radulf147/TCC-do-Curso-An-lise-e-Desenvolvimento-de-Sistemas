using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class Tela_De_Login : Form
    {
        DataBaseManager gerenciador;
        DataTable tabela;
        public string CPF = "";
        public string Senha = "";
        public string Nome = "";
        public Tela_De_Login()

        {
            InitializeComponent();

            gerenciador = new DataBaseManager("Banco de Dados");

        }

        private void Botao_Logar_Click(object sender, EventArgs e)
        {
            CPF = CPF_Texto.Text;
            Senha = Senha_Texto.Text;
            tabela = gerenciador.ConsultarBanco($@"SELECT * FROM Usuario WHERE CPF = '{CPF}' AND Senha = '{Senha}'");
            if (CPF == "" || Senha == "")
            {
                Label_Alerta.Visible = true;
                Label_Alerta.Text = "Por favor, insira seu CPF ou Senha";
            }
            else
            { 
                if(tabela.Rows.Count == 0)
                {
                    Label_Alerta.Visible = true;
                    Label_Alerta.Text = "Seu CPF ou Senha estão incorretos";
                    CPF_Texto.Text = "";
                    Senha_Texto.Text = "";
                }
                else
                {
                    Tela_Principal.logado = 1;
                    Tela_Principal.jogador.Nome = tabela.Rows[0]["Nome"].ToString();
                    Tela_Principal.jogador.CPF = tabela.Rows[0]["CPF"].ToString();                    

                    this.Close();
                }
            }
        }

        private void Botao_Cadastrar_Click(object sender, EventArgs e)
        {
            Tela_de_Cadastro cadastro = new Tela_de_Cadastro();
            
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }
    }
}
