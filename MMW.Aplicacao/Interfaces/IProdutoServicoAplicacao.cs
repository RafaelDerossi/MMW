using MMW.Aplicacao.ViewModels;
using System.Collections.Generic;


namespace MMW.Aplicacao.Interfaces
{
   public interface IProdutoServicoAplicacao
    {
        void Adicionar(ProdutoViewModel produtoViewModel);

        ProdutoViewModel DetalharId(int id);

        IEnumerable<ProdutoViewModel> Listar();

        void Atualizar(ProdutoViewModel produtoViewModel);

        void Excluir(int id);

        void Dispose();
    }
}
