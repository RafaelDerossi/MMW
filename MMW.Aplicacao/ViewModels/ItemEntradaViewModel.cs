
using System.ComponentModel.DataAnnotations;

namespace MMW.Aplicacao.ViewModels
{
   public class ItemEntradaViewModel : BaseViewModel
    {
        [Display(Name = "Entrada")]
        public virtual EntradaViewModel Entrada { get; set; }        
        public int EntradaId { get; set; }

        [Display(Name = "Produto")]
        public virtual ProdutoViewModel Produto { get; set; }        
        public int ProdutoId { get; set; }

        [Display(Name = "Cod.Interno do Fornecedor")]
        public string CodIntForn { get; set; }

        
        public int Item { get; set; }

        [Display(Name = "Quantidade")]
        public decimal Qtd { get; set; }

        [Display(Name = "Preço Unitario")]
        public decimal PrcUnit { get; set; }


        public decimal Desconto { get; set; }
                
        public decimal Total { get; set; }

        public decimal Seguro { get; set; }

        public decimal Frete { get; set; }

        [Display(Name = "Outras Despesas")]
        public decimal OutrasDespesas { get; set; }

        [Display(Name = "Preço de Custo")]
        public decimal PrcCustoCalc { get; set; }

        [Display(Name = "Desconto por un.")]
        public decimal DescontoPorUN
        {
            get
            {
                if (Qtd > 0)
                {
                    return (Desconto / Qtd);
                }
                else
                {
                    return (0);
                }

            }
        }

        [Display(Name = "Seguro por un.")]
        public decimal SeguroPorUN
        {
            get
            {
                if (Qtd > 0)
                {
                    return (Seguro / Qtd);
                }
                else
                {
                    return (0);
                }

            }
        }

        [Display(Name = "Frete por un.")]
        public decimal FretePorUN
        {
            get
            {
                if (Qtd > 0)
                {
                    return (Frete / Qtd);
                }
                else
                {
                    return (0);
                }

            }
        }

        [Display(Name = "Outras Despesas por un.")]
        public decimal OutrasDespesasPorUN
        {
            get
            {
                if (Qtd > 0)
                {
                    return (OutrasDespesas / Qtd);
                }
                else
                {
                    return (0);
                }

            }
        }

        [Display(Name = "Mark-up")]
        public decimal Markup { get; set; }

        [Display(Name = "Preço de Venda Sugerido")]
        public decimal PrcVendaSugerido { get; set; }        
               
    }
}
