using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class EntradaDTO : BaseDTO
    {
        public virtual LojaDTO Loja { get; set; }
        public int LojaId { get; set; }

        public virtual FornecedorDTO Fornecedor { get; set; }
        public int FornecedorId { get; set; }
                
        public DateTime DataEmissaoNota { get; set; }

        public string NumeroNota { get; set; }
        
        public Boolean Baixada { get; set; }
                
        public DateTime DataBaixa { get; set; }
        
        public virtual ICollection<ItemEntradaDTO> Itens { get; set; }
                
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
            
        public decimal TotalNota
        {
            get
            {
                return (TotalDosProdutos + Frete + Seguro + OutrasDespesas - Desconto);
            }
        }
    }
}
