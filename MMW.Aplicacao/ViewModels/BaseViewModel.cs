using System;

namespace MMW.Aplicacao.ViewModels
{
   public class BaseViewModel
    {
        public int Id { get; set; }     

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
