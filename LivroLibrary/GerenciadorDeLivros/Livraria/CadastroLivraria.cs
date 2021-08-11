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
    public partial class Livraria : Form
    {
        LivroLivrariaRepository repor = new LivroLivrariaRepository();

        public Livraria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            LivroLivrariaModel model = new LivroLivrariaModel();

            model.Nome = tbNome.Text;
            model.Preco = Convert.ToDecimal(tbPreco.Text);
            model.QuantEstoque = Convert.ToInt32(tbQuant.Text);
            model.Descricao = tbDescricao.Text;
            model.Autor = tbAutor.Text;
            repor.Create(model);
            limpar();

        }


        private void limpar()
        {
            tbNome.Text = String.Empty;
            tbAutor.Text = String.Empty;
            tbDescricao.Text = String.Empty;
            tbPreco.Text = String.Empty;
            tbQuant.Text = String.Empty;
        }
    }
}
