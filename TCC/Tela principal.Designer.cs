namespace TCC
{
    partial class Tela_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Botao_Login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Botao_Jogar = new System.Windows.Forms.Button();
            this.Botao_Nao = new System.Windows.Forms.Button();
            this.Botao_Sim = new System.Windows.Forms.Button();
            this.pictureBox_Redirecionamento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Redirecionamento)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(370, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "Caramel";
            // 
            // Botao_Login
            // 
            this.Botao_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_Login.AutoSize = true;
            this.Botao_Login.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Login.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Botao_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Botao_Login.Location = new System.Drawing.Point(12, 478);
            this.Botao_Login.Name = "Botao_Login";
            this.Botao_Login.Size = new System.Drawing.Size(50, 41);
            this.Botao_Login.TabIndex = 7;
            this.Botao_Login.Text = "Login";
            this.Botao_Login.UseVisualStyleBackColor = false;
            this.Botao_Login.Click += new System.EventHandler(this.Botao_Login_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(406, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 73);
            this.button3.TabIndex = 6;
            this.button3.Text = "Créditos";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Botao_Jogar
            // 
            this.Botao_Jogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Botao_Jogar.AutoSize = true;
            this.Botao_Jogar.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Jogar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Botao_Jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Jogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Botao_Jogar.Location = new System.Drawing.Point(406, 331);
            this.Botao_Jogar.Name = "Botao_Jogar";
            this.Botao_Jogar.Size = new System.Drawing.Size(180, 72);
            this.Botao_Jogar.TabIndex = 5;
            this.Botao_Jogar.Text = "Jogar";
            this.Botao_Jogar.UseVisualStyleBackColor = false;
            this.Botao_Jogar.Click += new System.EventHandler(this.Botao_Jogar_Click_1);
            // 
            // Botao_Nao
            // 
            this.Botao_Nao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Nao.BackgroundImage")));
            this.Botao_Nao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Nao.Enabled = false;
            this.Botao_Nao.FlatAppearance.BorderSize = 0;
            this.Botao_Nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Nao.Location = new System.Drawing.Point(772, 430);
            this.Botao_Nao.Name = "Botao_Nao";
            this.Botao_Nao.Size = new System.Drawing.Size(124, 68);
            this.Botao_Nao.TabIndex = 27;
            this.Botao_Nao.UseVisualStyleBackColor = true;
            this.Botao_Nao.Visible = false;
            this.Botao_Nao.Click += new System.EventHandler(this.Botao_Nao_Click);
            // 
            // Botao_Sim
            // 
            this.Botao_Sim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Botao_Sim.BackgroundImage")));
            this.Botao_Sim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Sim.FlatAppearance.BorderSize = 0;
            this.Botao_Sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Sim.Location = new System.Drawing.Point(772, 342);
            this.Botao_Sim.Name = "Botao_Sim";
            this.Botao_Sim.Size = new System.Drawing.Size(124, 70);
            this.Botao_Sim.TabIndex = 26;
            this.Botao_Sim.UseVisualStyleBackColor = true;
            this.Botao_Sim.Visible = false;
            this.Botao_Sim.Click += new System.EventHandler(this.Botao_Sim_Click);
            // 
            // pictureBox_Redirecionamento
            // 
            this.pictureBox_Redirecionamento.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Redirecionamento.Image")));
            this.pictureBox_Redirecionamento.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox_Redirecionamento.Name = "pictureBox_Redirecionamento";
            this.pictureBox_Redirecionamento.Size = new System.Drawing.Size(955, 526);
            this.pictureBox_Redirecionamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Redirecionamento.TabIndex = 25;
            this.pictureBox_Redirecionamento.TabStop = false;
            this.pictureBox_Redirecionamento.Visible = false;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 522);
            this.Controls.Add(this.Botao_Nao);
            this.Controls.Add(this.Botao_Sim);
            this.Controls.Add(this.pictureBox_Redirecionamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Botao_Login);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Botao_Jogar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_Principal";
            this.Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Redirecionamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Botao_Login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Botao_Jogar;
        private System.Windows.Forms.Button Botao_Nao;
        private System.Windows.Forms.Button Botao_Sim;
        private System.Windows.Forms.PictureBox pictureBox_Redirecionamento;
    }
}

