using Comercio.Domain.Entities;
namespace Comercio.Domain.Repositories;

public interface IClientes
{
     public Task<List<Cliente>> GetClientesAsync();

   /*  public async Task<Cliente> GetClienteAsync(int Id);
    public async Task<Cliente> CreateClienteAsync(Cliente cliente);
    public async Task<Cliente> UpdateClienteAsync(Cliente cliente);
    public async Task DeleteClienteAsync(int Id); */

}