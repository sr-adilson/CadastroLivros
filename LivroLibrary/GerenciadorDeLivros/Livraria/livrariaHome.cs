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
    public partial class livrariaHome : Form
    {
        public livrariaHome()
        {
            InitializeComponent();
        }

        private void btCadastroLivraria_Click(object sender, EventArgs e)
        {
            Livraria cadastroLivraria = new Livraria();
            cadastroLivraria.Show();
        }

        private void BtListarLivraria_Click(object sender, EventArgs e)
        {
            ListaLivraria lista = new ListaLivraria();
            lista.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
