using MMW.Aplicacao.ViewModels;
using System.Collections.Generic;


namespace MMW.Aplicacao.Interfaces
{
   public interface IItemEntradaServicoAplicacao
    {
        void Adicionar(ItemEntradaViewModel itemEntradaViewModel);

        ItemEntradaViewModel DetalharId(int id);

        IEnumerable<ItemEntradaViewModel> Listar();

        void Atualizar(ItemEntradaViewModel itemEntradaViewModel);

        void Excluir(ItemEntradaViewModel itemEntradaViewModel);

        void Dispose();
    }
}
