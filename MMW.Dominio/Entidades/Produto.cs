using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class Produto : BaseEntidade
    {
        public string Descricao { get; set; }
        
        public decimal PrcUnit { get; set; }
                        
        public Boolean Inativo { get; set; }

        public virtual ICollection<Estoque> Estoques { get; set; }
              
        public decimal EstoqueTotal
        {
            get
            {
                decimal est = 0;
                try
                {
                    est = Estoques                         
                         .Sum(e => e.EmEstoque);
                }
                catch (Exception)
                {
                }

                return est;
            }
        }

        public virtual ICollection<ItemEntrada> ItensEntrada { get; set; }

    }
}
