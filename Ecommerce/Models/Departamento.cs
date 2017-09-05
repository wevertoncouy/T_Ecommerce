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
        [Display(Name ="Departamento")]
        public int DepartamentoId{ get; set; }

        [Required(ErrorMessage ="O campo é obrigatorio! ")]

        [Display(Name ="Nome")]
        public string Nome{ get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}