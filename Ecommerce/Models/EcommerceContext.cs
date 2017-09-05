using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(): base("strConexao")
        {

        }

        public System.Data.Entity.DbSet<Ecommerce.Models.Departamento> Departamentoes { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.Cidade> Cidades { get; set; }
    }
}