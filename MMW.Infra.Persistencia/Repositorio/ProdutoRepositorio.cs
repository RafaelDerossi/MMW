using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using System;
using System.Linq;

namespace MMW.Infra.Persistencia.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public MMWDbContext _contexto;

        public ProdutoRepositorio(MMWDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new Produto Adicionar(Produto produto)
        {
            using (var dbContextTransaction = _contexto.Database.BeginTransaction())
            {
                try
                {
                    _contexto.Produtos.Add(produto);
                    _contexto.SaveChanges();

                    var listaLojas = _contexto.Lojas.ToList();
                    foreach (var loja in listaLojas)
                    {
                        var estoque = new Estoque();
                        estoque.ProdutoId = produto.Id;
                        estoque.LojaId = loja.Id;
                        estoque.EmEstoque = 0;
                        estoque.localizacao = "";
                        _contexto.Estoques.Add(estoque);
                    }

                    _contexto.SaveChanges();

                    return produto;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

    }
}
