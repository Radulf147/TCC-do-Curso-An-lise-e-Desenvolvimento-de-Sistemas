namespace TCC
{
    partial class Tela_de_Cadastro
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
            this.Nome_Texto = new System.Windows.Forms.RichTextBox();
            this.CPF_Texto = new System.Windows.Forms.RichTextBox();
            this.Botao_Cadastrar = new System.Windows.Forms.Button();
            this.Label_Senha = new System.Windows.Forms.Label();
            this.Label_CPF = new System.Windows.Forms.Label();
            this.Label_Cadastro = new System.Windows.Forms.Label();
            this.Senha_Texto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome_Texto
            // 
            this.Nome_Texto.Location = new System.Drawing.Point(172, 199);
            this.Nome_Texto.Name = "Nome_Texto";
            this.Nome_Texto.Size = new System.Drawing.Size(310, 20);
            this.Nome_Texto.TabIndex = 31;
            this.Nome_Texto.Text = "";
            // 
            // CPF_Texto
            // 
            this.CPF_Texto.Location = new System.Drawing.Point(172, 131);
            this.CPF_Texto.Name = "CPF_Texto";
            this.CPF_Texto.Size = new System.Drawing.Size(310, 18);
            this.CPF_Texto.TabIndex = 30;
            this.CPF_Texto.Text = "";
            // 
            // Botao_Cadastrar
            // 
            this.Botao_Cadastrar.BackColor = System.Drawing.Color.CadetBlue;
            this.Botao_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Botao_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Cadastrar.Location = new System.Drawing.Point(172, 353);
            this.Botao_Cadastrar.Name = "Botao_Cadastrar";
            this.Botao_Cadastrar.Size = new System.Drawing.Size(310, 48);
            this.Botao_Cadastrar.TabIndex = 29;
            this.Botao_Cadastrar.Text = "Cadastrar";
            this.Botao_Cadastrar.UseVisualStyleBackColor = false;
            this.Botao_Cadastrar.Click += new System.EventHandler(this.Botao_Cadastrar_Click);
            // 
            // Label_Senha
            // 
            this.Label_Senha.AutoSize = true;
            this.Label_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_Senha.Location = new System.Drawing.Point(168, 177);
            this.Label_Senha.Name = "Label_Senha";
            this.Label_Senha.Size = new System.Drawing.Size(82, 20);
            this.Label_Senha.TabIndex = 28;
            this.Label_Senha.Text = "Seu nome";
            // 
            // Label_CPF
            // 
            this.Label_CPF.AutoSize = true;
            this.Label_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_CPF.Location = new System.Drawing.Point(169, 107);
            this.Label_CPF.Name = "Label_CPF";
            this.Label_CPF.Size = new System.Drawing.Size(73, 20);
            this.Label_CPF.TabIndex = 27;
            this.Label_CPF.Text = "Seu CPF";
            // 
            // Label_Cadastro
            // 
            this.Label_Cadastro.AutoSize = true;
            this.Label_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cadastro.ForeColor = System.Drawing.Color.Teal;
            this.Label_Cadastro.Location = new System.Drawing.Point(211, 9);
            this.Label_Cadastro.Name = "Label_Cadastro";
            this.Label_Cadastro.Size = new System.Drawing.Size(231, 59);
            this.Label_Cadastro.TabIndex = 26;
            this.Label_Cadastro.Text = "Cadastro";
            // 
            // Senha_Texto
            // 
            this.Senha_Texto.Location = new System.Drawing.Point(173, 268);
            this.Senha_Texto.Name = "Senha_Texto";
            this.Senha_Texto.Size = new System.Drawing.Size(310, 20);
            this.Senha_Texto.TabIndex = 33;
            this.Senha_Texto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(169, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sua senha";
            // 
            // Label_Alerta
            // 
            this.Label_Alerta.AutoSize = true;
            this.Label_Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alerta.ForeColor = System.Drawing.Color.Red;
            this.Label_Alerta.Location = new System.Drawing.Point(169, 311);
            this.Label_Alerta.Name = "Label_Alerta";
            this.Label_Alerta.Size = new System.Drawing.Size(236, 20);
            this.Label_Alerta.TabIndex = 34;
            this.Label_Alerta.Text = "O CPF inserido já foi cadastrado";
            this.Label_Alerta.Visible = false;
            // 
            // Tela_de_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 437);
            this.Controls.Add(this.Label_Alerta);
            this.Controls.Add(this.Senha_Texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome_Texto);
            this.Controls.Add(this.CPF_Texto);
            this.Controls.Add(this.Botao_Cadastrar);
            this.Controls.Add(this.Label_Senha);
            this.Controls.Add(this.Label_CPF);
            this.Controls.Add(this.Label_Cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tela_de_Cadastro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Nome_Texto;
        private System.Windows.Forms.RichTextBox CPF_Texto;
        private System.Windows.Forms.Button Botao_Cadastrar;
        private System.Windows.Forms.Label Label_Senha;
        private System.Windows.Forms.Label Label_CPF;
        private System.Windows.Forms.Label Label_Cadastro;
        private System.Windows.Forms.RichTextBox Senha_Texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Alerta;
    }
}