using System;
using System.Collections.Generic;

namespace CatalogoProdutos.Domain.Repositories
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> ObterDados();
        T ObterDado(int id);
        void SalvarOuAtualizar(T entity);
        void Deletar(int id);
    }
}
