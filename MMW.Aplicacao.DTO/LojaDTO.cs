using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Entidades
{
  public class LojaDTO : BaseDTO
    {
        public string CNPJ { get; set; }
        
        public string RazaoSocal { get; set; }
        
        public string Fantasia { get; set; }

    }
}
