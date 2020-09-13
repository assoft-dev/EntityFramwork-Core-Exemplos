using System.Threading.Tasks;

namespace ExemploData.Controllers
{
    public interface IRepository<T>
    {
        Task<bool> Add(T Models);
        Task<bool> Updade(T Models);
        Task<bool> Delete(T Models);
        Task<bool> GetAll();
    }
}