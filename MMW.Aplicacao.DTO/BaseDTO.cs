using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Entidades
{
   public class BaseDTO
    {
        public int Id { get; set; }     

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
