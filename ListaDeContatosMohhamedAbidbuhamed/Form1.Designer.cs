namespace ListaDeContatosMohhamedAbidbuhamed
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.listBoxContato = new System.Windows.Forms.ListBox();
            this.buttonContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(172, 66);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(292, 26);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(172, 122);
            this.textBoxSobrenome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(292, 26);
            this.textBoxSobrenome.TabIndex = 4;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(172, 177);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(292, 26);
            this.textBoxTelefone.TabIndex = 5;
            // 
            // listBoxContato
            // 
            this.listBoxContato.FormattingEnabled = true;
            this.listBoxContato.ItemHeight = 20;
            this.listBoxContato.Location = new System.Drawing.Point(620, 45);
            this.listBoxContato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxContato.Name = "listBoxContato";
            this.listBoxContato.Size = new System.Drawing.Size(520, 604);
            this.listBoxContato.TabIndex = 6;
            this.listBoxContato.SelectedIndexChanged += new System.EventHandler(this.listBoxContato_SelectedIndexChanged);
            // 
            // buttonContato
            // 
            this.buttonContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonContato.Location = new System.Drawing.Point(82, 432);
            this.buttonContato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContato.Name = "buttonContato";
            this.buttonContato.Size = new System.Drawing.Size(384, 132);
            this.buttonContato.TabIndex = 7;
            this.buttonContato.Text = "Incluir Contato";
            this.buttonContato.UseVisualStyleBackColor = false;
            this.buttonContato.Click += new System.EventHandler(this.buttonContato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.listBoxContato);
            this.Controls.Add(this.buttonContato);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.ListBox listBoxContato;
        private System.Windows.Forms.Button buttonContato;
    }
}

