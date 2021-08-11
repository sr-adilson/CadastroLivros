
namespace GerenciadorDeLivros
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
            this.btBiblioteca = new System.Windows.Forms.Button();
            this.btLivraria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btBiblioteca
            // 
            this.btBiblioteca.Location = new System.Drawing.Point(262, 140);
            this.btBiblioteca.Name = "btBiblioteca";
            this.btBiblioteca.Size = new System.Drawing.Size(240, 58);
            this.btBiblioteca.TabIndex = 1;
            this.btBiblioteca.Text = "Biblioteca";
            this.btBiblioteca.UseVisualStyleBackColor = true;
            this.btBiblioteca.Click += new System.EventHandler(this.btBiblioteca_Click);
            // 
            // btLivraria
            // 
            this.btLivraria.Location = new System.Drawing.Point(262, 260);
            this.btLivraria.Name = "btLivraria";
            this.btLivraria.Size = new System.Drawing.Size(240, 58);
            this.btLivraria.TabIndex = 2;
            this.btLivraria.Text = "Livraria";
            this.btLivraria.UseVisualStyleBackColor = true;
            this.btLivraria.Click += new System.EventHandler(this.btLivraria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLivraria);
            this.Controls.Add(this.btBiblioteca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBiblioteca;
        private System.Windows.Forms.Button btLivraria;
    }
}

