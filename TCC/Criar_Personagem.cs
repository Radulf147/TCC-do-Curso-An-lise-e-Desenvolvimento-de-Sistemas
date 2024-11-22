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
    public partial class Criar_Personagem : Form
    {
        DataBaseManager gerenciador;
        public Criar_Personagem()
        {
            gerenciador = new DataBaseManager("Banco de Dados");
            InitializeComponent();
        }
        public void Testar()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Nome_textBox.Text == "" || Calca_comboBox.Text == "" || Cabelo_comboBox.Text == "" || Sexo_comboBox.Text == "" || Pele_comboBox.Text == "" || Blusa_comboBox.Text == "")
            {
                Label_Alerta.Visible = true;
            }
            else 
            { 
            Tela_Principal.jogador.personagem.nome = Nome_textBox.Text;
            Tela_Principal.jogador.personagem.blusa = Blusa_comboBox.Text;
            Tela_Principal.jogador.personagem.calca = Calca_comboBox.Text;
            Tela_Principal.jogador.personagem.cabelo = Cabelo_comboBox.Text;
            Tela_Principal.jogador.personagem.sexo = Sexo_comboBox.Text;
            Tela_Principal.jogador.personagem.pele = Pele_comboBox.Text;
            Tela_Principal.criar_personagem = 1;
                
            if (Tela_Principal.logado == 1)
                {
                    gerenciador.AtualizarBanco($@"INSERT INTO Personagem(Cabelo,Blusa,Calca, Nome, Pele, Sexo, Idade, CPF_Usuario) VALUES ('{Tela_Principal.jogador.personagem.cabelo}','{Tela_Principal.jogador.personagem.blusa}', '{Tela_Principal.jogador.personagem.calca}','{Tela_Principal.jogador.personagem.nome}','{Tela_Principal.jogador.personagem.pele}','{Tela_Principal.jogador.personagem.sexo}','18','{Tela_Principal.jogador.CPF}')");
                }

            this.Close();
            }
        }

        private void Sexo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabelo_comboBox.Visible = true;
            Calca_comboBox.Visible = true;
            Pele_comboBox.Visible = true;
            Blusa_comboBox.Visible = true;
            Cabelo_label.Visible = true;
            Calca_label.Visible = true;
            Pele_label.Visible = true;
            Blusa_label.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
