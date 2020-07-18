using System.ComponentModel.DataAnnotations;

namespace MMW.Aplicacao.ViewModels
{
    public class FornecedorViewModel : BaseViewModel
    {
        [Display(Name = "CNPJ")]
        [MinLength(14, ErrorMessage = "CNPJ deve ter 14 digitos")]
        [MaxLength(14, ErrorMessage = "CNPJ deve ter 14 digitos")]
        public string CNPJ { get; set; }

        [Display(Name = "Razao Social")]
        public string RazaoSocial { get; set; }
                
        public string Fantasia { get; set; }

    }
}
