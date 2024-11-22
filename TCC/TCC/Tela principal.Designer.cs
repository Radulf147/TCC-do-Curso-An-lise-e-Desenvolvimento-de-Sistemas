namespace TCC
{
    partial class Salaroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaroll));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Botao_Jogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(427, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 81);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basic";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(889, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(406, 414);
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
            this.Botao_Jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Jogar.FlatAppearance.BorderSize = 0;
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
            // Salaroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Botao_Jogar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Salaroll";
            this.Text = "Basic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Botao_Jogar;
    }
}

