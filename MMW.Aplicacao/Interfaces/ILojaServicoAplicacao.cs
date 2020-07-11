using MMW.Aplicacao.ViewModels;
using System.Collections.Generic;


namespace MMW.Aplicacao.Interfaces
{
   public interface ILojaServicoAplicacao
    {
        void Adicionar(LojaViewModel lojaViewModel);

        LojaViewModel DetalharId(int id);

        IEnumerable<LojaViewModel> Listar();

        void Atualizar(LojaViewModel lojaViewModel);

        void Excluir(int id);

        void Dispose();
    }
}
