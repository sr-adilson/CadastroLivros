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

namespace GerenciadorDeLivros.Biblioteca
{
    public partial class ListaBiblioteca : Form
    {
        LivroBibliotecaRepository repor = new LivroBibliotecaRepository();

        public ListaBiblioteca()
        {
            InitializeComponent();
            dbLivraria.AutoGenerateColumns = false;
            dbLivraria.AllowUserToAddRows = false;
        }

        private void ListaBiblioteca_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {

            List<LivroBibliotecaModel> lista = repor.Read();
            dbLivraria.Rows.Clear();
            foreach (LivroBibliotecaModel livra in lista)
            {
                dbLivraria.Rows.Add("Delete", livra.Id, livra.Nome, livra.Autor, livra.Descricao, livra.Descricao, livra.Disponibilidade);
            }
            dbLivraria.Refresh();
        }

        private void dbLivraria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<LivroBibliotecaModel> lista = repor.Read();

            if (e.ColumnIndex.Equals(0))
            {
                repor.Delete(lista[e.RowIndex].Id);
            }

            CarregarLista();
        }
    }
}
