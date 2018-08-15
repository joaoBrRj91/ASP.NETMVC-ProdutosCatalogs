using System;
using System.Collections.Generic;

namespace CatalogoProdutos.Domain.Repositories
{
    public interface IRepository<T> : IDisposable
    {
        IList<T> ObterDados();
        T ObterDado();
        void SalvarOuAtualizar(T entity);
        void Deletar(int id);
    }
}
