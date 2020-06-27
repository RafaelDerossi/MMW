using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public MMWDbContext _contexto;

        public ProdutoRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
