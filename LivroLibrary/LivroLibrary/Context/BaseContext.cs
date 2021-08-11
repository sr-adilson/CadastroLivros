using LivroLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLibrary.Context
{
    class BaseContext: DbContext
    {
        //public DbSet<Biblioteca> Biblioteca { get; set; }
        public DbSet<LivroLivrariaModel> Livraria { get; set; }
        public BaseContext(): base("DbConectionLibrary")
        { 

        }
    }
}
