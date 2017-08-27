using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId{ get; set; }

        [Required(ErrorMessage ="O campo é obrigatorio! ")]
        public string Nome{ get; set; }

    }
}