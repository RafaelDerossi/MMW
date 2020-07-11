using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MMW.Aplicacao.ViewModels
{
    public class EntradaViewModel : BaseViewModel
    {
        [Display(Name = "Loja")]
        public virtual LojaViewModel Loja { get; set; }
        public int LojaId { get; set; }

        [Display(Name = "Fornecedor")]
        public virtual FornecedorViewModel Fornecedor { get; set; }
        public int FornecedorId { get; set; }

        [Display(Name = "Dt.Emissao da Nota")]
        public DateTime DataEmissaoNota { get; set; }

        [Display(Name = "Nº da Nota")]
        public string NumeroNota { get; set; }

        
        public Boolean Baixada { get; set; }

        [Display(Name = "Dt.da Baixa ")]
        public DateTime DataBaixa { get; set; }
        
        public virtual ICollection<ItemEntradaViewModel> Itens { get; set; }
                

        public decimal Seguro
        {
            get
            {
                decimal valor = 0;
                try
                {
                    valor = Itens.Sum(e => e.Seguro);
                }
                catch (Exception)
                {
                }
                return valor;
            }
        }
        
        public decimal Frete
        {
            get
            {
                decimal valor = 0;
                try
                {
                    valor = Itens.Sum(e => e.Frete);
                }
                catch (Exception)
                {
                }
                return valor;
            }
        }

        [Display(Name = "Outras Despesas")]
        public decimal OutrasDespesas
        {
            get
            {
                decimal valor = 0;
                try
                {
                    valor = Itens.Sum(e => e.OutrasDespesas);
                }
                catch (Exception)
                {
                }
                return valor;
            }
        }
        
        public decimal Desconto
        {
            get
            {
                decimal valor = 0;
                try
                {
                    valor = Itens.Sum(e => e.Desconto);
                }
                catch (Exception)
                {
                }
                return valor;
            }
        }

        [Display(Name = "Total dos Produtos")]
        public decimal TotalDosProdutos
        {
            get
            {
                decimal valor = 0;
                try
                {
                    valor = Itens.Sum(e => e.Total);
                }
                catch (Exception)
                {
                }
                return valor;
            }
        }

        [Display(Name = "Total da Nota")]
        public decimal TotalNota
        {
            get
            {
                return (TotalDosProdutos + Frete + Seguro + OutrasDespesas - Desconto);
            }
        }
    }
}
