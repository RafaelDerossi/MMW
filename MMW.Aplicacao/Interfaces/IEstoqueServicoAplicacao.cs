using MMW.Aplicacao.ViewModels;
using System.Collections.Generic;


namespace MMW.Aplicacao.Interfaces
{
   public interface IEstoqueServicoAplicacao
    {    

        EstoqueViewModel DetalharId(int id);

        IEnumerable<EstoqueViewModel> Listar();

        IEnumerable<EstoqueViewModel> Listar(int produtoId);

        void Atualizar(EstoqueViewModel estoqueViewModel);

       
        void Dispose();
    }
}
