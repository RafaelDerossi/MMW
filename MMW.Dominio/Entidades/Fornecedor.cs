using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class Fornecedor : BaseEntidade
    {        
        public string CNPJ { get; set; }
                
        public string RazaoSocial { get; set; }
                
        public string Fantasia { get; set; }

    }
}
