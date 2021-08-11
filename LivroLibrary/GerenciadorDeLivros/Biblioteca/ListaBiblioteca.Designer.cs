
namespace GerenciadorDeLivros.Biblioteca
{
    partial class ListaBiblioteca
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
            this.dbLivraria = new System.Windows.Forms.DataGridView();
            this.Dele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbLivraria)).BeginInit();
            this.SuspendLayout();
            // 
            // dbLivraria
            // 
            this.dbLivraria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbLivraria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dele,
            this.ID,
            this.Nome,
            this.Autor,
            this.Descricao,
            this.Localizacao,
            this.Disponibilidade});
            this.dbLivraria.Location = new System.Drawing.Point(49, 27);
            this.dbLivraria.Name = "dbLivraria";
            this.dbLivraria.Size = new System.Drawing.Size(703, 397);
            this.dbLivraria.TabIndex = 1;
            this.dbLivraria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbLivraria_CellContentClick);
            // 
            // Dele
            // 
            this.Dele.HeaderText = "";
            this.Dele.Name = "Dele";
            this.Dele.Width = 60;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Localizacao
            // 
            this.Localizacao.HeaderText = "Localização";
            this.Localizacao.Name = "Localizacao";
            // 
            // Disponibilidade
            // 
            this.Disponibilidade.HeaderText = "Disponibilidade";
            this.Disponibilidade.Name = "Disponibilidade";
            // 
            // ListaBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbLivraria);
            this.Name = "ListaBiblioteca";
            this.Text = "ListaBiblioteca";
            this.Load += new System.EventHandler(this.ListaBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbLivraria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbLivraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dele;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidade;
    }
}