using MMW.Aplicacao.ViewModels;
using System.Collections.Generic;


namespace MMW.Aplicacao.Interfaces
{
   public interface IFornecedorServicoAplicacao
    {
        void Adicionar(FornecedorViewModel FornecedorViewModel);

        FornecedorViewModel DetalharId(int id);

        IEnumerable<FornecedorViewModel> Listar();

        void Atualizar(FornecedorViewModel FornecedorViewModel);

        void Excluir(FornecedorViewModel FornecedorViewModel);

        void Dispose();
    }
}
