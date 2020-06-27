using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class ItemEntrada : BaseEntidade
    {
        public virtual Entrada Entrada { get; set; }        
        public int EntradaId { get; set; }

        public virtual Produto Produto { get; set; }        
        public int ProdutoId { get; set; }
                
        public string CodIntForn { get; set; }

        public int Item { get; set; }
                
        public decimal Qtd { get; set; }
                
        public decimal PrcUnit { get; set; }

        public decimal Desconto { get; set; }
                
        public decimal Total { get; set; }

        public decimal Seguro { get; set; }

        public decimal Frete { get; set; }
                
        public decimal OutrasDespesas { get; set; }
                
        public decimal PrcCustoCalc { get; set; }

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


        public decimal Markup { get; set; }
                
        public decimal PrcVendaSugerido
        {
            get
            {
                return PrcCustoCalc * ((Markup / 100) + 1);
            }
        }
            
    }
}
