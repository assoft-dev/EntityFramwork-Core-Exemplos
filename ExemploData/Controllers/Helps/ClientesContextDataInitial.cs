using Microsoft.EntityFrameworkCore;

namespace ExemploData.Controllers.Helps
{
    public class ClientesContextDataInitial
    {
        private readonly ClientesContext _clientesContext;
        public ClientesContextDataInitial(ClientesContext clientesContext)
        {
            _clientesContext = clientesContext;
        }
        public void Seed()
        {
            //await _clientesContext.Database.EnsureCreatedAsync();
             _clientesContext.Database.Migrate();
        }
    }
}
