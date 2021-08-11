
namespace GerenciadorDeLivros.Biblioteca
{
    partial class CadastroBiblioteca
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
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbLocalizacao = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbQuant = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbDescrição = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chDisp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(204, 355);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 23;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbLocalizacao
            // 
            this.tbLocalizacao.Location = new System.Drawing.Point(204, 274);
            this.tbLocalizacao.Name = "tbLocalizacao";
            this.tbLocalizacao.Size = new System.Drawing.Size(279, 20);
            this.tbLocalizacao.TabIndex = 21;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(204, 240);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(279, 20);
            this.tbDescricao.TabIndex = 20;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(204, 207);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(279, 20);
            this.tbAutor.TabIndex = 19;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(204, 179);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(279, 20);
            this.tbNome.TabIndex = 18;
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.Location = new System.Drawing.Point(73, 308);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(124, 17);
            this.lbQuant.TabIndex = 17;
            this.lbQuant.Text = "Disponibilidade:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(104, 274);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(96, 17);
            this.lbPreco.TabIndex = 16;
            this.lbPreco.Text = "Localização:";
            // 
            // lbDescrição
            // 
            this.lbDescrição.AutoSize = true;
            this.lbDescrição.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrição.Location = new System.Drawing.Point(120, 240);
            this.lbDescrição.Name = "lbDescrição";
            this.lbDescrição.Size = new System.Drawing.Size(80, 17);
            this.lbDescrição.TabIndex = 15;
            this.lbDescrição.Text = "Descrição:";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(144, 207);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(53, 17);
            this.lbAutor.TabIndex = 14;
            this.lbAutor.Text = "Autor:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(147, 179);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(50, 17);
            this.lbNome.TabIndex = 13;
            this.lbNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro";
            // 
            // chDisp
            // 
            this.chDisp.AutoSize = true;
            this.chDisp.Location = new System.Drawing.Point(203, 308);
            this.chDisp.Name = "chDisp";
            this.chDisp.Size = new System.Drawing.Size(15, 14);
            this.chDisp.TabIndex = 24;
            this.chDisp.UseVisualStyleBackColor = true;
            // 
            // CadastroBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chDisp);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbLocalizacao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbQuant);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbDescrição);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroBiblioteca";
            this.Text = "CadastroBiblioteca";
            this.Load += new System.EventHandler(this.CadastroBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbLocalizacao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDescrição;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chDisp;
    }
}