using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Nome Completo é obrigatório")]
        [Column(TypeName = "NVARCHAR(256)")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Idade é obrigatório")]
        [Column(TypeName = "INT")]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage ="Cargo obrigatório")]
        [Column(TypeName = "NVARCHAR(256)")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

    }
}
