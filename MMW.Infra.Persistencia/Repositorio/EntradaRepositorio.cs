using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class EntradaRepositorio : BaseRepositorio<Entrada>, IEntradaRepositorio
    {
        public MMWDbContext _contexto;

        public EntradaRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
