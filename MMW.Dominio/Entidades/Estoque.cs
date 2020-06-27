using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class Estoque : BaseEntidade
    {
        public virtual Produto Produto { get; set; }        
        public int ProdutoId { get; set; }

        public virtual Loja Loja { get; set; }
        public int LojaId { get; set; }

        public decimal EmEstoque { get; set; }       
        
        //localização no estoque da loja
        public string localizacao { get; set; }       
        
    }
}
