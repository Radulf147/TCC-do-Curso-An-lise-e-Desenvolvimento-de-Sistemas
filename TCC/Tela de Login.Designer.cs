namespace TCC
{
    partial class Tela_De_Login
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
            this.Senha_Texto = new System.Windows.Forms.RichTextBox();
            this.CPF_Texto = new System.Windows.Forms.RichTextBox();
            this.Botao_Logar = new System.Windows.Forms.Button();
            this.Label_Cadastro = new System.Windows.Forms.Label();
            this.Label_Senha = new System.Windows.Forms.Label();
            this.Label_CPF = new System.Windows.Forms.Label();
            this.Botao_Cadastrar = new System.Windows.Forms.Button();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_Alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Senha_Texto
            // 
            this.Senha_Texto.Location = new System.Drawing.Point(224, 238);
            this.Senha_Texto.Name = "Senha_Texto";
            this.Senha_Texto.Size = new System.Drawing.Size(401, 30);
            this.Senha_Texto.TabIndex = 24;
            this.Senha_Texto.Text = "";
            // 
            // CPF_Texto
            // 
            this.CPF_Texto.Location = new System.Drawing.Point(224, 170);
            this.CPF_Texto.Name = "CPF_Texto";
            this.CPF_Texto.Size = new System.Drawing.Size(401, 31);
            this.CPF_Texto.TabIndex = 23;
            this.CPF_Texto.Text = "";
            // 
            // Botao_Logar
            // 
            this.Botao_Logar.BackColor = System.Drawing.Color.CadetBlue;
            this.Botao_Logar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Botao_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Logar.Location = new System.Drawing.Point(224, 330);
            this.Botao_Logar.Name = "Botao_Logar";
            this.Botao_Logar.Size = new System.Drawing.Size(401, 61);
            this.Botao_Logar.TabIndex = 22;
            this.Botao_Logar.Text = "Logar";
            this.Botao_Logar.UseVisualStyleBackColor = false;
            this.Botao_Logar.Click += new System.EventHandler(this.Botao_Logar_Click);
            // 
            // Label_Cadastro
            // 
            this.Label_Cadastro.AutoSize = true;
            this.Label_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cadastro.Location = new System.Drawing.Point(625, 433);
            this.Label_Cadastro.Name = "Label_Cadastro";
            this.Label_Cadastro.Size = new System.Drawing.Size(165, 20);
            this.Label_Cadastro.TabIndex = 21;
            this.Label_Cadastro.Text = "Ainda não tem conta?";
            // 
            // Label_Senha
            // 
            this.Label_Senha.AutoSize = true;
            this.Label_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_Senha.Location = new System.Drawing.Point(220, 215);
            this.Label_Senha.Name = "Label_Senha";
            this.Label_Senha.Size = new System.Drawing.Size(86, 20);
            this.Label_Senha.TabIndex = 20;
            this.Label_Senha.Text = "Sua senha";
            // 
            // Label_CPF
            // 
            this.Label_CPF.AutoSize = true;
            this.Label_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_CPF.Location = new System.Drawing.Point(221, 145);
            this.Label_CPF.Name = "Label_CPF";
            this.Label_CPF.Size = new System.Drawing.Size(73, 20);
            this.Label_CPF.TabIndex = 19;
            this.Label_CPF.Text = "Seu CPF";
            // 
            // Botao_Cadastrar
            // 
            this.Botao_Cadastrar.FlatAppearance.BorderSize = 0;
            this.Botao_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Cadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Botao_Cadastrar.Location = new System.Drawing.Point(787, 430);
            this.Botao_Cadastrar.Name = "Botao_Cadastrar";
            this.Botao_Cadastrar.Size = new System.Drawing.Size(111, 23);
            this.Botao_Cadastrar.TabIndex = 18;
            this.Botao_Cadastrar.Text = "Cadastre-se";
            this.Botao_Cadastrar.UseVisualStyleBackColor = true;
            this.Botao_Cadastrar.Click += new System.EventHandler(this.Botao_Cadastrar_Click);
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login.ForeColor = System.Drawing.Color.Teal;
            this.Label_Login.Location = new System.Drawing.Point(338, 46);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(148, 59);
            this.Label_Login.TabIndex = 17;
            this.Label_Login.Text = "Login";
            // 
            // Label_Alerta
            // 
            this.Label_Alerta.AutoSize = true;
            this.Label_Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alerta.ForeColor = System.Drawing.Color.Red;
            this.Label_Alerta.Location = new System.Drawing.Point(221, 285);
            this.Label_Alerta.Name = "Label_Alerta";
            this.Label_Alerta.Size = new System.Drawing.Size(264, 20);
            this.Label_Alerta.TabIndex = 25;
            this.Label_Alerta.Text = "Seu CPF ou Senha estão incorretos";
            this.Label_Alerta.Visible = false;
            // 
            // Tela_De_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 465);
            this.Controls.Add(this.Label_Alerta);
            this.Controls.Add(this.Senha_Texto);
            this.Controls.Add(this.CPF_Texto);
            this.Controls.Add(this.Botao_Logar);
            this.Controls.Add(this.Label_Cadastro);
            this.Controls.Add(this.Label_Senha);
            this.Controls.Add(this.Label_CPF);
            this.Controls.Add(this.Botao_Cadastrar);
            this.Controls.Add(this.Label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_De_Login";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Senha_Texto;
        private System.Windows.Forms.RichTextBox CPF_Texto;
        private System.Windows.Forms.Button Botao_Logar;
        private System.Windows.Forms.Label Label_Cadastro;
        private System.Windows.Forms.Label Label_Senha;
        private System.Windows.Forms.Label Label_CPF;
        private System.Windows.Forms.Button Botao_Cadastrar;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_Alerta;
    }
}