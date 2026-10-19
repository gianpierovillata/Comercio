namespace Comercio.Api.Controllers;

using Comercio.Aplication.Services;
using Comercio.Domain.Entities;


public class ClientesController
{
    private readonly ClientesServices _clientesServices;

    public ClientesController(ClientesServices clientesServices)
    {
        _clientesServices = clientesServices;
    }

    public async Task<List<Cliente>> GetClientesAsync()
    {
        return await _clientesServices.GetClientesAsync();
    }
}