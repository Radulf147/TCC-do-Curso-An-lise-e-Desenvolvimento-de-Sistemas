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
    public partial class Tela_de_Cadastro : Form
    {
        DataBaseManager gerenciador;
        DataTable tabela;
        public string Nome = "";
        public string CPF = "";
        public string Senha = "";
        public Tela_de_Cadastro()
        {
            InitializeComponent();
            gerenciador = new DataBaseManager("Banco de Dados");
        }
        private void Botao_Cadastrar_Click(object sender, EventArgs e)
        {
            Nome = Nome_Texto.Text;
            CPF = CPF_Texto.Text;
            Senha = Senha_Texto.Text;
            if (CPF == "" || Senha == "")
            {
                Label_Alerta.Visible = true;
                Label_Alerta.Text = "Por favor, insira seu CPF, Nome ou Senha";
            }
            else
            { 
                tabela = gerenciador.ConsultarBanco($@"SELECT * FROM Usuario WHERE CPF = '{CPF}'");
            
                if (tabela.Rows.Count == 0)
                {

                    gerenciador.AtualizarBanco($@"INSERT INTO Usuario (Nome, CPF, Senha) VALUES ('{Nome}','{CPF}','{Senha}')");
                    this.Close();
                }
                else
                {
                    Label_Alerta.Visible = true;
                    CPF_Texto.Text = "";
                }
            }
        }
    }
}
