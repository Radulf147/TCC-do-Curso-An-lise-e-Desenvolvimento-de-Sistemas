namespace TCC
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.ZzzZZZ_pictureBox = new System.Windows.Forms.PictureBox();
            this.picLixeira = new System.Windows.Forms.PictureBox();
            this.Bola_PictureBox = new System.Windows.Forms.PictureBox();
            this.timerMovimentoBola = new System.Windows.Forms.Timer(this.components);
            this.TimerMovimento = new System.Windows.Forms.Timer(this.components);
            this.Texto_Dialogo = new System.Windows.Forms.Label();
            this.TimerAnimacao = new System.Windows.Forms.Timer(this.components);
            this.TimerAnimacao2 = new System.Windows.Forms.Timer(this.components);
            this.Botao_Resposta_3 = new System.Windows.Forms.Button();
            this.Botao_Resposta_2 = new System.Windows.Forms.Button();
            this.Botao_Resposta_1 = new System.Windows.Forms.Button();
            this.Botao_Next = new System.Windows.Forms.Button();
            this.Barulho_pictureBox = new System.Windows.Forms.PictureBox();
            this.Barulho2_pictureBox = new System.Windows.Forms.PictureBox();
            this.Telefone_pictureBox = new System.Windows.Forms.PictureBox();
            this.Personagem_pictureBox = new System.Windows.Forms.PictureBox();
            this.Forca_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nome_Falante = new System.Windows.Forms.Button();
            this.Imagem_Falante = new System.Windows.Forms.PictureBox();
            this.PictureBox_Texto_Dialogo = new System.Windows.Forms.PictureBox();
            this.PictureBox_Qualidade_Resposta = new System.Windows.Forms.PictureBox();
            this.Botao_Resposta_0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZzzZZZ_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLixeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bola_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barulho_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barulho2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Telefone_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personagem_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forca_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Falante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Texto_Dialogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Qualidade_Resposta)).BeginInit();
            this.SuspendLayout();
            // 
            // ZzzZZZ_pictureBox
            // 
            this.ZzzZZZ_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ZzzZZZ_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ZzzZZZ_pictureBox.Image")));
            this.ZzzZZZ_pictureBox.Location = new System.Drawing.Point(955, 275);
            this.ZzzZZZ_pictureBox.Name = "ZzzZZZ_pictureBox";
            this.ZzzZZZ_pictureBox.Size = new System.Drawing.Size(67, 50);
            this.ZzzZZZ_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ZzzZZZ_pictureBox.TabIndex = 28;
            this.ZzzZZZ_pictureBox.TabStop = false;
            // 
            // picLixeira
            // 
            this.picLixeira.BackColor = System.Drawing.Color.Transparent;
            this.picLixeira.Image = ((System.Drawing.Image)(resources.GetObject("picLixeira.Image")));
            this.picLixeira.Location = new System.Drawing.Point(839, 239);
            this.picLixeira.Name = "picLixeira";
            this.picLixeira.Size = new System.Drawing.Size(66, 66);
            this.picLixeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLixeira.TabIndex = 38;
            this.picLixeira.TabStop = false;
            // 
            // Bola_PictureBox
            // 
            this.Bola_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bola_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Bola_PictureBox.Image")));
            this.Bola_PictureBox.Location = new System.Drawing.Point(147, 119);
            this.Bola_PictureBox.Name = "Bola_PictureBox";
            this.Bola_PictureBox.Size = new System.Drawing.Size(15, 16);
            this.Bola_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bola_PictureBox.TabIndex = 39;
            this.Bola_PictureBox.TabStop = false;
            this.Bola_PictureBox.Click += new System.EventHandler(this.Bola_PictureBox_Click);
            // 
            // timerMovimentoBola
            // 
            this.timerMovimentoBola.Interval = 40;
            this.timerMovimentoBola.Tick += new System.EventHandler(this.timerMovimentoBola_Tick);
            // 
            // TimerMovimento
            // 
            this.TimerMovimento.Interval = 50;
            this.TimerMovimento.Tick += new System.EventHandler(this.TimerMovimento_Tick);
            // 
            // Texto_Dialogo
            // 
            this.Texto_Dialogo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Texto_Dialogo.AutoSize = true;
            this.Texto_Dialogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Texto_Dialogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Texto_Dialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Dialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Texto_Dialogo.Location = new System.Drawing.Point(185, 38);
            this.Texto_Dialogo.MaximumSize = new System.Drawing.Size(760, 100);
            this.Texto_Dialogo.Name = "Texto_Dialogo";
            this.Texto_Dialogo.Size = new System.Drawing.Size(0, 32);
            this.Texto_Dialogo.TabIndex = 44;
            this.Texto_Dialogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Texto_Dialogo.UseCompatibleTextRendering = true;
            // 
            // TimerAnimacao
            // 
            this.TimerAnimacao.Interval = 150;
            this.TimerAnimacao.Tick += new System.EventHandler(this.TimerAnimacao_Tick);
            // 
            // TimerAnimacao2
            // 
            this.TimerAnimacao2.Interval = 150;
            this.TimerAnimacao2.Tick += new System.EventHandler(this.TimerAnimacao2_Tick);
            // 
            // Botao_Resposta_3
            // 
            this.Botao_Resposta_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Botao_Resposta_3.BackColor = System.Drawing.SystemColors.Control;
            this.Botao_Resposta_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_3.BackgroundImage")));
            this.Botao_Resposta_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.Botao_Resposta_3.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Botao_Resposta_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Botao_Resposta_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Botao_Resposta_3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Botao_Resposta_3.Location = new System.Drawing.Point(734, 436);
            this.Botao_Resposta_3.Name = "Botao_Resposta_3";
            this.Botao_Resposta_3.Size = new System.Drawing.Size(235, 51);
            this.Botao_Resposta_3.TabIndex = 52;
            this.Botao_Resposta_3.UseVisualStyleBackColor = false;
            this.Botao_Resposta_3.Visible = false;
            this.Botao_Resposta_3.Click += new System.EventHandler(this.Botao_Resposta_3_Click);
            // 
            // Botao_Resposta_2
            // 
            this.Botao_Resposta_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Botao_Resposta_2.BackColor = System.Drawing.SystemColors.Control;
            this.Botao_Resposta_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_2.BackgroundImage")));
            this.Botao_Resposta_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.Botao_Resposta_2.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Botao_Resposta_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Botao_Resposta_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Botao_Resposta_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Botao_Resposta_2.Location = new System.Drawing.Point(493, 436);
            this.Botao_Resposta_2.Name = "Botao_Resposta_2";
            this.Botao_Resposta_2.Size = new System.Drawing.Size(235, 51);
            this.Botao_Resposta_2.TabIndex = 51;
            this.Botao_Resposta_2.UseVisualStyleBackColor = false;
            this.Botao_Resposta_2.Visible = false;
            this.Botao_Resposta_2.Click += new System.EventHandler(this.Botao_Resposta_2_Click);
            // 
            // Botao_Resposta_1
            // 
            this.Botao_Resposta_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_1.BackgroundImage")));
            this.Botao_Resposta_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_1.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Botao_Resposta_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao_Resposta_1.Location = new System.Drawing.Point(252, 437);
            this.Botao_Resposta_1.Name = "Botao_Resposta_1";
            this.Botao_Resposta_1.Size = new System.Drawing.Size(235, 51);
            this.Botao_Resposta_1.TabIndex = 50;
            this.Botao_Resposta_1.UseVisualStyleBackColor = true;
            this.Botao_Resposta_1.Visible = false;
            this.Botao_Resposta_1.Click += new System.EventHandler(this.Botao_Resposta_1_Click);
            // 
            // Botao_Next
            // 
            this.Botao_Next.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Next.BackgroundImage")));
            this.Botao_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Botao_Next.FlatAppearance.BorderSize = 0;
            this.Botao_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Next.Location = new System.Drawing.Point(975, 439);
            this.Botao_Next.Name = "Botao_Next";
            this.Botao_Next.Size = new System.Drawing.Size(99, 48);
            this.Botao_Next.TabIndex = 48;
            this.Botao_Next.UseVisualStyleBackColor = false;
            this.Botao_Next.Click += new System.EventHandler(this.Botao_Next_Click);
            // 
            // Barulho_pictureBox
            // 
            this.Barulho_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Barulho_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Barulho_pictureBox.Image")));
            this.Barulho_pictureBox.Location = new System.Drawing.Point(1003, 346);
            this.Barulho_pictureBox.Name = "Barulho_pictureBox";
            this.Barulho_pictureBox.Size = new System.Drawing.Size(19, 18);
            this.Barulho_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barulho_pictureBox.TabIndex = 53;
            this.Barulho_pictureBox.TabStop = false;
            this.Barulho_pictureBox.Visible = false;
            // 
            // Barulho2_pictureBox
            // 
            this.Barulho2_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Barulho2_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Barulho2_pictureBox.Image")));
            this.Barulho2_pictureBox.Location = new System.Drawing.Point(1003, 384);
            this.Barulho2_pictureBox.Name = "Barulho2_pictureBox";
            this.Barulho2_pictureBox.Size = new System.Drawing.Size(19, 18);
            this.Barulho2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barulho2_pictureBox.TabIndex = 55;
            this.Barulho2_pictureBox.TabStop = false;
            this.Barulho2_pictureBox.Visible = false;
            // 
            // Telefone_pictureBox
            // 
            this.Telefone_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Telefone_pictureBox.Image")));
            this.Telefone_pictureBox.Location = new System.Drawing.Point(989, 361);
            this.Telefone_pictureBox.Name = "Telefone_pictureBox";
            this.Telefone_pictureBox.Size = new System.Drawing.Size(17, 27);
            this.Telefone_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Telefone_pictureBox.TabIndex = 56;
            this.Telefone_pictureBox.TabStop = false;
            // 
            // Personagem_pictureBox
            // 
            this.Personagem_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Personagem_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Personagem_pictureBox.Image")));
            this.Personagem_pictureBox.Location = new System.Drawing.Point(904, 331);
            this.Personagem_pictureBox.Name = "Personagem_pictureBox";
            this.Personagem_pictureBox.Size = new System.Drawing.Size(79, 110);
            this.Personagem_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Personagem_pictureBox.TabIndex = 45;
            this.Personagem_pictureBox.TabStop = false;
            // 
            // Forca_numericUpDown
            // 
            this.Forca_numericUpDown.Location = new System.Drawing.Point(902, 83);
            this.Forca_numericUpDown.Name = "Forca_numericUpDown";
            this.Forca_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Forca_numericUpDown.TabIndex = 46;
            this.Forca_numericUpDown.Visible = false;
            // 
            // Nome_Falante
            // 
            this.Nome_Falante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Nome_Falante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nome_Falante.BackgroundImage")));
            this.Nome_Falante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nome_Falante.Enabled = false;
            this.Nome_Falante.FlatAppearance.BorderSize = 0;
            this.Nome_Falante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nome_Falante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Falante.ForeColor = System.Drawing.Color.Snow;
            this.Nome_Falante.Location = new System.Drawing.Point(25, 77);
            this.Nome_Falante.Name = "Nome_Falante";
            this.Nome_Falante.Size = new System.Drawing.Size(104, 31);
            this.Nome_Falante.TabIndex = 59;
            this.Nome_Falante.Text = "raul";
            this.Nome_Falante.UseVisualStyleBackColor = false;
            // 
            // Imagem_Falante
            // 
            this.Imagem_Falante.BackColor = System.Drawing.Color.Transparent;
            this.Imagem_Falante.Image = ((System.Drawing.Image)(resources.GetObject("Imagem_Falante.Image")));
            this.Imagem_Falante.Location = new System.Drawing.Point(12, 6);
            this.Imagem_Falante.Name = "Imagem_Falante";
            this.Imagem_Falante.Size = new System.Drawing.Size(129, 111);
            this.Imagem_Falante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem_Falante.TabIndex = 58;
            this.Imagem_Falante.TabStop = false;
            // 
            // PictureBox_Texto_Dialogo
            // 
            this.PictureBox_Texto_Dialogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Texto_Dialogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Texto_Dialogo.Image")));
            this.PictureBox_Texto_Dialogo.Location = new System.Drawing.Point(137, 6);
            this.PictureBox_Texto_Dialogo.Name = "PictureBox_Texto_Dialogo";
            this.PictureBox_Texto_Dialogo.Size = new System.Drawing.Size(932, 111);
            this.PictureBox_Texto_Dialogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Texto_Dialogo.TabIndex = 57;
            this.PictureBox_Texto_Dialogo.TabStop = false;
            // 
            // PictureBox_Qualidade_Resposta
            // 
            this.PictureBox_Qualidade_Resposta.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Qualidade_Resposta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Qualidade_Resposta.Location = new System.Drawing.Point(11, 462);
            this.PictureBox_Qualidade_Resposta.Name = "PictureBox_Qualidade_Resposta";
            this.PictureBox_Qualidade_Resposta.Size = new System.Drawing.Size(31, 25);
            this.PictureBox_Qualidade_Resposta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Qualidade_Resposta.TabIndex = 60;
            this.PictureBox_Qualidade_Resposta.TabStop = false;
            // 
            // Botao_Resposta_0
            // 
            this.Botao_Resposta_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_0.BackgroundImage")));
            this.Botao_Resposta_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_0.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Resposta_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao_Resposta_0.Location = new System.Drawing.Point(11, 436);
            this.Botao_Resposta_0.MaximumSize = new System.Drawing.Size(247, 51);
            this.Botao_Resposta_0.Name = "Botao_Resposta_0";
            this.Botao_Resposta_0.Size = new System.Drawing.Size(235, 51);
            this.Botao_Resposta_0.TabIndex = 61;
            this.Botao_Resposta_0.UseVisualStyleBackColor = true;
            this.Botao_Resposta_0.Visible = false;
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 492);
            this.Controls.Add(this.Botao_Resposta_0);
            this.Controls.Add(this.PictureBox_Qualidade_Resposta);
            this.Controls.Add(this.Nome_Falante);
            this.Controls.Add(this.Imagem_Falante);
            this.Controls.Add(this.PictureBox_Texto_Dialogo);
            this.Controls.Add(this.Telefone_pictureBox);
            this.Controls.Add(this.Barulho2_pictureBox);
            this.Controls.Add(this.Barulho_pictureBox);
            this.Controls.Add(this.Botao_Resposta_3);
            this.Controls.Add(this.Botao_Resposta_2);
            this.Controls.Add(this.Botao_Resposta_1);
            this.Controls.Add(this.Botao_Next);
            this.Controls.Add(this.Forca_numericUpDown);
            this.Controls.Add(this.Personagem_pictureBox);
            this.Controls.Add(this.Texto_Dialogo);
            this.Controls.Add(this.Bola_PictureBox);
            this.Controls.Add(this.picLixeira);
            this.Controls.Add(this.ZzzZZZ_pictureBox);
            this.DoubleBuffered = true;
            this.Name = "Jogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZzzZZZ_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLixeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bola_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barulho_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barulho2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Telefone_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personagem_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forca_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Falante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Texto_Dialogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Qualidade_Resposta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ZzzZZZ_pictureBox;
        private System.Windows.Forms.PictureBox picLixeira;
        private System.Windows.Forms.Timer timerMovimentoBola;
        private System.Windows.Forms.Timer TimerMovimento;
        private System.Windows.Forms.Label Texto_Dialogo;
        private System.Windows.Forms.Timer TimerAnimacao;
        private System.Windows.Forms.Timer TimerAnimacao2;
        private System.Windows.Forms.Button Botao_Resposta_3;
        private System.Windows.Forms.Button Botao_Resposta_2;
        private System.Windows.Forms.Button Botao_Resposta_1;
        private System.Windows.Forms.Button Botao_Next;
        private System.Windows.Forms.PictureBox Barulho_pictureBox;
        private System.Windows.Forms.PictureBox Barulho2_pictureBox;
        private System.Windows.Forms.PictureBox Telefone_pictureBox;
        private System.Windows.Forms.PictureBox Personagem_pictureBox;
        private System.Windows.Forms.NumericUpDown Forca_numericUpDown;
        public System.Windows.Forms.PictureBox Bola_PictureBox;
        private System.Windows.Forms.Button Nome_Falante;
        private System.Windows.Forms.PictureBox Imagem_Falante;
        private System.Windows.Forms.PictureBox PictureBox_Texto_Dialogo;
        private System.Windows.Forms.PictureBox PictureBox_Qualidade_Resposta;
        private System.Windows.Forms.Button Botao_Resposta_0;
    }
}