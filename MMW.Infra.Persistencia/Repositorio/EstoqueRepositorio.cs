using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class EstoqueRepositorio : BaseRepositorio<Estoque>, IEstoqueRepositorio
    {
        public MMWDbContext _contexto;

        public EstoqueRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Estoque> Listar(int produtoId)
        {
            return _contexto.Estoques
                .Where(e => e.ProdutoId == produtoId)
                .ToList();
        }
    }
}
