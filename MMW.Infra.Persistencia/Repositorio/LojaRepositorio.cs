using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class LojaRepositorio : BaseRepositorio<Loja>, ILojaRepositorio
    {
        public MMWDbContext _contexto;

        public LojaRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
