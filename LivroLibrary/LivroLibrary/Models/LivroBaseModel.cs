using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLibrary.Models
{
    public abstract class LivroBaseModel
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Autor { get; set; }

        public string Descricao { get; set; }

    }
}
