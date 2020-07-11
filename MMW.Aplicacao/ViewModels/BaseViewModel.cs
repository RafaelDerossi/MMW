using System;
using System.ComponentModel.DataAnnotations;

namespace MMW.Aplicacao.ViewModels
{
   public class BaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Dt.Inclusao")]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Dt.Alteracao")]
        public DateTime DataAlteracao { get; set; }
    }
}
