using System.Linq;
using System.Threading.Tasks;
using ExemploData.Controllers.Helps;
using ExemploData.Models;

namespace ExemploData.Controllers
{
    public class ClientesRepository
    {
        private readonly ClientesContext _clientesContext;
        public ClientesRepository(ClientesContext clientesContext)
        {
            _clientesContext = clientesContext;
        }
        public async Task<bool> Add(ClientesModels model)
        {
           await _clientesContext.Clientes.AddAsync(model);
           return await Save();
        }

        public async Task<bool> Delete(ClientesModels model)
        { 
            _clientesContext.Clientes.Remove(model);
            return await Save();
        }

        public IQueryable<ClientesModels> GetAll()
        {
            return _clientesContext.Clientes;
        }

        public async Task<bool> Updade(ClientesModels models)
        { 
            _clientesContext.Clientes.Update(models);
            return await Save();
        }

        private async Task<bool> Save()
        {
            return await _clientesContext.SaveChangesAsync() > 0 ? true : false;
        }
     }
}
