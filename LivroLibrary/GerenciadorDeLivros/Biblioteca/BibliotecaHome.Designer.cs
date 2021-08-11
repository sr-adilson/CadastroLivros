
namespace GerenciadorDeLivros.Biblioteca
{
    partial class BibliotecaHome
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
            this.BtListarLivraria = new System.Windows.Forms.Button();
            this.btCadastroLivraria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtListarLivraria
            // 
            this.BtListarLivraria.Location = new System.Drawing.Point(280, 292);
            this.BtListarLivraria.Name = "BtListarLivraria";
            this.BtListarLivraria.Size = new System.Drawing.Size(240, 58);
            this.BtListarLivraria.TabIndex = 9;
            this.BtListarLivraria.Text = "Listar";
            this.BtListarLivraria.UseVisualStyleBackColor = true;
            this.BtListarLivraria.Click += new System.EventHandler(this.BtListarLivraria_Click);
            // 
            // btCadastroLivraria
            // 
            this.btCadastroLivraria.Location = new System.Drawing.Point(280, 188);
            this.btCadastroLivraria.Name = "btCadastroLivraria";
            this.btCadastroLivraria.Size = new System.Drawing.Size(240, 58);
            this.btCadastroLivraria.TabIndex = 8;
            this.btCadastroLivraria.Text = "Cadastro";
            this.btCadastroLivraria.UseVisualStyleBackColor = true;
            this.btCadastroLivraria.Click += new System.EventHandler(this.btCadastroLivraria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Biblioteca";
            // 
            // BibliotecaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtListarLivraria);
            this.Controls.Add(this.btCadastroLivraria);
            this.Controls.Add(this.label1);
            this.Name = "BibliotecaHome";
            this.Text = "BibliotecaHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtListarLivraria;
        private System.Windows.Forms.Button btCadastroLivraria;
        private System.Windows.Forms.Label label1;
    }
}