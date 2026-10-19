namespace Comercio.Infraestructure.Repositories;

using Comercio.Domain.Entities;
using Comercio.Domain.Repositories;


public class ClientesRepository : IClientes
{
    private readonly List<Cliente> _clientes = new
List<Cliente>
    {
        new Cliente { Id = 1, Nombre = "Juan", Nivel = 1 },
        new Cliente { Id = 2, Nombre = "Maria", Nivel = 2 },
        new Cliente { Id = 3, Nombre = "Pedro", Nivel = 3 }
    };

    public async Task<List<Cliente>> GetClientesAsync()
    {
        return await Task.FromResult(_clientes);
    }



}