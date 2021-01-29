﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdrugWeb.Models
{
    public class MedicamentoModel
    {
        [Display(Name = "Código")]
        [Key]
        [Required(ErrorMessage = "Código do medicamento é obrigatório")]
        public int IdMedicamento { get; set; }


        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, MinimumLength = 5, ErrorMessage = "Nome do medicamento deve ter entre 5 e 45 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Código de Barras")]
        public string CodigoBarras { get; set; }


        [Display(Name = "Categoria Medicamento")]
        public int IdCategoriaMedicamento { get; set; }

        

        public string Fabricante { get; set; }

     
    }
}
