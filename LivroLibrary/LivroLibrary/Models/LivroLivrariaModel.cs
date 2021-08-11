using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLibrary.Models
{
    public class LivroLivrariaModel : LivroBaseModel
    {
        public decimal Preco { get; set; }
        public int QuantEstoque { get; set; }
    }
}
