using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class Entrada :BaseEntidade
    {
        public virtual Loja Loja { get; set; }
        public int LojaId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }
                
        public DateTime DataEmissaoNota { get; set; }

        public string NumeroNota { get; set; }
        
        public Boolean baixada { get; set; }
                
        public DateTime dataBaixa { get; set; }
        
        public virtual ICollection<ItemEntrada> Itens { get; set; }
                
        public decimal Seguro
        {
            get
            {
                decimal valor = 0;
                try
                {
                    valor = Itens.Sum(e => e.seguro);
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
                    valor = Itens.Sum(e => e.frete);
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
                    valor = Itens.Sum(e => e.outrasDespesas);
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
                    valor = Itens.Sum(e => e.desconto);
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
                    valor = Itens.Sum(e => e.total);
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
