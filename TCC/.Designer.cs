namespace TCC
{
    partial class Criar_Personagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criar_Personagem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cabelo_comboBox = new System.Windows.Forms.ComboBox();
            this.Blusa_comboBox = new System.Windows.Forms.ComboBox();
            this.Calca_comboBox = new System.Windows.Forms.ComboBox();
            this.Pele_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sexo_comboBox = new System.Windows.Forms.ComboBox();
            this.Blusa_label = new System.Windows.Forms.Label();
            this.Calca_label = new System.Windows.Forms.Label();
            this.Pele_label = new System.Windows.Forms.Label();
            this.Cabelo_label = new System.Windows.Forms.Label();
            this.Label_Alerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sexo:";
            // 
            // Nome_textBox
            // 
            this.Nome_textBox.Location = new System.Drawing.Point(646, 170);
            this.Nome_textBox.Name = "Nome_textBox";
            this.Nome_textBox.Size = new System.Drawing.Size(100, 20);
            this.Nome_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aparência";
            // 
            // Cabelo_comboBox
            // 
            this.Cabelo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cabelo_comboBox.FormattingEnabled = true;
            this.Cabelo_comboBox.Items.AddRange(new object[] {
            "castanho"});
            this.Cabelo_comboBox.Location = new System.Drawing.Point(396, 170);
            this.Cabelo_comboBox.Name = "Cabelo_comboBox";
            this.Cabelo_comboBox.Size = new System.Drawing.Size(122, 21);
            this.Cabelo_comboBox.TabIndex = 11;
            this.Cabelo_comboBox.Visible = false;
            // 
            // Blusa_comboBox
            // 
            this.Blusa_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Blusa_comboBox.FormattingEnabled = true;
            this.Blusa_comboBox.Items.AddRange(new object[] {
            "vermelho"});
            this.Blusa_comboBox.Location = new System.Drawing.Point(381, 207);
            this.Blusa_comboBox.Name = "Blusa_comboBox";
            this.Blusa_comboBox.Size = new System.Drawing.Size(122, 21);
            this.Blusa_comboBox.TabIndex = 17;
            this.Blusa_comboBox.Visible = false;
            // 
            // Calca_comboBox
            // 
            this.Calca_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Calca_comboBox.FormattingEnabled = true;
            this.Calca_comboBox.Items.AddRange(new object[] {
            "azul"});
            this.Calca_comboBox.Location = new System.Drawing.Point(381, 247);
            this.Calca_comboBox.Name = "Calca_comboBox";
            this.Calca_comboBox.Size = new System.Drawing.Size(122, 21);
            this.Calca_comboBox.TabIndex = 18;
            this.Calca_comboBox.Visible = false;
            // 
            // Pele_comboBox
            // 
            this.Pele_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pele_comboBox.FormattingEnabled = true;
            this.Pele_comboBox.Items.AddRange(new object[] {
            "branco"});
            this.Pele_comboBox.Location = new System.Drawing.Point(367, 288);
            this.Pele_comboBox.Name = "Pele_comboBox";
            this.Pele_comboBox.Size = new System.Drawing.Size(122, 21);
            this.Pele_comboBox.TabIndex = 19;
            this.Pele_comboBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sexo_comboBox
            // 
            this.Sexo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexo_comboBox.FormattingEnabled = true;
            this.Sexo_comboBox.Items.AddRange(new object[] {
            "masculino",
            "feminino"});
            this.Sexo_comboBox.Location = new System.Drawing.Point(646, 208);
            this.Sexo_comboBox.Name = "Sexo_comboBox";
            this.Sexo_comboBox.Size = new System.Drawing.Size(100, 21);
            this.Sexo_comboBox.TabIndex = 21;
            this.Sexo_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sexo_comboBox_SelectedIndexChanged);
            // 
            // Blusa_label
            // 
            this.Blusa_label.AutoSize = true;
            this.Blusa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blusa_label.Location = new System.Drawing.Point(231, 207);
            this.Blusa_label.Name = "Blusa_label";
            this.Blusa_label.Size = new System.Drawing.Size(144, 26);
            this.Blusa_label.TabIndex = 25;
            this.Blusa_label.Text = "Cor da Blusa:";
            this.Blusa_label.Visible = false;
            // 
            // Calca_label
            // 
            this.Calca_label.AutoSize = true;
            this.Calca_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calca_label.Location = new System.Drawing.Point(231, 247);
            this.Calca_label.Name = "Calca_label";
            this.Calca_label.Size = new System.Drawing.Size(145, 26);
            this.Calca_label.TabIndex = 24;
            this.Calca_label.Text = "Cor da Calça:";
            this.Calca_label.Visible = false;
            // 
            // Pele_label
            // 
            this.Pele_label.AutoSize = true;
            this.Pele_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pele_label.Location = new System.Drawing.Point(231, 288);
            this.Pele_label.Name = "Pele_label";
            this.Pele_label.Size = new System.Drawing.Size(133, 26);
            this.Pele_label.TabIndex = 23;
            this.Pele_label.Text = "Cor da Pele:";
            this.Pele_label.Visible = false;
            // 
            // Cabelo_label
            // 
            this.Cabelo_label.AutoSize = true;
            this.Cabelo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cabelo_label.Location = new System.Drawing.Point(231, 169);
            this.Cabelo_label.Name = "Cabelo_label";
            this.Cabelo_label.Size = new System.Drawing.Size(158, 26);
            this.Cabelo_label.TabIndex = 22;
            this.Cabelo_label.Text = "Cor do Cabelo:";
            this.Cabelo_label.Visible = false;
            // 
            // Label_Alerta
            // 
            this.Label_Alerta.AutoSize = true;
            this.Label_Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alerta.ForeColor = System.Drawing.Color.Red;
            this.Label_Alerta.Location = new System.Drawing.Point(222, 377);
            this.Label_Alerta.Name = "Label_Alerta";
            this.Label_Alerta.Size = new System.Drawing.Size(378, 20);
            this.Label_Alerta.TabIndex = 35;
            this.Label_Alerta.Text = "Preencha todos os campos para criar o personagem";
            this.Label_Alerta.Visible = false;
            // 
            // Criar_Personagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Alerta);
            this.Controls.Add(this.Blusa_label);
            this.Controls.Add(this.Calca_label);
            this.Controls.Add(this.Pele_label);
            this.Controls.Add(this.Cabelo_label);
            this.Controls.Add(this.Sexo_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pele_comboBox);
            this.Controls.Add(this.Calca_comboBox);
            this.Controls.Add(this.Blusa_comboBox);
            this.Controls.Add(this.Cabelo_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Criar_Personagem";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cabelo_comboBox;
        private System.Windows.Forms.ComboBox Blusa_comboBox;
        private System.Windows.Forms.ComboBox Calca_comboBox;
        private System.Windows.Forms.ComboBox Pele_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Sexo_comboBox;
        private System.Windows.Forms.Label Blusa_label;
        private System.Windows.Forms.Label Calca_label;
        private System.Windows.Forms.Label Pele_label;
        private System.Windows.Forms.Label Cabelo_label;
        private System.Windows.Forms.Label Label_Alerta;
    }
}