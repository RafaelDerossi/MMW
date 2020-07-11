using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class ItemEntradaRepositorio : BaseRepositorio<ItemEntrada>, IItemEntradaRepositorio
    {
        public MMWDbContext _contexto;

        public ItemEntradaRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
