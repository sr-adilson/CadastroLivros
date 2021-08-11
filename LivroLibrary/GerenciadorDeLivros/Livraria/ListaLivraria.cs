using LivroLibrary.Models;
using LivroLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeLivros.Livraria
{
    public partial class ListaLivraria : Form
    {
        LivroLivrariaRepository repor = new LivroLivrariaRepository();

        public ListaLivraria()
        {
            InitializeComponent();
            dbLivraria.AutoGenerateColumns = false;
            dbLivraria.AllowUserToAddRows = false;
        }

        private void ListaLivraria_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {

            List<LivroLivrariaModel> lista = repor.Read();
            dbLivraria.Rows.Clear();
            foreach (LivroLivrariaModel livra in lista)
            {
                dbLivraria.Rows.Add("Delete", livra.Id, livra.Nome, livra.Autor, livra.Descricao, livra.Preco, livra.QuantEstoque);
            }
            dbLivraria.Refresh();
        }

        private void dbLivraria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<LivroLivrariaModel> lista = repor.Read();

            if (e.ColumnIndex.Equals(0))
            {
                repor.Delete(lista[e.RowIndex].Id);
            }
           
            CarregarLista();
        }
    }
}
