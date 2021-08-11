
namespace GerenciadorDeLivros.Livraria
{
    partial class Livraria
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbDescrição = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQuant = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(131, 151);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(50, 17);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            this.lbNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(128, 179);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(53, 17);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Autor:";
            this.lbAutor.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbDescrição
            // 
            this.lbDescrição.AutoSize = true;
            this.lbDescrição.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrição.Location = new System.Drawing.Point(104, 212);
            this.lbDescrição.Name = "lbDescrição";
            this.lbDescrição.Size = new System.Drawing.Size(80, 17);
            this.lbDescrição.TabIndex = 3;
            this.lbDescrição.Text = "Descrição:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(132, 246);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(52, 17);
            this.lbPreco.TabIndex = 4;
            this.lbPreco.Text = "Preço:";
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.Location = new System.Drawing.Point(9, 277);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(172, 17);
            this.lbQuant.TabIndex = 5;
            this.lbQuant.Text = "Quantidade em estoque:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(188, 151);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(279, 20);
            this.tbNome.TabIndex = 6;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(188, 179);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(279, 20);
            this.tbAutor.TabIndex = 7;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(188, 212);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(279, 20);
            this.tbDescricao.TabIndex = 8;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(188, 246);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(279, 20);
            this.tbPreco.TabIndex = 9;
            // 
            // tbQuant
            // 
            this.tbQuant.Location = new System.Drawing.Point(188, 277);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(279, 20);
            this.tbQuant.TabIndex = 10;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(188, 327);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // CadastroLivraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbQuant);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbQuant);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbDescrição);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroLivraria";
            this.Text = "CadastroLivraria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbDescrição;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.Button btSalvar;
    }
}