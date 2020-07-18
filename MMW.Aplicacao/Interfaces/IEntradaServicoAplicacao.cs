using MMW.Aplicacao.ViewModels;
using System.Collections.Generic;


namespace MMW.Aplicacao.Interfaces
{
   public interface IEntradaServicoAplicacao
    {
        EntradaViewModel Adicionar(EntradaViewModel entradaViewModel);

        EntradaViewModel DetalharId(int id);

        IEnumerable<EntradaViewModel> Listar();

        void Atualizar(EntradaViewModel entradaViewModel);

        void Excluir(int id);

        void Dispose();
    }
}
