using MMW.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMW.Aplicacao.DTO
{
   public class ProdutoDTO : BaseDTO
    {
        public string Descricao { get; set; }

        public decimal PrcUnit { get; set; }

        public Boolean Inativo { get; set; }

        public virtual ICollection<EstoqueDTO> Estoques { get; set; }

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

        public virtual ICollection<ItemEntradaDTO> ItensEntrada { get; set; }
    }
}
