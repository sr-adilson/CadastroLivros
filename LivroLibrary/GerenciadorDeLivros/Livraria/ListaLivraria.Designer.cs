
namespace GerenciadorDeLivros.Livraria
{
    partial class ListaLivraria
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
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Preco,
            this.Quant});
            this.dbLivraria.Location = new System.Drawing.Point(40, 27);
            this.dbLivraria.Name = "dbLivraria";
            this.dbLivraria.Size = new System.Drawing.Size(703, 397);
            this.dbLivraria.TabIndex = 0;
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
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quant em estoque";
            this.Quant.Name = "Quant";
            // 
            // ListaLivraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbLivraria);
            this.Name = "ListaLivraria";
            this.Text = "ListaLivraria";
            this.Load += new System.EventHandler(this.ListaLivraria_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
    }
}