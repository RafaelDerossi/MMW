using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class FornecedorRepositorio : BaseRepositorio<Fornecedor>, IFornecedorRepositorio
    {
        public MMWDbContext _contexto;

        public FornecedorRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
