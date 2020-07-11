using System.ComponentModel.DataAnnotations;

namespace MMW.Aplicacao.ViewModels
{
    public class EstoqueViewModel : BaseViewModel
    {
        [Display(Name = "Produto")]
        public virtual ProdutoViewModel Produto { get; set; }        
        public int ProdutoId { get; set; }

        [Display(Name = "Loja")]
        public virtual LojaViewModel Loja { get; set; }
        public int LojaId { get; set; }

        [Display(Name = "Em Estoque")]
        public decimal EmEstoque { get; set; }

        //localização no estoque da loja
        [Display(Name = "Localizacao")]
        public string localizacao { get; set; }       
        
    }
}
