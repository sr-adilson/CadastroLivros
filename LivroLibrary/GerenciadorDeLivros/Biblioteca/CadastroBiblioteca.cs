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
    public partial class CadastroBiblioteca : Form
    {

        LivroBibliotecaRepository repor = new LivroBibliotecaRepository();
        public CadastroBiblioteca()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            LivroBibliotecaModel model = new LivroBibliotecaModel();

            model.Nome = tbNome.Text;
            model.Disponibilidade = chDisp.Checked;
            model.Localizacao = tbLocalizacao.Text;
            model.Descricao = tbDescricao.Text;
            model.Autor = tbAutor.Text;
            repor.Create(model);
            limpar();
        }

        private void CadastroBiblioteca_Load(object sender, EventArgs e)
        {

        }

        private void limpar()
        {
            tbNome.Text = String.Empty;
            tbAutor.Text = String.Empty;
            tbDescricao.Text = String.Empty;
            tbLocalizacao.Text = String.Empty;
            chDisp.Text = String.Empty;
        }
    }
}
