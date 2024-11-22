namespace TCC
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.Botao_Next = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Personagem_1 = new System.Windows.Forms.PictureBox();
            this.Personagem_2 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Texto_Dialogo = new System.Windows.Forms.PictureBox();
            this.Imagem_Falante = new System.Windows.Forms.PictureBox();
            this.Texto_Dialogo = new System.Windows.Forms.Label();
            this.Casa_Do_Cachorro = new System.Windows.Forms.PictureBox();
            this.NPC_Nino = new System.Windows.Forms.PictureBox();
            this.Nuvens_Gif = new System.Windows.Forms.PictureBox();
            this.Botao_Resposta_1 = new System.Windows.Forms.Button();
            this.Botao_Resposta_2 = new System.Windows.Forms.Button();
            this.Botao_Resposta_3 = new System.Windows.Forms.Button();
            this.Botao_Resposta_4 = new System.Windows.Forms.Button();
            this.PictureBox_Qualidade_Resposta = new System.Windows.Forms.PictureBox();
            this.Nome_Falante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Personagem_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personagem_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Texto_Dialogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Falante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Casa_Do_Cachorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC_Nino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuvens_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Qualidade_Resposta)).BeginInit();
            this.SuspendLayout();
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 500;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Botao_Next
            // 
            this.Botao_Next.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Next.BackgroundImage")));
            this.Botao_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Next.FlatAppearance.BorderSize = 0;
            this.Botao_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Botao_Next.Location = new System.Drawing.Point(1027, 466);
            this.Botao_Next.Name = "Botao_Next";
            this.Botao_Next.Size = new System.Drawing.Size(85, 48);
            this.Botao_Next.TabIndex = 13;
            this.Botao_Next.UseVisualStyleBackColor = false;
            this.Botao_Next.Click += new System.EventHandler(this.Botao_Next_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "escolha-1.png");
            this.imageList2.Images.SetKeyName(1, "escolha-2.png");
            this.imageList2.Images.SetKeyName(2, "escolha-3.png");
            this.imageList2.Images.SetKeyName(3, "escolha-4.png");
            // 
            // Personagem_1
            // 
            this.Personagem_1.BackColor = System.Drawing.Color.Transparent;
            this.Personagem_1.Image = ((System.Drawing.Image)(resources.GetObject("Personagem_1.Image")));
            this.Personagem_1.Location = new System.Drawing.Point(758, 330);
            this.Personagem_1.Name = "Personagem_1";
            this.Personagem_1.Size = new System.Drawing.Size(78, 127);
            this.Personagem_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Personagem_1.TabIndex = 19;
            this.Personagem_1.TabStop = false;
            this.Personagem_1.Visible = false;
            // 
            // Personagem_2
            // 
            this.Personagem_2.BackColor = System.Drawing.Color.Transparent;
            this.Personagem_2.Image = ((System.Drawing.Image)(resources.GetObject("Personagem_2.Image")));
            this.Personagem_2.Location = new System.Drawing.Point(900, 330);
            this.Personagem_2.Name = "Personagem_2";
            this.Personagem_2.Size = new System.Drawing.Size(73, 127);
            this.Personagem_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Personagem_2.TabIndex = 20;
            this.Personagem_2.TabStop = false;
            this.Personagem_2.Visible = false;
            // 
            // PictureBox_Texto_Dialogo
            // 
            this.PictureBox_Texto_Dialogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Texto_Dialogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Texto_Dialogo.Image")));
            this.PictureBox_Texto_Dialogo.Location = new System.Drawing.Point(141, 12);
            this.PictureBox_Texto_Dialogo.Name = "PictureBox_Texto_Dialogo";
            this.PictureBox_Texto_Dialogo.Size = new System.Drawing.Size(830, 121);
            this.PictureBox_Texto_Dialogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Texto_Dialogo.TabIndex = 24;
            this.PictureBox_Texto_Dialogo.TabStop = false;
            // 
            // Imagem_Falante
            // 
            this.Imagem_Falante.BackColor = System.Drawing.Color.Transparent;
            this.Imagem_Falante.Image = ((System.Drawing.Image)(resources.GetObject("Imagem_Falante.Image")));
            this.Imagem_Falante.Location = new System.Drawing.Point(12, 12);
            this.Imagem_Falante.Name = "Imagem_Falante";
            this.Imagem_Falante.Size = new System.Drawing.Size(131, 121);
            this.Imagem_Falante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem_Falante.TabIndex = 25;
            this.Imagem_Falante.TabStop = false;
            // 
            // Texto_Dialogo
            // 
            this.Texto_Dialogo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Texto_Dialogo.AutoSize = true;
            this.Texto_Dialogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Texto_Dialogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Texto_Dialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Dialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Texto_Dialogo.Location = new System.Drawing.Point(175, 30);
            this.Texto_Dialogo.MaximumSize = new System.Drawing.Size(760, 100);
            this.Texto_Dialogo.Name = "Texto_Dialogo";
            this.Texto_Dialogo.Size = new System.Drawing.Size(0, 32);
            this.Texto_Dialogo.TabIndex = 26;
            this.Texto_Dialogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Texto_Dialogo.UseCompatibleTextRendering = true;
            // 
            // Casa_Do_Cachorro
            // 
            this.Casa_Do_Cachorro.BackColor = System.Drawing.Color.Transparent;
            this.Casa_Do_Cachorro.Image = ((System.Drawing.Image)(resources.GetObject("Casa_Do_Cachorro.Image")));
            this.Casa_Do_Cachorro.Location = new System.Drawing.Point(12, 313);
            this.Casa_Do_Cachorro.Name = "Casa_Do_Cachorro";
            this.Casa_Do_Cachorro.Size = new System.Drawing.Size(157, 130);
            this.Casa_Do_Cachorro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Casa_Do_Cachorro.TabIndex = 29;
            this.Casa_Do_Cachorro.TabStop = false;
            this.Casa_Do_Cachorro.Click += new System.EventHandler(this.Casa_Do_Cachorro_Click);
            // 
            // NPC_Nino
            // 
            this.NPC_Nino.BackColor = System.Drawing.Color.Transparent;
            this.NPC_Nino.Image = ((System.Drawing.Image)(resources.GetObject("NPC_Nino.Image")));
            this.NPC_Nino.Location = new System.Drawing.Point(175, 359);
            this.NPC_Nino.Name = "NPC_Nino";
            this.NPC_Nino.Size = new System.Drawing.Size(140, 99);
            this.NPC_Nino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NPC_Nino.TabIndex = 30;
            this.NPC_Nino.TabStop = false;
            // 
            // Nuvens_Gif
            // 
            this.Nuvens_Gif.BackColor = System.Drawing.Color.Transparent;
            this.Nuvens_Gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nuvens_Gif.Image = ((System.Drawing.Image)(resources.GetObject("Nuvens_Gif.Image")));
            this.Nuvens_Gif.Location = new System.Drawing.Point(-2, 1);
            this.Nuvens_Gif.Name = "Nuvens_Gif";
            this.Nuvens_Gif.Size = new System.Drawing.Size(1336, 394);
            this.Nuvens_Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nuvens_Gif.TabIndex = 11;
            this.Nuvens_Gif.TabStop = false;
            // 
            // Botao_Resposta_1
            // 
            this.Botao_Resposta_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_1.BackgroundImage")));
            this.Botao_Resposta_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_1.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao_Resposta_1.Location = new System.Drawing.Point(211, 463);
            this.Botao_Resposta_1.Name = "Botao_Resposta_1";
            this.Botao_Resposta_1.Size = new System.Drawing.Size(159, 51);
            this.Botao_Resposta_1.TabIndex = 31;
            this.Botao_Resposta_1.UseVisualStyleBackColor = true;
            this.Botao_Resposta_1.Visible = false;
            // 
            // Botao_Resposta_2
            // 
            this.Botao_Resposta_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_2.BackgroundImage")));
            this.Botao_Resposta_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_2.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao_Resposta_2.Location = new System.Drawing.Point(373, 463);
            this.Botao_Resposta_2.Name = "Botao_Resposta_2";
            this.Botao_Resposta_2.Size = new System.Drawing.Size(159, 51);
            this.Botao_Resposta_2.TabIndex = 32;
            this.Botao_Resposta_2.UseVisualStyleBackColor = true;
            this.Botao_Resposta_2.Visible = false;
            // 
            // Botao_Resposta_3
            // 
            this.Botao_Resposta_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_3.BackgroundImage")));
            this.Botao_Resposta_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_3.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao_Resposta_3.Location = new System.Drawing.Point(535, 463);
            this.Botao_Resposta_3.Name = "Botao_Resposta_3";
            this.Botao_Resposta_3.Size = new System.Drawing.Size(159, 51);
            this.Botao_Resposta_3.TabIndex = 33;
            this.Botao_Resposta_3.UseVisualStyleBackColor = true;
            this.Botao_Resposta_3.Visible = false;
            // 
            // Botao_Resposta_4
            // 
            this.Botao_Resposta_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Resposta_4.BackgroundImage")));
            this.Botao_Resposta_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Resposta_4.FlatAppearance.BorderSize = 0;
            this.Botao_Resposta_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Resposta_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botao_Resposta_4.Location = new System.Drawing.Point(697, 463);
            this.Botao_Resposta_4.Name = "Botao_Resposta_4";
            this.Botao_Resposta_4.Size = new System.Drawing.Size(159, 51);
            this.Botao_Resposta_4.TabIndex = 34;
            this.Botao_Resposta_4.UseVisualStyleBackColor = true;
            this.Botao_Resposta_4.Visible = false;
            // 
            // PictureBox_Qualidade_Resposta
            // 
            this.PictureBox_Qualidade_Resposta.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Qualidade_Resposta.Location = new System.Drawing.Point(12, 489);
            this.PictureBox_Qualidade_Resposta.Name = "PictureBox_Qualidade_Resposta";
            this.PictureBox_Qualidade_Resposta.Size = new System.Drawing.Size(31, 25);
            this.PictureBox_Qualidade_Resposta.TabIndex = 35;
            this.PictureBox_Qualidade_Resposta.TabStop = false;
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
            this.Nome_Falante.Location = new System.Drawing.Point(25, 94);
            this.Nome_Falante.Name = "Nome_Falante";
            this.Nome_Falante.Size = new System.Drawing.Size(104, 31);
            this.Nome_Falante.TabIndex = 36;
            this.Nome_Falante.Text = "Nino";
            this.Nome_Falante.UseVisualStyleBackColor = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 521);
            this.Controls.Add(this.Nome_Falante);
            this.Controls.Add(this.PictureBox_Qualidade_Resposta);
            this.Controls.Add(this.Botao_Resposta_4);
            this.Controls.Add(this.Botao_Resposta_3);
            this.Controls.Add(this.Botao_Resposta_2);
            this.Controls.Add(this.Botao_Resposta_1);
            this.Controls.Add(this.NPC_Nino);
            this.Controls.Add(this.Casa_Do_Cachorro);
            this.Controls.Add(this.Texto_Dialogo);
            this.Controls.Add(this.Imagem_Falante);
            this.Controls.Add(this.PictureBox_Texto_Dialogo);
            this.Controls.Add(this.Personagem_2);
            this.Controls.Add(this.Personagem_1);
            this.Controls.Add(this.Botao_Next);
            this.Controls.Add(this.Nuvens_Gif);
            this.DoubleBuffered = true;
            this.Name = "Tutorial";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Personagem_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personagem_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Texto_Dialogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Falante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Casa_Do_Cachorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC_Nino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuvens_Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Qualidade_Resposta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button Botao_Next;
        private System.Windows.Forms.PictureBox Personagem_1;
        private System.Windows.Forms.PictureBox Personagem_2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox PictureBox_Texto_Dialogo;
        private System.Windows.Forms.PictureBox Imagem_Falante;
        private System.Windows.Forms.Label Texto_Dialogo;
        private System.Windows.Forms.PictureBox Casa_Do_Cachorro;
        private System.Windows.Forms.PictureBox NPC_Nino;
        private System.Windows.Forms.PictureBox Nuvens_Gif;
        private System.Windows.Forms.Button Botao_Resposta_1;
        private System.Windows.Forms.Button Botao_Resposta_2;
        private System.Windows.Forms.Button Botao_Resposta_3;
        private System.Windows.Forms.Button Botao_Resposta_4;
        private System.Windows.Forms.PictureBox PictureBox_Qualidade_Resposta;
        private System.Windows.Forms.Button Nome_Falante;
    }
}