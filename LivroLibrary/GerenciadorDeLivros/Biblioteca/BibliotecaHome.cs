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
    public partial class BibliotecaHome : Form
    {
        public BibliotecaHome()
        {
            InitializeComponent();
        }

        private void btCadastroLivraria_Click(object sender, EventArgs e)
        {
            CadastroBiblioteca c = new CadastroBiblioteca();
            c.Show();
        }

        private void BtListarLivraria_Click(object sender, EventArgs e)
        {
            ListaBiblioteca l = new ListaBiblioteca();
            l.Show();
        }
    }
}
