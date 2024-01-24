
namespace SRP.Repositories
{
    public interface IRepositorio<T>
    {
        void Salvar(T entity);
    }
}
