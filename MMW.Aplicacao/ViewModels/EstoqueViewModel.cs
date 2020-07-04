namespace MMW.Aplicacao.ViewModels
{
    public class EstoqueViewModel : BaseViewModel
    {
        public virtual ProdutoViewModel Produto { get; set; }        
        public int ProdutoId { get; set; }

        public virtual LojaViewModel Loja { get; set; }
        public int LojaId { get; set; }

        public decimal EmEstoque { get; set; }       
        
        //localização no estoque da loja
        public string localizacao { get; set; }       
        
    }
}
