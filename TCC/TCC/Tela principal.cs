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
    public partial class Salaroll : Form
    {
        string diretorio = Directory.GetCurrentDirectory();
        public Salaroll()
        {
            
            InitializeComponent();

            string diretorio_Audio = $@"{diretorio}\Sons Do Jogo\som-da-tela-inicial.wav";

            SoundPlayer som = new SoundPlayer(diretorio_Audio);

            som.Load();

            som.PlayLooping();
        }        
        
        private void Botao_Jogar_Click_1(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            this.Hide();
            tutorial.Show();
            
            
        }
    }
}
