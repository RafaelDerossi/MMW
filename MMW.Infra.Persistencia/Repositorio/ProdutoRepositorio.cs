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
                    //Add produto
                    _contexto.Produtos.Add(produto);
                    _contexto.SaveChanges();

                    //Add estoques
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

                    try
                    {
                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return produto;
                }
                catch (Exception e)
                {
                    throw e;
                }

               
            }
        }

        public new void Excluir(int id)
        {
            using (var dbContextTransaction = _contexto.Database.BeginTransaction())
            {
                try
                {
                    //Exclui Estoques
                    var listaEstoques = _contexto.Estoques
                        .Where(e=>e.ProdutoId == id)
                        .ToList();
                    foreach (var estoque in listaEstoques)
                    {   
                        _contexto.Estoques.Remove(estoque);
                    }
                    
                    //Exclui Produto
                    _contexto.Produtos.Remove(_contexto.Produtos.Find(id));
                    _contexto.SaveChanges();

                    dbContextTransaction.Commit();                    
                }
                catch (Exception e)
                {
                    throw e;
                }               


            }
        }
    }
}
