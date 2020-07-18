using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MMW.Aplicacao.ViewModels
{
  public class LojaViewModel : BaseViewModel
    {
        [Display(Name = "CNPJ")]
        [MinLength(14, ErrorMessage = "CNPJ deve ter 14 digitos")]
        [MaxLength(14, ErrorMessage = "CNPJ deve ter 14 digitos")]
        public string CNPJ { get; set; }

        [Display(Name = "Razao Social")]
        public string RazaoSocal { get; set; }

        [Display(Name = "Fantasia")]
        public string Fantasia { get; set; }

    }
}
